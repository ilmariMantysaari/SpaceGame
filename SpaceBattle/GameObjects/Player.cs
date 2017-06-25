using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using SpaceBattle.GameObjects.Collision;

namespace SpaceBattle.GameObjects
{
  public class Player : SceneItem, ICollidable
  {
    
    public bool Active;
    public int Health;
    public Weapon Weapon;
    public float Speed;
    protected Texture2D exhaust;

    protected Texture2D smallShip;

    public Collider Collider{ get; set; }

    public Player()
    {
      Active = true;
      Health = 100;
      Scale = 0.75f;
      var collisionBoxes = new List<Rectangle>();
      collisionBoxes.Add(new Rectangle());
      Collider = new RectangleCollider();
    }

    public override void LoadContent()
    {
      Texture = SpaceBattle.GameInstance.Content.Load<Texture2D>("Sprites\\ship");
      exhaust = SpaceBattle.GameInstance.Content.Load<Texture2D>("Sprites\\exhaust");
    }
    
    /*
    public override void Draw(SpriteBatch batch)
    {
      batch.Draw(Texture, Position, null, Color.White, 0f, origin, 1f, SpriteEffects.None, 0f);
    }*/

    public override void Update()
    {

    }

    public void OnCollision()
    {
      
    }
  }
}
