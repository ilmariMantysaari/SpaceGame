using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceBattle.GameObjects
{
  public class Enemy : SceneItem
  {
    public bool Active;
    public int Health;
    public AI Intelligence;
    
    public Enemy()
    {
      Active = true;
      Health = 100;
    }

    public override void LoadContent()
    {
      throw new NotImplementedException();
    }

    public override void Update()
    {
    }
  }
}
