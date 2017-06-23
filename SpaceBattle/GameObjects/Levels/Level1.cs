using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Levels
{
  public class Level1 : Level
  {

    public Level1(SpriteBatch batch, Player player) : base(batch)
    {
      //set player coordinates
      //create items on map

      //TODO CONtent manager kuntoon ja joka levelille oma content manager
      //this.content = new Microsoft.Xna.Framework.Content.ContentManager();

      this.player = player;
      this.player.Position = this.camera.Center;
      SetupContent();
      LoadContent();
    }

    public override void Update()
    {
      base.Update();
    }

    private void SetupContent()
    {
      var asteroid = new Asteroid(AsteroidType.Small);
      asteroid.Position = Vector2.Zero;
      asteroid.Scale = 0.5f;

      var asteroid2 = new Asteroid(AsteroidType.Big);
      asteroid2.Position = new Vector2(200, 200);

      var asteroid3 = new Asteroid(AsteroidType.Huge);
      asteroid3.Position = new Vector2(300, 200);

      this.mapObjects.Add(asteroid);
      this.mapObjects.Add(asteroid2);
      this.mapObjects.Add(asteroid3);
    }
  }
}
