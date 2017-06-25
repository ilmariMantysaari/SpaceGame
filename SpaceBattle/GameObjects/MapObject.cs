using SpaceBattle.GameObjects.Collision;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects
{
  public abstract class MapObject : SceneItem, ICollidable
  {
    public Collider Collider { get; set; }

    public abstract void OnCollision(ICollidable collider);
  }
}
