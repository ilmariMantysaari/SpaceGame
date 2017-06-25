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
    public Vector2 Center;
    
    public float Radius;
    
    public CircleCollider(Vector2 position, float radius)
    {
      Center = position;
      Radius = radius;
    }

    public override bool Collision(ICollidable collider)
    {
      //TODO: kauniimpi tapa hoitaa tämä
      //siis parempi tapa verrata colliderien alueita

      Debug.WriteLine(collider.GetType());

      //TODO: korjaa nämä
      if (collider.GetType() == typeof(RectangleCollider))
      {/*
        var rectangle = collider.Collider;
        Vector2 v = new Vector2(MathHelper.Clamp(Center.X, rectangle.Left, rectangle.Right),
                              MathHelper.Clamp(Center.Y, rectangle.Top, rectangle.Bottom));
        Vector2 direction = Center - v;
        float distanceSquared = direction.LengthSquared();

        return ((distanceSquared > 0) && (distanceSquared < Radius * Radius));
      */}
      else if(collider.GetType() == typeof(CircleCollider))
      {

      }else if (collider.GetType() == typeof(PointCollider))
      {

      }else
      {
        throw new NotImplementedException();
      }

      return true;
    }
  }
}
