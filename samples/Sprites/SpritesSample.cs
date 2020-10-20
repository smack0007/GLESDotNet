﻿using System;
using static GLESDotNet.GLES2;
using System.Text;
using GLESDotNet.Samples;
using ImageDotNet;
using System.Numerics;
using System.Globalization;

namespace Sprites
{
    public struct TextureData
    {
        public uint Handle { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }
    }

    public struct SmileyData
    {
        public int SrcX { get; set; }
        
        public int SrcY { get; set; }

        public int SrcWidth { get; set; }

        public int SrcHeight { get; set; }

        public Vector2 Position { get; set; }

        public Vector4 Tint { get; set; }
    }

    public unsafe class SpritesSample : Sample
    {
        private uint _program;
        private int _vertTransformLocation;
        private int _fragTextureLocation;
        private uint _textureHandle;

        private TextureData _glesTexture;
        private TextureData _smileyTexture;

        private const int VertsPerSprite = 6;
        private const int MaxSpriteCount = 1024;

        private int _spriteCount = 0;
        private Vector3[] _vertPositions = new Vector3[MaxSpriteCount * VertsPerSprite];
        private Vector4[] _vertColors = new Vector4[MaxSpriteCount * VertsPerSprite];
        private Vector2[] _vertTexCoords = new Vector2[MaxSpriteCount * VertsPerSprite];

        private const int SmileyCount = 256;
        private SmileyData[] _smileys = new SmileyData[SmileyCount];

        public static void Main(string[] args)
        {
            using var sample = new SpritesSample();
            sample.Run();
        }

        public SpritesSample()
            : base("Sprites")
        {
        }

        private static uint CompileShader(string shaderSrc, uint type)
        {
            var shader = glCreateShader(type);

            if (shader == 0)
                return 0;

            var shaderSrcTmp = new string[] { shaderSrc };
            var shaderLength = shaderSrc.Length;
            glShaderSource(shader, 1, shaderSrcTmp, &shaderLength);

            glCompileShader(shader);

            int compiled;
            glGetShaderiv(shader, GL_COMPILE_STATUS, &compiled);

            if (compiled == 0)
            {
                int infoLength;
                glGetShaderiv(shader, GL_INFO_LOG_LENGTH, &infoLength);

                if (infoLength > 1)
                {
                    var infoLog = new StringBuilder(infoLength);
                    glGetShaderInfoLog(shader, infoLength, null, infoLog);
                    glDeleteShader(shader);
                    throw new InvalidOperationException($"Error compiling shader:\n{infoLog}");
                }
            }

            return shader;
        }

        private static void LinkProgram(uint program)
        {
            glLinkProgram(program);

            int linked;
            glGetProgramiv(program, GL_LINK_STATUS, &linked);

            if (linked == 0)
            {
                int infoLength;
                glGetProgramiv(program, GL_INFO_LOG_LENGTH, &infoLength);

                if (infoLength > 1)
                {
                    var infoLog = new StringBuilder(infoLength);
                    glGetProgramInfoLog(program, infoLength, null, infoLog);
                    glDeleteProgram(program);
                    throw new InvalidOperationException($"Error linking program:\n{infoLog}");
                }
            }
        }

        private static TextureData LoadTexture(string fileName)
        {
            uint handle;
            glGenTextures(1, &handle);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, handle);

