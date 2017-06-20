using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects
{
  /*
   * Superclass for all items drawn on screen
   */
  public abstract class SceneItem
  {
    protected Texture2D Texture;
    protected bool Collidable;
    public Vector2 Position;

    public virtual bool Collision(SceneItem item)
    {
      if (!Collidable)
      {
        return false;
      }
      
      //TODO collision toteutus
      return false;
    }

    public virtual void Draw(SpriteBatch batch)
    {
      batch.Draw(Texture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
    }


    //For loading content of sceneitem, such as textures and sounds etc
    public abstract void LoadContent();

    //updates the state of the sceneitem
    public abstract void Update();
  }
}
