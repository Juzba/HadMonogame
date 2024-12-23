using HadMonogame.Skripts.others;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadMonogame.Skripts.Enemy
{
    internal class DrawEnemy
    {

        //private static GraphicsDeviceManager _graphics;
        private static SpriteFont _font;
        private static Texture2D _Enemy1;
        private static int _count;



        public static void Draw1Content(Game1 game1)
        {
            _font = game1.Content.Load<SpriteFont>("font/DFont");
            _Enemy1 = game1.Content.Load<Texture2D>("sprites/ZombieCube1");
   
        }

        public static void Draw1Main(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
        {




            if (_count > 19) _count = 0; else _count++;
        }

        private static Texture2D HeadAnimation(Texture2D texture1, Texture2D texture2, Texture2D texture3)
        {
            if (Missile.ChangeFace) { _count = -25; Missile.ChangeFace = false; }
            else if (_count < 0) return texture3;


            if (_count < 10) { return texture1; }
            else { return texture2; }
        }

        private static Texture2D AnimationTime(Texture2D texture1, Texture2D texture2)
        {
            if (_count < 10) { return texture1; }
            else { return texture2; }
        }





































































    }
}
