using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceBattle
{

  public class SpaceBattle : Game
  {
    GraphicsDeviceManager graphics;
    SpriteBatch spriteBatch;
    Player player;
    
    public SpaceBattle()
    {
      graphics = new GraphicsDeviceManager(this);
      Content.RootDirectory = "Content";
    }

    /// <summary>
    /// Initialization
    /// </summary>
    protected override void Initialize()
    {
      player = new Player();
      base.Initialize();
    }

    /// <summary>
    /// Loads all content
    /// </summary>
    protected override void LoadContent()
    {
      spriteBatch = new SpriteBatch(GraphicsDevice);

      Vector2 playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
      player.Initialize(Content.Load<Texture2D>("Sprites\\player"), playerPosition);
    }

    /// <summary>
    /// Unloads content
    /// </summary>
    protected override void UnloadContent()
    {
    }

    /// <summary>
    /// Updates game
    /// </summary>
    /// <param name="gameTime">Provides a snapshot of timing values.</param>
    protected override void Update(GameTime gameTime)
    {
      if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
        Exit();

      // TODO: Add your update logic here

      base.Update(gameTime);
    }

    /// <summary>
    /// Draws game, no updating logic here
    /// </summary>
    /// <param name="gameTime">Snapshot of timing values.</param>
    protected override void Draw(GameTime gameTime)
    {
      GraphicsDevice.Clear(Color.CornflowerBlue);
      spriteBatch.Begin();
      
      // Draw the Player
      player.Draw(spriteBatch);
      
      spriteBatch.End();
      base.Draw(gameTime);
    }
  }
}