            var image = Image.LoadPng(fileName).To<Rgba32>();
            using (var data = image.GetDataPointer())
            {
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, image.Width, image.Height, 0, GL_RGBA, GL_UNSIGNED_BYTE, data.Pointer);
            }

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            return new TextureData() { Handle = handle, Width = image.Width, Height = image.Height };
        }

        protected override void Initialize()
        {
            string vertShader =
@"attribute vec3 vertPosition;
attribute vec4 vertColor;
attribute vec2 vertTexCoord;

varying vec4 fragColor;
varying vec2 fragTexCoord;

uniform mat4 vertTransform; 

void main()
{
    gl_Position = vertTransform * vec4(vertPosition, 1.0);
    fragColor = vertColor;
    fragTexCoord = vertTexCoord;
}";

            string fragShader =
@"precision mediump float;

varying vec4 fragColor;
varying vec2 fragTexCoord;

uniform sampler2D fragTexture;

void main()
{
    gl_FragColor = fragColor * texture2D(fragTexture, fragTexCoord);
}";

            uint vertexShader = CompileShader(vertShader, GL_VERTEX_SHADER);
            uint fragmentShader = CompileShader(fragShader, GL_FRAGMENT_SHADER);

            _program = glCreateProgram();
            if (_program == 0)
                throw new InvalidOperationException("Failed to create program.");

            glAttachShader(_program, vertexShader);
            glAttachShader(_program, fragmentShader);

            glBindAttribLocation(_program, 0, "vertPosition");
            glBindAttribLocation(_program, 1, "vertColor");
            glBindAttribLocation(_program, 2, "vertTexCoord");
            LinkProgram(_program);

            _vertTransformLocation = glGetUniformLocation(_program, "vertTransform");
            _fragTextureLocation = glGetUniformLocation(_program, "fragTexture");

            _glesTexture = LoadTexture("opengles.png");
            _smileyTexture = LoadTexture("smiley.png");

            glEnable(GL_BLEND);
            glBlendFuncSeparate(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_ONE, GL_ZERO);
            glClearColor(0.0f, 0.0f, 0.0f, 1.0f);

            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
            glEnableVertexAttribArray(2);

            var random = new Random();
            for (int i = 0; i < _smileys.Length; i++)
            {
                _smileys[i].SrcWidth = 128;
                _smileys[i].SrcHeight = 128;

                switch (random.Next(4))
                {
                    case 0:
                        _smileys[i].SrcX = 0;
                        _smileys[i].SrcY = 0;
                        break;

                    case 1:
                        _smileys[i].SrcX = 128;
                        _smileys[i].SrcY = 0;
                        break;

                    case 2:
                        _smileys[i].SrcX = 0;
                        _smileys[i].SrcY = 128;
                        break;

                    case 3:
                        _smileys[i].SrcX = 128;
                        _smileys[i].SrcY = 128;
                        break;
                }

                _smileys[i].Position = new Vector2(random.Next(WindowWidth), random.Next(WindowHeight));
                
                _smileys[i].Tint = new Vector4(
                    (float)random.NextDouble(),
                    (float)random.NextDouble(),
                    (float)random.NextDouble(),
                    (float)random.NextDouble());
            }
        }

        private void AddSprite(
            in TextureData texture,
            in Vector2 position,
            in Vector2 size,
            int srcX,
            int srcY,
            int srcWidth,
            int srcHeight,
            in Vector4 tint)
        {
            if (texture.Handle != _textureHandle)
                Flush();

            _textureHandle = texture.Handle;

            var spriteVertPositions = new Vector3[]
            {
                new Vector3(position.X, position.Y, 0.0f),
                new Vector3(position.X + size.X, position.Y, 0.0f),
                new Vector3(position.X, position.Y + size.Y, 0.0f),

                new Vector3(position.X + size.X, position.Y, 0.0f),
                new Vector3(position.X + size.X, position.Y + size.Y, 0.0f),
                new Vector3(position.X, position.Y + size.Y, 0.0f),
            };

            fixed (Vector3* srcPtr = spriteVertPositions)
            fixed (Vector3* destPtr = _vertPositions)
            {
                Buffer.MemoryCopy(
                    srcPtr,
                    destPtr + (_spriteCount * VertsPerSprite),
                    VertsPerSprite * sizeof(Vector3),
                    VertsPerSprite * sizeof(Vector3));
            }

            var spriteVertColors = new Vector4[]
            {
                tint,
                tint,
                tint,

                tint,
                tint,
                tint,
            };

            fixed (Vector4* srcPtr = spriteVertColors)
            fixed (Vector4* destPtr = _vertColors)
            {
                Buffer.MemoryCopy(
                    srcPtr,
                    destPtr + (_spriteCount * VertsPerSprite),
                    VertsPerSprite * sizeof(Vector4),
                    VertsPerSprite * sizeof(Vector4));
            }

            var spriteVertTexCoords = new Vector2[]
            {
                new Vector2(srcX / (float)texture.Width, srcY / (float)texture.Height),
                new Vector2((srcX + srcWidth) / (float)texture.Width, srcY / (float)texture.Height),
                new Vector2(srcX / (float)texture.Width, (srcY + srcHeight) / (float)texture.Height),

                new Vector2((srcX + srcWidth) / (float)texture.Width, srcY / (float)texture.Height),
                new Vector2((srcX + srcWidth) / (float)texture.Width, (srcY + srcHeight) / (float)texture.Height),
                new Vector2(srcX / (float)texture.Width, (srcY + srcHeight) / (float)texture.Height),
            };

            fixed (Vector2* srcPtr = spriteVertTexCoords)
            fixed (Vector2* destPtr = _vertTexCoords)
            {
                Buffer.MemoryCopy(
                    srcPtr,
                    destPtr + (_spriteCount * VertsPerSprite),
                    VertsPerSprite * sizeof(Vector2),
                    VertsPerSprite * sizeof(Vector2));
            }

            _spriteCount++;
        }

        protected override void Draw()
        {
            glViewport(0, 0, WindowWidth, WindowHeight);
            glClear(GL_COLOR_BUFFER_BIT);

            AddSprite(
                _glesTexture,
                new Vector2(WindowWidth / 2 - _glesTexture.Width / 2, WindowHeight / 2 - _glesTexture.Height / 2),
                new Vector2(_glesTexture.Width, _glesTexture.Height),
                0, 0, _glesTexture.Width, _glesTexture.Height,
                Vector4.One);

            for (int i = 0; i < _smileys.Length; i++)
            {
                AddSprite(
                    _smileyTexture,
                    _smileys[i].Position,
                    new Vector2(128, 128),
                    _smileys[i].SrcX,
                    _smileys[i].SrcY,
                    _smileys[i].SrcWidth,
                    _smileys[i].SrcHeight,
                    _smileys[i].Tint);
            }

            Flush();
        }

        private void Flush()
        {
            if (_spriteCount <= 0)
                return;

            float m11 = 2f / WindowWidth;
            float m22 = -2f / WindowHeight;

            float[] transform = new float[]
            {
                m11, 0.0f, 0.0f, 0.0f,
                0.0f, m22, 0.0f, 0.0f,
                0.0f, 0.0f, 1.0f, 0.0f,
                -1.0f, 1.0f, 0.0f, 1.0f,
            };

            glUseProgram(_program);

            fixed (void* vertPositionsPtr = _vertPositions)
            {
                glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, vertPositionsPtr);
            }

            fixed (void* vertColorsPtr = _vertColors)
            {
                glVertexAttribPointer(1, 4, GL_FLOAT, false, 0, vertColorsPtr);
            }

            fixed (void* vertTexCoordsPtr = _vertTexCoords)
            {
                glVertexAttribPointer(2, 2, GL_FLOAT, false, 0, vertTexCoordsPtr);
            }

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _textureHandle);

            fixed (float* transformPtr = transform)
            {
                glUniformMatrix4fv(_vertTransformLocation, 1, false, transformPtr);
            }

            glUniform1i(_fragTextureLocation, 0);

            glDrawArrays(GL_TRIANGLES, 0, _spriteCount * VertsPerSprite);

            _spriteCount = 0;
        }
    }
}
