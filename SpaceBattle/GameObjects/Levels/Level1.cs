using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects.Levels
{
  public class Level1 : Level
  {

    public Level1(SpriteBatch batch, Player player) : base(batch)
    {
      //set player coordinates
      //create items on map

      //TODO CONtent manager kuntoon ja joka levelille oma content manager
      //this.content = new Microsoft.Xna.Framework.Content.ContentManager();

      this.player = player;
      var playerPosition = new Vector2(SpaceBattle.GameInstance.GraphicsDevice.Viewport.TitleSafeArea.X,
        SpaceBattle.GameInstance.GraphicsDevice.Viewport.TitleSafeArea.Y + SpaceBattle.GameInstance.GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
      player.Position = playerPosition;
      LoadContent();
    }
    
    public override void Draw(SpriteBatch batch)
    {
      base.Draw(batch);
      player.Draw(batch);
    }
  }
}
