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
    
  */
  public abstract class Collider
  {
    //position of the entire collider
    public MapObject Parent;
    
    public abstract bool IntersectBox(BoxCollider rec);
    public abstract bool IntersectCircle(CircleCollider circle);
    public abstract bool IntersectPoint(PointCollider point);

    public Collider(MapObject parent)
    {
      this.Parent = parent;
    }
    public virtual bool Collision(Collider collider)
    {
      if (collider.GetType() == typeof(BoxCollider))
      {
        return IntersectBox((BoxCollider)collider);
      }
      else if (collider.GetType() == typeof(CircleCollider))
      {
        return IntersectCircle((CircleCollider)collider);
      }
      else if (collider.GetType() == typeof(PointCollider))
      {
        throw new NotImplementedException();
      }
      else
      {
        throw new NotImplementedException();
      }
    }
      /*
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
      }*/
    }
}
