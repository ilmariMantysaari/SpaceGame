using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using SpaceBattle.GameObjects.Collision;
using System.Diagnostics;

namespace SpaceBattle.GameObjects.Levels
{
  //TODO: parempi tapa määrittää koko
  public enum AsteroidType
  {
    Tiny, Small, Medium, Big, Large, Huge, Immense
  }

  public class Asteroid : MapObject
  {
    //TODO: satunnaisen tekstuurin lataus
    //TODO: pyörimisliike

    //textures for different types of asteroids
    protected static Texture2D asteroidTexture;
    protected static Texture2D asteroidTexture2;
    protected static Texture2D asteroidTexture3;
    
    protected int radius;
    protected bool destructable;
    protected int hp;

    public Asteroid(AsteroidType type)
    {
      Collider = new Collider(new CircleCollider(Position, radius));

      switch (type)
      {
        case AsteroidType.Tiny:
          this.radius = 10;
          break;
        case AsteroidType.Small:
          this.radius = 50;
          break;
        case AsteroidType.Medium:
          this.radius = 100;
          break;
        case AsteroidType.Big:
          this.radius = 250;
          break;
        case AsteroidType.Large:
          this.radius = 500;
          break;
        case AsteroidType.Huge:
          this.radius = 1000;
          break;
        case AsteroidType.Immense:
          this.radius = 5000;
          break;
        default:
          this.radius = 100;
          break;
      }
    }

    public Asteroid(int radius)
    {
      this.radius = radius;
    }

    public override void LoadContent()
    {
      //TODO: satunnainen tekstuuri

      //Random r = new Random();
      //int type = r.Next(0, 3);
      
      asteroidTexture = SpaceBattle.GameInstance.Content.Load<Texture2D>("Sprites\\asteroid");
      asteroidTexture2 = SpaceBattle.GameInstance.Content.Load<Texture2D>("Sprites\\asteroid2");
      asteroidTexture3= SpaceBattle.GameInstance.Content.Load<Texture2D>("Sprites\\asteroid3");
      this.Texture = asteroidTexture3;
    }

    public override void Draw(SpriteBatch batch)
    {
      Rectangle dest = new Rectangle((int)this.Position.X, (int)this.Position.Y, this.radius, this.radius);
      batch.Draw(Texture, dest, Color.White);
    }

    public override void Update()
    {
      //pyöritä
      //mahdollinen liike
    }

    public override void OnCollision(ICollidable collider)
    {
      Debug.WriteLine("Asteroid collision");
    }
  }
}
