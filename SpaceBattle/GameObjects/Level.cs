using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SpaceBattle.GameObjects.Collision;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle.GameObjects
{
  public abstract class Level
  {
    //contains all collidable and interactable items in level
    protected List<MapObject> Colliders;
    //contains drawn items
    protected List<SceneItem> Drawn;

    //TODO: HUD
    //protected HUD hud;

    protected ContentManager content;
    protected SpriteBatch batch;
    protected Player player;

    protected Texture2D background;
    public Camera camera;

    public Level(SpriteBatch batch)
    {

    }

    public Level(SpriteBatch batch, Player player)
    {
      //TODO level kohtainen contentmanager
      this.batch = batch;
      this.camera = new Camera(SpaceBattle.GameInstance.GraphicsDevice.Viewport);

      this.player = player;
      this.player.DrawPosition = this.camera.Center;
      this.player.Position = this.camera.Position + this.camera.Center;
      Colliders = new List<MapObject>();
      Colliders.Add(player);
      Drawn = new List<SceneItem>();
    }

    public virtual void LoadContent()
    {
      foreach (var item in Drawn)
      {
        item.LoadContent();
      }
    }
    
    public virtual void Update()
    {
      player.Position = camera.Position;
      CollisionDetector.DetectCollisions(Colliders);

      Debug.WriteLine("Clear");
      foreach (var item in Colliders)
      {
        item.Update();
      }
    }

    //Draws eveything on screen
    public virtual void Draw(SpriteBatch batch)
    {
      //TODO: taustan piirto

      //Draw objects that are positioned relative to screen
      batch.Begin(samplerState: SamplerState.PointClamp);

        player.Draw(batch);
        //Draw hud

      batch.End();

      //Draw objects relative to map
      batch.Begin(samplerState: SamplerState.PointClamp, transformMatrix: camera.Transform);
      foreach (var item in Drawn)
      {
        item.Draw(batch);
      }
      batch.End();
    }

    public virtual void AddItem(SceneItem item)
    {
      if (item.GetType().IsSubclassOf(typeof(MapObject)))
      {
        Colliders.Add((MapObject)item);
      }
      Drawn.Add(item);
    }
  }
}
