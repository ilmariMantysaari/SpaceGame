using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Collision
{
  public class RectangleCollider : Collider
  {

    public Rectangle area;

    public RectangleCollider()
    {

    }

    public RectangleCollider(int x, int y, int width, int height)
    {
      this.area = new Rectangle(x, y, width, height);
    }

    public override bool Collision(ICollidable collider)
    {
      throw new NotImplementedException();
    }
  }
}
