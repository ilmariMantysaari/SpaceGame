using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace SpaceBattle
{
  public class Camera
  {
    public float Zoom { get; set; }
    public Vector2 Position { get; set; }
    public Rectangle Bounds { get; set; }
    public Matrix Transform { get; protected set; }
    public Single Rotation { get; protected set; }
    public Vector2 Center { get; protected set; }

    public Camera(Viewport viewport)
    {
      Bounds = viewport.Bounds;
      Rotation = 0f;
      Zoom = 0.75f;
      Position = Vector2.Zero;
      Center = new Vector2(Bounds.Width / 2, Bounds.Height / 2);
    }

    public void Move(List<Direction> dir)
    {
      UpdateMatrix();

      Vector2 movement = Vector2.Zero;

      //TODO: Playerin nopeus ja kääntyvyys
      int moveSpeed = 10;
      float rotationSpeed = 0.04f;

      if (dir.Contains(Direction.Up))
      {
        movement.X = Transform.Up.X * moveSpeed;
        movement.Y = Transform.Up.Y * -moveSpeed;
      }
      if (dir.Contains(Direction.Down))
      {
        movement.X = Transform.Down.X * moveSpeed;
        movement.Y = Transform.Down.Y * -moveSpeed;
      }
      if (dir.Contains(Direction.Right))
      {
        this.Rotation -= rotationSpeed;
        this.Rotation %= (2 * (float)Math.PI);
      }
      if (dir.Contains(Direction.Left))
      {
        this.Rotation += rotationSpeed;
        this.Rotation %= (2 * (float)Math.PI);
      }

      Vector2 newPosition = Position + movement;
      Position = newPosition;
    }

    private void UpdateMatrix()
    {
      var origin = new Vector2(Bounds.Width / 2, Bounds.Height / 2);
      this.Transform = Matrix.CreateTranslation(new Vector3(-Position, 0.0f)) *
          //Matrix.CreateTranslation(new Vector3(-origin, 0.0f)) *
          Matrix.CreateRotationZ(Rotation) *
          /*Matrix.CreateScale(Zoom, Zoom, 1) **/ Matrix.CreateTranslation(new Vector3(origin, 0.0f));
    }
  }

  public enum Direction{
    Up, Down,Left,Right
  }
}


