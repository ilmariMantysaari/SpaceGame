using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Collision
{
  /*
    Superclass to all different types of colliders
  */
  public abstract class Collider
  {

    public Collider()
    {
    }

    public abstract bool Collision(Collider collider);

    /*
    public Collider(List<Rectangle> rectangles)
    {
      this.Colliders = rectangles;
    }
    
    public virtual bool Collision(Collider collider)
    {
      foreach (var c in this.Colliders)
      {
        foreach (var d in collider.Colliders)
        {
          if (c.Intersects(d))
          {
            Debug.WriteLine("Collision");
            return true;
          }
        }
      }
      return false;
    }*/
  }
}
