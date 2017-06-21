using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace SpaceBattle
{
  public class Camera
  {
    public float Zoom { get; set; }
    public Vector2 Position { get; set; }
    public Matrix Transform { get; protected set; }
    public Single Rotation { get; protected set; }

    //private float currentMouseWheelValue, previousMouseWheelValue, zoom, previousZoom;

    public Camera(Viewport viewport)
    {
      Rotation = 0f;
      Zoom = 0.75f;
      Position = Vector2.Zero;
    }

    public void Update()
    {
      UpdateMatrix();

      Vector2 movement = Vector2.Zero;
      int moveSpeed = 15;

      if (Keyboard.GetState().IsKeyDown(Keys.W))
      {
        movement.Y = -moveSpeed;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.S))
      {
        movement.Y = moveSpeed;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.A))
      {
        movement.X = -moveSpeed;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.D))
      {
        movement.X = moveSpeed;
      }
      if (Keyboard.GetState().IsKeyDown(Keys.E))
      {
        this.Rotation += 0.002f;
      }

      Vector2 newPosition = Position + movement;
      Position = newPosition;
    }
    
    private void UpdateMatrix()
    {
      this.Transform = Matrix.CreateTranslation(new Vector3(-Position, 0.0f)) *
       //Matrix.CreateTranslation(new Vector3(-Origin, 0.0f)) *
       Matrix.CreateRotationZ(Rotation);
       //Matrix.CreateScale(Zoom, Zoom, 1) * Matrix.CreateTranslation(new Vector3(Origin, 0.0f));
    }
  }
}


