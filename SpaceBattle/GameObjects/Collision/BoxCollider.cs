using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Collision
{
  public class BoxCollider : ColliderArea
  {
    public Rectangle Rectangle;

    public BoxCollider(int x, int y, int width, int height)
    {
      this.Rectangle = new Rectangle(x,y,width,height);
    }

    private bool IntersectBox(BoxCollider rec)
    {
      return this.Rectangle.Intersects(rec.Rectangle);
    }

    private bool IntersectCircle(CircleCollider circle)
    {
      Vector2 v = new Vector2(MathHelper.Clamp(circle.Center.X, Rectangle.Left, Rectangle.Right),
                            MathHelper.Clamp(circle.Center.Y, Rectangle.Top, Rectangle.Bottom));
      Vector2 direction = circle.Center - v;
      float squared = direction.LengthSquared();

      return ((squared > 0) && (squared < circle.Radius * circle.Radius));
    }
    
    public override bool Intersect(ColliderArea collider)
    {
      if (collider.GetType() == typeof(BoxCollider))
      {
        return false;//IntersectBox((BoxCollider)collider);
      }
      else if (collider.GetType() == typeof(CircleCollider))
      {
        return false; // IntersectCircle((CircleCollider)collider);
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
  }
}
