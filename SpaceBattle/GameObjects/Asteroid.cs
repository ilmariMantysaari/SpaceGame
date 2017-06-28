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
    
    protected int diameter;
    protected bool destructable;
    protected int hp;

    public Asteroid(AsteroidType type)
    {
      switch (type)
      {
        case AsteroidType.Tiny:
          this.diameter = 10;
          break;
        case AsteroidType.Small:
          this.diameter = 50;
          break;
        case AsteroidType.Medium:
          this.diameter = 100;
          break;
        case AsteroidType.Big:
          this.diameter = 250;
          break;
        case AsteroidType.Large:
          this.diameter = 500;
          break;
        case AsteroidType.Huge:
          this.diameter = 1000;
          break;
        case AsteroidType.Immense:
          this.diameter = 5000;
          break;
        default:
          this.diameter = 100;
          break;
      }
      Collider = new CircleCollider(this, this.diameter / 2);
    }

    public Asteroid(int diameter)
    {
      this.diameter = diameter;
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
      //Vector2 origin = new Vector2(Texture.Width / 2f * Scale, Texture.Height / 2f * Scale);
      Rectangle dest = new Rectangle((int)this.Position.X, (int)this.Position.Y, this.diameter, this.diameter);
      batch.Draw(Texture, dest, Color.White);
      //batch.Draw(Texture, Position, null, Color.White, 0f, origin, 1f, SpriteEffects.None, 0f);
    }

    public override void Update()
    {
      //pyöritä
      //mahdollinen liike
    }

    public override void OnCollision(ICollidable collider)
    {

    }
  }
}
