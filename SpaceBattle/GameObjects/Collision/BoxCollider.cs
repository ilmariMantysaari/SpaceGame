using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Collision
{
  public class BoxCollider : Collider
  {
    public Rectangle Rectangle;
    public int Width;
    public int Height;

    public BoxCollider(MapObject parent, int width, int height): base(parent)
    {
      this.Width = width;
      this.Height = height;
      //this.Rectangle = new Rectangle(x,y,width,height);
    }

    public override bool IntersectBox(BoxCollider rec)
    {
      var rec1 = new Rectangle((int)rec.Parent.Position.X, (int)rec.Parent.Position.Y, rec.Width, rec.Height);
      var rec2 = new Rectangle((int)this.Parent.Position.X, (int)this.Parent.Position.Y, this.Width, this.Height);
      return rec1.Intersects(rec2);
    }

    public override bool IntersectCircle(CircleCollider circle)
    {
      var area = new Rectangle((int)this.Parent.Position.X, (int)this.Parent.Position.Y, this.Width, this.Height);
      Vector2 v = new Vector2(MathHelper.Clamp(circle.Parent.Position.X, area.Left, area.Right),
                            MathHelper.Clamp(circle.Parent.Position.Y, area.Top, area.Bottom));
      Vector2 direction = circle.Parent.Position - v;
      float squared = direction.LengthSquared();

      return ((squared > 0) && (squared < circle.Radius * circle.Radius));
    }

    public override bool IntersectPoint(PointCollider point)
    {
      throw new NotImplementedException();
    }
  }
}
