using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace HadMonogame.Skripts
{
    internal class Draw1
    {
        private static GraphicsDeviceManager _graphics;
        private static SpriteFont _font;
        private static Texture2D _playerBody;
        private static Texture2D _playerHead;
        private static Texture2D _strike1;
        private static Texture2D _strike2;


        public static void Draw1Content(Game1 game1)
        {
            
            //_spriteBatch = new SpriteBatch(game1.GraphicsDevice);
            _font = game1.Content.Load<SpriteFont>("font/DFont");
            _playerBody = game1.Content.Load<Texture2D>("sprites/body");
            _playerHead = game1.Content.Load<Texture2D>("sprites/head");
            _strike1 = game1.Content.Load<Texture2D>("sprites/strike1");
            _strike2 = game1.Content.Load<Texture2D>("sprites/strike2");
        }

        public static void Draw1Main(SpriteBatch spriteBatch)
        {
            foreach (var item in Had.gs.List)
            {
                if (item == Had.gs.List[Had.gs.List.Count - 1])
                {
                    spriteBatch.Draw(
                    _playerHead,
                    new Rectangle(item.X, item.Y, Had.gs.Width, Had.gs.Height),
                    null,
                    Color.White,
                    Had.HeadRotation(),
                    Had.HeadRotationVector(),
                    SpriteEffects.None,
                    0f);
                }
                else
                { spriteBatch.Draw(_playerBody, new Rectangle(item.X, item.Y, Had.gs.Width, Had.gs.Height), Color.White); }
                spriteBatch.DrawString(_font, "Pocet strel v letu:" + Had.gs.ListOfMissiles.Count, new Vector2(1000, 10), Color.Red);
            }

            foreach (var item in Had.gs.ListOfMissiles)
            {
                spriteBatch.Draw(_strike1, new Rectangle(item.X, item.Y, 100, 100), null, Color.White, 4.73f, new Vector2(150, -125), SpriteEffects.None, 0f);
                //else if (count < 40) _spriteBatch.Draw(_strike2, new Rectangle(item.X, item.Y, 100, 100), Color.White);
                //else count = 0;
            }
        }




















    }
}
