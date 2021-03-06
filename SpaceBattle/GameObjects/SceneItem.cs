﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SpaceBattle.GameObjects.Collision;
using System;
namespace SpaceBattle.GameObjects
{
  /*
   * Superclass for all items drawn on screen
   */
  public abstract class SceneItem
  {
    protected Texture2D Texture;
    public Vector2 Position;
    public float Scale;

    public virtual void Draw(SpriteBatch batch)
    {
      //Vector2 origin = new Vector2(Texture.Width / 2f * Scale, Texture.Height / 2f * Scale);
      batch.Draw(Texture, Position, null, Color.White, 0f, Origin(), Scale, SpriteEffects.None, 0f);
    }

    //For loading content of sceneitem, such as textures and sounds etc
    public abstract void LoadContent();

    //updates the state of the sceneitem
    public abstract void Update();

    public Vector2 Origin()
    {
      return new Vector2(Texture.Width / 2f * Scale, Texture.Height / 2f * Scale);
    }

  }
}
