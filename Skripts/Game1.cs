using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace HadMonogame.Skripts;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

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
        Draw1.Draw1Content(this);
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
    }


    protected override void Update(GameTime gameTime)
    {
        GameUpdate.GameUpdate1(((float)gameTime.TotalGameTime.TotalSeconds), this);

        // TODO: Add your update logic here
        base.Update(gameTime);
    }


    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);



        _spriteBatch.Begin();

        Draw1.Draw1Main(_spriteBatch, GraphicsDevice);

        _spriteBatch.End();


        // TODO: Add your drawing code here
        base.Draw(gameTime);
    }
}
