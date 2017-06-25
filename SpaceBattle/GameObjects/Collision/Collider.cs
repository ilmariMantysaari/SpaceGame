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
  public class Collider
  {

    //TODO: vain yhden muodon collider

    public List<ColliderArea> Area;

    public Collider(List<ColliderArea> colliders)
    {
      this.Area = colliders;
    }

    public Collider(ColliderArea collider)
    {
      this.Area = new List<ColliderArea>()
        {
          collider
        };
    }

    public virtual bool Collision(Collider collider)
    {
      foreach (var shape in Area)
      {
        foreach (var shape2 in collider.Area)
        {
          if (shape.Intersect(shape2))
          {
            return true;
          }
        }
      }
      return false;
    }
  }
}
