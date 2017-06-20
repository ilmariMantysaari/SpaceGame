using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceBattle.GameObjects
{
  public class Player : SceneItem
  {
    
    public bool Active;
    public int Health;

    protected Texture2D smallShip;

    public Player()
    {
      Active = true;
      Health = 100;
    }

    public override void LoadContent()
    {
      Texture = SpaceBattle.GameInstance.Content.Load<Texture2D>("Sprites\\ship");
    }

    public override void Update()
    {
      
    }

  }
}
