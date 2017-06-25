using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Collision
{
  /*
   Specifies a collidable object
   Object has a collider and 
   */
  public interface ICollidable
  {

    Collider Collider { get; set; }

    /// <summary>
    /// Called when collision happens
    /// </summary>
    /// <param name="collider">the object this collidable colides with</param>
    void OnCollision(Collider collider);
  }
}
