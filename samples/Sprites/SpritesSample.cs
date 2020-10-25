using System;
using static GLESDotNet.GLES2;
using GLESDotNet.Samples;
using ImageDotNet;
using System.Numerics;

namespace Sprites
{
    public struct SmileyData
    {
        public int SrcX { get; set; }
        
        public int SrcY { get; set; }

        public int SrcWidth { get; set; }

        public int SrcHeight { get; set; }

        public Vector2 Position { get; set; }

        public Vector4 Tint { get; set; }
    }

    public class SpritesSample : GLApplication
    {
        private SpriteRenderer _spriteRenderer;

        private TextureData _glesTexture;
        private TextureData _smileyTexture;

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
            _spriteRenderer = new SpriteRenderer();
        }

        protected override void Initialize()
        {                       
            _glesTexture = GLUtils.LoadTexture("opengles.png");
            _smileyTexture = GLUtils.LoadTexture("smiley.png");
;
            glClearColor(0.0f, 0.0f, 0.0f, 1.0f);

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

        protected override void Draw()
        {
            glViewport(0, 0, WindowWidth, WindowHeight);
            glClear(GL_COLOR_BUFFER_BIT);

            _spriteRenderer.Begin(WindowWidth, WindowHeight);

            _spriteRenderer.Draw(
                _glesTexture,
                new Vector2(WindowWidth / 2 - _glesTexture.Width / 2, WindowHeight / 2 - _glesTexture.Height / 2),
                new Vector2(_glesTexture.Width, _glesTexture.Height),
                0, 0, _glesTexture.Width, _glesTexture.Height,
                Vector4.One);

            for (int i = 0; i < _smileys.Length; i++)
            {
                _spriteRenderer.Draw(
                    _smileyTexture,
                    _smileys[i].Position,
                    new Vector2(128, 128),
                    _smileys[i].SrcX,
                    _smileys[i].SrcY,
                    _smileys[i].SrcWidth,
                    _smileys[i].SrcHeight,
                    _smileys[i].Tint);
            }

            _spriteRenderer.End();
        }
    }
}
