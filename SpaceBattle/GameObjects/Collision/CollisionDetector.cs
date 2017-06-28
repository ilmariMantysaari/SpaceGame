using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Collision
{
  public class CollisionDetector
  {
    /*
     Detects collisions and calls the OnCollision method of collided objects
     */
    public static void DetectCollisions<T>(List<T> colliders) where T : ICollidable
    {
      //TODO: hyvä algoritmi kaikkien collisioneiden selvittämiseen
      if (colliders.Count < 2)
      {
        return;
      }

      //TODO: parempi algoritmi kaikkien collisioneiden selvittämiseen
      for (int i = 0; i < colliders.Count - 1; i++)
      {
        var element1 = colliders.ElementAt(i);
        for (int j = i + 1; j < colliders.Count; j++)
        {
          var element2 = colliders.ElementAt(j);
          if (element1.Collider.Collision(element2.Collider))
          {
            element1.OnCollision(element2);
            element2.OnCollision(element1);
          }
        }
      }
    }
  }
}
