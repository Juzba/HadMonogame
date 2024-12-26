using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;
using System.Timers;

namespace HadMonogame.Skripts.Enemy
{
    internal class DrawEnemy
    {

        private static SpriteFont _font;
        private static Texture2D _zombie1;
        private static Texture2D _zombie2;
        private static Texture2D _zombie3;
        private static int _count;
        private Stopwatch _stopwatch = new();
        private bool zombie1;
        private bool zombie2;



        public void DrawEnemyContent(Game1 game1)
        {
            _font = game1.Content.Load<SpriteFont>("font/DFont");
            _zombie1 = game1.Content.Load<Texture2D>("zombie/ZombieCube1");
            _zombie2 = game1.Content.Load<Texture2D>("zombie/ZombieCube10");
            _zombie3 = game1.Content.Load<Texture2D>("zombie/ZombieCube5");

        }


        private Texture2D moveGrafic(Texture2D texture, Texture2D texture2, Texture2D texture3)
        {
            if (System.Random.Shared.Next(100) > 98 && !_stopwatch.IsRunning) { _stopwatch.Start(); zombie1 = true; }
            if (System.Random.Shared.Next(100) > 98 && !_stopwatch.IsRunning) { _stopwatch.Start(); zombie2 = true; }
            if (_stopwatch.Elapsed.TotalSeconds > 1)
            { _stopwatch.Stop(); _stopwatch.Reset(); zombie1 = false; zombie2 = false; }

            if (zombie1) { return texture2; }
            else if (zombie2) { return texture3; }
            else return texture;
        }


        public void DrawEnemyMain(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice, Settings settings)
        {
            foreach (var item in settings.EnemyList)
            {
                spriteBatch.Draw(moveGrafic(_zombie1, _zombie2, _zombie3), new Rectangle(item.X, item.Y, 130, 130), Color.White);
            }



            if (_count > 19) _count = 0; else _count++;
        }


        private Texture2D AnimationTime(Texture2D texture1, Texture2D texture2)
        {
            if (_count < 10) { return texture1; }
            else { return texture2; }
        }





































































    }
}
