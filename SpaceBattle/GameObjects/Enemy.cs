﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceBattle.GameObjects
{
  public class Enemy
  {
    public Texture2D Texture;
    public Vector2 Position;
    public bool Active;
    public int Health;
    
    public void Initialize(Texture2D texture, Vector2 position)
    {
      Texture = texture;
      Position = position;
      Active = true;
      Health = 100;
    }

    public void Update()
    {
    }

    public void Draw(SpriteBatch spriteBatch)
    {
      spriteBatch.Draw(Texture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
    }
  }
}
