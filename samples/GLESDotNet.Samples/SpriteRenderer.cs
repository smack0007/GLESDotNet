using System;
using System.Numerics;
using GLESDotNet.Samples;
using static GLESDotNet.GLES2;

namespace Sprites
{
    public class SpriteRenderer : IDisposable
    {
        private uint _program;
        private int _vertTransformLocation;
        private int _fragTextureLocation;
        private uint _textureHandle;

        private const int VertsPerSprite = 6;
        private const int MaxSpriteCount = 1024;

        private int _viewportWidth = 0;
        private int _viewportHeight = 0;
        private int _spriteCount = 0;
        private Vector3[] _vertPositions = new Vector3[MaxSpriteCount * VertsPerSprite];
        private Vector4[] _vertColors = new Vector4[MaxSpriteCount * VertsPerSprite];
        private Vector2[] _vertTexCoords = new Vector2[MaxSpriteCount * VertsPerSprite];

        public SpriteRenderer(int maxSpriteCount = 1024)
        {
            uint vertexShader = GLUtils.CompileShader(vertShader, GL_VERTEX_SHADER);
            uint fragmentShader = GLUtils.CompileShader(fragShader, GL_FRAGMENT_SHADER);

            _program = glCreateProgram();
            if (_program == 0)
                throw new InvalidOperationException("Failed to create program.");

            glAttachShader(_program, vertexShader);
            glAttachShader(_program, fragmentShader);

            glBindAttribLocation(_program, 0, "vertPosition");
            glBindAttribLocation(_program, 1, "vertColor");
            glBindAttribLocation(_program, 2, "vertTexCoord");
            GLUtils.LinkProgram(_program);

            _vertTransformLocation = glGetUniformLocation(_program, "vertTransform");
            _fragTextureLocation = glGetUniformLocation(_program, "fragTexture");
        }

        public void Dispose()
        {
        }

        public void Begin(int viewportWidth, int viewportHeight)
        {
            _viewportWidth = viewportWidth;
            _viewportHeight = viewportHeight;

            glEnable(GL_BLEND);
            glBlendFuncSeparate(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_ONE, GL_ZERO);

            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
            glEnableVertexAttribArray(2);
        }

        public void End()
        {
            Flush();
        }

        public void Draw(
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

            Array.Copy(spriteVertPositions, 0, _vertPositions, _spriteCount * VertsPerSprite, spriteVertPositions.Length);

            var spriteVertColors = new Vector4[]
            {
                tint,
                tint,
                tint,

                tint,
                tint,
                tint,
            };

            Array.Copy(spriteVertColors, 0, _vertColors, _spriteCount * VertsPerSprite, spriteVertColors.Length);

            var spriteVertTexCoords = new Vector2[]
            {
                new Vector2(srcX / (float)texture.Width, srcY / (float)texture.Height),
                new Vector2((srcX + srcWidth) / (float)texture.Width, srcY / (float)texture.Height),
                new Vector2(srcX / (float)texture.Width, (srcY + srcHeight) / (float)texture.Height),

                new Vector2((srcX + srcWidth) / (float)texture.Width, srcY / (float)texture.Height),
                new Vector2((srcX + srcWidth) / (float)texture.Width, (srcY + srcHeight) / (float)texture.Height),
                new Vector2(srcX / (float)texture.Width, (srcY + srcHeight) / (float)texture.Height),
            };

            Array.Copy(spriteVertTexCoords, 0, _vertTexCoords, _spriteCount * VertsPerSprite, spriteVertTexCoords.Length);

            _spriteCount++;
        }

        private void Flush()
        {
            if (_spriteCount <= 0)
                return;

            glUseProgram(_program);

            glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, _vertPositions);
            glVertexAttribPointer(1, 4, GL_FLOAT, false, 0, _vertColors);
            glVertexAttribPointer(2, 2, GL_FLOAT, false, 0, _vertTexCoords);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _textureHandle);

            float m11 = 2f / _viewportWidth;
            float m22 = -2f / _viewportHeight;

            float[] transform = new float[]
            {
                m11, 0.0f, 0.0f, 0.0f,
                0.0f, m22, 0.0f, 0.0f,
                0.0f, 0.0f, 1.0f, 0.0f,
                -1.0f, 1.0f, 0.0f, 1.0f,
            };

            glUniformMatrix4fv(_vertTransformLocation, 1, false, transform);

            glUniform1i(_fragTextureLocation, 0);

            glDrawArrays(GL_TRIANGLES, 0, _spriteCount * VertsPerSprite);

            _spriteCount = 0;
        }

        private const string vertShader =
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

        private const string fragShader =
@"precision mediump float;

varying vec4 fragColor;
varying vec2 fragTexCoord;

uniform sampler2D fragTexture;

void main()
{
    gl_FragColor = fragColor * texture2D(fragTexture, fragTexCoord);
}";
    }
}
