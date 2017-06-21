using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Levels
{
  //TODO: parempi tapa määrittää koko
  public enum AsteroidType
  {
    Tiny, Small, Medium, Big, Large, Huge, Immense
  }

  public class Asteroid : SceneItem
  {
    //TODO: satunnaisen tekstuurin lataus
    //TODO: pyörimisliike

    //textures for different types of asteroids
    protected static Texture2D asteroidTexture;
    protected static Texture2D asteroidTexture2;
    protected static Texture2D asteroidTexture3;
    
    protected int width;
    protected int height;
    protected bool destructable;
    protected int hp;

    public Asteroid(AsteroidType type)
    {
      switch (type)
      {
        case AsteroidType.Tiny:
          this.width = this.height = 10;
          break;
        case AsteroidType.Small:
          this.width = this.height = 50;
          break;
        case AsteroidType.Medium:
          this.width = this.height = 100;
          break;
        case AsteroidType.Big:
          this.width = this.height = 250;
          break;
        case AsteroidType.Large:
          this.width = this.height = 500;
          break;
        case AsteroidType.Huge:
          this.width = this.height = 1000;
          break;
        case AsteroidType.Immense:
          this.width = this.height = 5000;
          break;
        default:
          this.width = this.height = 100;
          break;
      }
    }

    public Asteroid(int width, int height)
    {
      this.width = width;
      this.height = height;
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
      Rectangle dest = new Rectangle((int)this.Position.X, (int)this.Position.Y, this.width, this.height);
      batch.Draw(Texture, dest, Color.White);
    }

    public override void Update()
    {
      //pyöritä
      //mahdollinen liike
    }
  }
}
