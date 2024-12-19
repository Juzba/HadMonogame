using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using System.Threading;

namespace HadMonogame.Skripts
{
    public class Game1 : Game
    {
        static GameSettings gs = new();
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _playerBody;
        private Texture2D _playerHead;


        public Game1()
        {

            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = 1280; // Šířka
            _graphics.PreferredBackBufferHeight = 720; // Výška
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _playerBody = Content.Load<Texture2D>("sprites/body");
            _playerHead = Content.Load<Texture2D>("sprites/head");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            Main.IfChangeState((float)gameTime.TotalGameTime.TotalSeconds, this);
            // TODO: Add your update logic here
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            foreach (var item in Main.List)
            {
                if (item == Main.List[Main.List.Count - 1])
                { _spriteBatch.Draw(_playerHead, new Rectangle(item.X, item.Y, gs.Width, gs.Height), Color.White); }
                else
                { _spriteBatch.Draw(_playerBody, new Rectangle(item.X, item.Y, gs.Width, gs.Height), Color.White); }
            }

            _spriteBatch.End();





            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
