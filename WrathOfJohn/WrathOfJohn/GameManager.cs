using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using VoidEngine;

namespace WrathOfJohn
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
	public class GameManager : Microsoft.Xna.Framework.DrawableGameComponent
	{
        public SpriteBatch spriteBatch;
		public Game1 myGame;

        public List<Sprite.AnimationSet> npcAnimationSetList;
        public List<Vector2> npcPositions;

        public Player player;
        public Texture2D playerTexture;

        public GameManager(Game1 game) : base(game)
		{
			myGame = game;
		}

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(myGame.GraphicsDevice);

            playerTexture = myGame.Content.Load<Texture2D>(@"Images\");

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
	}
}