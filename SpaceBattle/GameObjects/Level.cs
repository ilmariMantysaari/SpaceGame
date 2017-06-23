using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects
{
  public abstract class Level
  {
    //contains all items in level
    protected List<SceneItem> mapObjects;
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
      mapObjects = new List<SceneItem>();
    }

    public virtual void LoadContent()
    {
      foreach (var item in mapObjects)
      {
        item.LoadContent();
      }
    }
    
    public virtual void Update()
    {
      camera.Update();
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
