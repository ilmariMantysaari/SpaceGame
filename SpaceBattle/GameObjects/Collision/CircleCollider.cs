using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Collision
{
  public class CircleCollider : ColliderArea
  {
    public Vector2 Center;

    public float Radius;

    public CircleCollider(Vector2 position, float radius)
    {
      Center = position;
      Radius = radius;
    }

    public override bool Intersect(ColliderArea collider)
    {
      if(collider.GetType() == typeof(BoxCollider))
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
    
    private bool IntersectBox(BoxCollider rec)
    {
      //Debug.WriteLine("Circle -> Box");
      var area = rec.Rectangle;
      Vector2 v = new Vector2(MathHelper.Clamp(Center.X, area.Left, area.Right),
                            MathHelper.Clamp(Center.Y, area.Top, area.Bottom));
      Vector2 direction = Center - v;
      float squared = direction.LengthSquared();

      return ((squared > 0) && (squared < Radius * Radius));
    }

    private bool IntersectCircle(CircleCollider circle)
    {
      //Debug.WriteLine("Circle -> Circle");
      var rad = this.Radius + circle.Radius;
      var distX = this.Center.X - circle.Center.X;
      var distY = this.Center.Y - circle.Center.Y;
      Debug.WriteLine(this.Radius + ",  " + circle.Radius);

      Debug.WriteLine(distX + ", " + distY + ", " + rad);
      return distX * distX + distY * distY <= rad * rad;
    }

    private bool IntersectPoint(PointCollider point)
    {
      throw new NotImplementedException();
    }
  }
}
