using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SpaceBattle.GameObjects.Collision;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects
{
  public abstract class Level
  {
    //contains all collidable and interactable items in level
    protected List<MapObject> mapObjects;
    //contains items that are just for decoration
    //TODO: class for decorations
    //protected List<Decoration> decorations;

    //TODO: HUD
    //protected HUD hud;

    protected ContentManager content;
    protected SpriteBatch batch;
    protected Player player;

    protected Texture2D background;
    public Camera camera;

    public Level(SpriteBatch batch)
    {
      //TODO level kohtainen contentmanager
      this.batch = batch;
      this.camera = new Camera(SpaceBattle.GameInstance.GraphicsDevice.Viewport);
      mapObjects = new List<MapObject>();
    }

    public virtual void LoadContent()
    {
      foreach (var item in mapObjects)
      {
        item.LoadContent();
      }
      /*
      foreach (var decor in decorations)
      {
        //decorations.LoadContent();
      }*/
    }
    
    public virtual void Update()
    {
      camera.Update();
      CollisionDetector.DetectCollisions(mapObjects);

      Debug.WriteLine("Clear");
      foreach (var item in mapObjects)
      {
        item.Update();
      }
    }

    //Draws eveything on screen
    public virtual void Draw(SpriteBatch batch)
    {
      //TODO: taustan piirto

      //Draw objects that are positioned relative to screen
      batch.Begin(samplerState: SamplerState.PointClamp);

        player.Draw(batch);
        //Draw hud

      batch.End();

      //Draw objects relative to map
      batch.Begin(samplerState: SamplerState.PointClamp, transformMatrix: camera.Transform);
      foreach (var item in mapObjects)
      {
        item.Draw(batch);
      }
      batch.End();
    }

  }
}
