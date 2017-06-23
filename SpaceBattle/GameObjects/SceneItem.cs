using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SpaceBattle.GameObjects.Collision;
using System;
namespace SpaceBattle.GameObjects
{
  /*
   * Superclass for all items drawn on screen
   */
  public abstract class SceneItem
  {
    protected Texture2D Texture;
    public bool Collidable;
    public Collider Collider;
    public Vector2 Position;
    public Vector2 Direction;
    public float Scale;

    public virtual void Draw(SpriteBatch batch)
    {
      Vector2 origin = new Vector2(Texture.Width / 2f * Scale, Texture.Height / 2f * Scale);
      batch.Draw(Texture, Position, null, Color.White, 0f, origin, Scale, SpriteEffects.None, 0f);
    }

    //For loading content of sceneitem, such as textures and sounds etc
    public abstract void LoadContent();

    //updates the state of the sceneitem
    public abstract void Update();

    public virtual bool Collision(SceneItem item)
    {
      if (!Collidable)
      {
        return false;
      }

      return this.Collider.Collision(item.Collider);
    }
  }
}
