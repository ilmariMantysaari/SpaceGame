using System;
using Microsoft.Xna.Framework;

namespace SpaceBattle.GameObjects.Collision
{
  public abstract class ColliderArea
  {/*
    public abstract bool Intersect(BoxCollider rec);
    public abstract bool Intersect(CircleCollider circle);
    public abstract bool Intersect(PointCollider point);*/

    //TODO: Refaktoroi collider luokat paremmiksi

    public abstract bool Intersect(ColliderArea collider);
  }
}
