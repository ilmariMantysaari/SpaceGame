using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpaceBattle.GameObjects;
using SpaceBattle.GameObjects.Levels;
using System;

namespace SpaceBattle
{

  public class SpaceBattle : Microsoft.Xna.Framework.Game
  {
    protected GraphicsDeviceManager graphics;
    protected SpriteBatch spriteBatch;

    public Player player;
    public Level level;

    public static SpaceBattle GameInstance{ get; private set; }

    public SpaceBattle()
    {
      graphics = new GraphicsDeviceManager(this);
      Content.RootDirectory = "Content";

      //this last
      GameInstance = this;
    }

    /// <summary>
    /// Initialization
    /// </summary>
    protected override void Initialize()
    {
      player = new Player();
      level = new Level1(spriteBatch, player);
      base.Initialize();
    }
    
    protected override void LoadContent()
    {
      //TODO: lataa conffi tiedosto

      spriteBatch = new SpriteBatch(GraphicsDevice);
      Console.WriteLine(GraphicsDevice.Viewport.TitleSafeArea);
      //Vector2 playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
      player.LoadContent();
      level.LoadContent();
    }
    
    protected override void UnloadContent()
    {
    }

    public void ChangeLevel(int levelIndex)
    {
      //latausnäyttö
      //unload nyk level
      //load uus
      //uuden käynnistys
    }
    
    protected override void Update(GameTime gameTime)
    {
      if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
        Exit();

      // TODO: Add your update logic here

      base.Update(gameTime);
    }
    
    protected override void Draw(GameTime gameTime)
    {
      GraphicsDevice.Clear(Color.CornflowerBlue);
      spriteBatch.Begin(samplerState : SamplerState.PointClamp);

      // Draw the Player
      level.Draw(spriteBatch);

      spriteBatch.End();
      base.Draw(gameTime);
    }
  }
}
