using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects
{
  /*
    Handles the inputs 
  */
  public class InputHandler
  {

    public void Update(Camera camera, Level level)
    {
      var direction = new List<Direction>();
      if (Keyboard.GetState().IsKeyDown(Keys.W))
      {
        direction.Add(Direction.Up);
      }
      if (Keyboard.GetState().IsKeyDown(Keys.S))
      {
        direction.Add(Direction.Down);
      }
      if (Keyboard.GetState().IsKeyDown(Keys.D))
      {
        direction.Add(Direction.Right);
      }
      if (Keyboard.GetState().IsKeyDown(Keys.A))
      {
        direction.Add(Direction.Left);
      }
      camera.Move(direction);

    }
  }
}
