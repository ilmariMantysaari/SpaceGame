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
    protected List<SceneItem> items;
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
      items = new List<SceneItem>();
    }

    public virtual void LoadContent()
    {
      foreach (var item in items)
      {
        item.LoadContent();
      }
    }
    
    public virtual void Update()
    {
      camera.Update();
      foreach (var item in items)
      {
        item.Update();
      }
    }

    //Draws eveything on screen
    public virtual void Draw(SpriteBatch batch)
    {
      //TODO: taustan piirto
      
      foreach (var item in items)
      {
        item.Draw(batch);
      }
    }

  }
}
