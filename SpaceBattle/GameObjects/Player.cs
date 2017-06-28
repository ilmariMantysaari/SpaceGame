using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using SpaceBattle.GameObjects.Collision;
using System.Diagnostics;

namespace SpaceBattle.GameObjects
{
  public class Player : MapObject, ICollidable
  {
    
    public bool Active;
    public int Health;
    public Weapon Weapon;
    public float Speed;
    protected Texture2D exhaust;
    public Vector2 DrawPosition;

    protected Texture2D smallShip;
    
    public Player()
    {
      Active = true;
      Health = 100;
      //TODO: Scalen avulla muiden mittojen laskeminen
      Scale = 0.75f;
    }

    public override void LoadContent()
    {
      Texture = SpaceBattle.GameInstance.Content.Load<Texture2D>("Sprites\\ship");
      exhaust = SpaceBattle.GameInstance.Content.Load<Texture2D>("Sprites\\exhaust");
      Collider = new CircleCollider(this, (int)(Texture.Width /2 * Scale));
    }
    
    public override void Draw(SpriteBatch batch)
    {
      batch.Draw(Texture, DrawPosition, null, Color.White, 0f, Origin(), Scale, SpriteEffects.None, 0f);
    }

    public override void Update()
    {
      Debug.WriteLine(this.Position);
    }

    public override void OnCollision(ICollidable collider)
    {
      Debug.WriteLine("Player collision");
    }
  }
}
