﻿using System;
using System.Collections.Generic;
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
    public static void DetectCollisions(List<ICollidable> colliders)
    {
      //TODO: hyvä algoritmi kaikkien collisioneiden selvittämiseen

      //TODO: parempi algoritmi kaikkien collisioneiden selvittämiseen
      for (int i = 0; i < colliders.Count; i++)
      {
        var element1 = colliders.ElementAt(i);
        for (int j = i + 0; j < colliders.Count; j++)
        {
          var element2 = colliders.ElementAt(j);
          if (element1.Collider.Collision(element2))
          {
            element1.OnCollision(element2);
          }
        }
      }
    }
  }
}
