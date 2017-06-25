using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Collision
{
  /*
   At the moment just a series of rectangles
   */
  public class PolygonCollider : Collider
  {
    public List<Rectangle> area;

    public PolygonCollider(List<Rectangle> area)
    {
      this.area = area;
    }

    public override bool Collision(ICollidable collider)
    {
      throw new NotImplementedException();
    }
  }
}
