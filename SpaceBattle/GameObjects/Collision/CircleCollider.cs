using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Collision
{
  public class CircleCollider : Collider
  {
    public float Radius;
    public CircleCollider(MapObject parent, float radius): base(parent)
    {
      Radius = radius;
    }
    
    public override bool IntersectBox(BoxCollider rec)
    {/*
      var area = new Rectangle((int)rec.Parent.Position.X, (int)rec.Parent.Position.Y, rec.Width, rec.Height);
      Vector2 v = new Vector2(MathHelper.Clamp(Parent.Origin().X, area.Left, area.Right),
                              MathHelper.Clamp(Parent.Origin().Y, area.Top, area.Bottom));
      Vector2 direction = this.Parent.Origin() - v;
      float squared = direction.LengthSquared();
      */
     // return ((squared > 0) && (squared < Radius * Radius));
      return false;
    }

    public override bool IntersectCircle(CircleCollider circle)
    {
      var rad = this.Radius + circle.Radius;
      var pos = this.Parent.Origin() + this.Parent.Position;
      var distX = pos.X - pos.X;
      var distY = pos.Y - pos.Y;
      
      return distX * distX + distY * distY <= rad * rad;
    }

    public override bool IntersectPoint(PointCollider point)
    {
      throw new NotImplementedException();
    }
  }
}
