using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Collision
{

  public class PointCollider : Collider
  {
    public PointCollider(MapObject parent) : base(parent)
    {
    }
    
    public override bool IntersectBox(BoxCollider rec)
    {
      throw new NotImplementedException();
    }

    public override bool IntersectCircle(CircleCollider circle)
    {
      throw new NotImplementedException();
    }

    public override bool IntersectPoint(PointCollider point)
    {
      throw new NotImplementedException();
    }
  }
}
