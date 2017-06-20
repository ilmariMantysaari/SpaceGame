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

    public Level(SpriteBatch batch)
    {
      //TODO level kohtainen contentmanager
      this.batch = batch;
      items = new List<SceneItem>();
    }

    public virtual void LoadContent()
    {
      foreach (var item in items)
      {
        item.LoadContent();
      }
    }
    
    /// <summary>
    /// Updates all items in level
    /// </summary>
    public virtual void Update()
    {
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
