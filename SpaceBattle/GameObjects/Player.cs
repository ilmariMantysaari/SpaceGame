using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceBattle.GameObjects
{
  public class Player : SceneItem
  {
    
    public bool Active;
    public int Health;
    public Weapon Weapon;
    public float Speed;

    protected Texture2D smallShip;

    public Player()
    {
      Active = true;
      Health = 100;
    }

    public override void LoadContent()
    {
      Texture = SpaceBattle.GameInstance.Content.Load<Texture2D>("Sprites\\ship");
    }

    public override void Draw(SpriteBatch batch)
    {
      batch.Draw(Texture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
    }

    public override void Update()
    {

    }

  }
}
