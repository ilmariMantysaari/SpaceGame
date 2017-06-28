using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Levels
{
  public class Level1 : Level
  {

    public Level1(SpriteBatch batch, Player player) : base(batch, player)
    {
      //set player coordinates
      //create items on map

      //TODO CONtent manager kuntoon ja joka levelille oma content manager
      //this.content = new Microsoft.Xna.Framework.Content.ContentManager();
      
      SetupContent();
      LoadContent();
    }

    public override void Update()
    {
      base.Update();
    }

    private void SetupContent()
    {
      var asteroid = new Asteroid(AsteroidType.Small)
        {
          Position = Vector2.Zero,
          Scale = 0.5f
        };
      var asteroid2 = new Asteroid(AsteroidType.Big)
        {
          Position = new Vector2(200, 200)
        };
      var asteroid3 = new Asteroid(AsteroidType.Big)
        {
          Position = new Vector2(300, -200)
        };
      /*
      for (int i = 0; i < 100; i++)
      {
        AddItem(
          new Asteroid(AsteroidType.Small)
          {
            Position = new Vector2(400 + i * 100, 400 + i * 100)
          }
          );
      }

      for (int i = 0; i < 100; i++)
      {
        AddItem(
          new Asteroid(AsteroidType.Small)
          {
            Position = new Vector2(400 + i * 100, i * -100)
          }
          );
      }

      for (int i = 0; i < 100; i++)
      {
        AddItem(
          new Asteroid(AsteroidType.Small)
          {
            Position = new Vector2(400 + i * 100, 400 + i * 100)
          }
          );
      }*/

      //AddItem(asteroid);
      //AddItem(asteroid2);
      AddItem(asteroid3);
    }
  }
}
