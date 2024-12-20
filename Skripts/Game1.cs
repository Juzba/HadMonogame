using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Threading;


namespace HadMonogame.Skripts;

public class Game1 : Game
{
    //static GameSettings gs = new();
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private SpriteFont _font;
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
        _font = Content.Load<SpriteFont>("font/DFont");
        _playerBody = Content.Load<Texture2D>("sprites/body");
        _playerHead = Content.Load<Texture2D>("sprites/head");

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        Had.IfChangeState((float)gameTime.TotalGameTime.TotalSeconds, this);
        // TODO: Add your update logic here
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();

        
        foreach (var item in Had.gs.List)
        {
            if (item == Had.gs.List[Had.gs.List.Count - 1])
            {
                _spriteBatch.Draw(
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
            { _spriteBatch.Draw(_playerBody, new Rectangle(item.X, item.Y, Had.gs.Width, Had.gs.Height), Color.White); }
            _spriteBatch.DrawString(_font,"Vector: ", new Vector2(1000,10),Color.Red);

        }
        _spriteBatch.End();





        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
