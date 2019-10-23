using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceShooter
{
    /// <summary>
    /// This is the main type for your game.
    ///
    /// Mario Barsum Te17 i kursen programmerring 2 2019-9-20
    /// 
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Player player;

        List<Enemy> enemies;

        PrintText printText;
        Enemy enemy;
        // mina variabler:

        public Game1()

        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            printText = new PrintText(Content.Load<SpriteFont>("myFont"));
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            player = new Player(Content.Load<Texture2D>("Sprites/ship"), 380, 400, 2.5f, 4.5f);

            // skapa fiender
            enemy = new Enemy(Content.Load<Texture2D>("Sprites/mine"), 100.0f, 100.0f);
            enemies = new List<Enemy>();
            Random random = new Random();
            Texture2D tmpSprite = Content.Load<Texture2D>("Sprites/mine");
            for (int i = 0; i < 10; i++)
            {
                int rndX = random.Next(0, Window.ClientBounds.Width - tmpSprite.Width);
                int rndY = random.Next(0, Window.ClientBounds.Height/2);
                Enemy temp = new Enemy(tmpSprite, rndX, rndY);
                enemies.Add(temp); // lägg till i listan
            }


        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            player.Update(Window);

            enemy.Update(Window);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            printText.print("Antal fiender" + enemies.Count, spriteBatch, 0, 0);
            //player.draw(spriteBatch);
            player.Draw(spriteBatch);

            foreach (Enemy e in enemies)
                e.Draw(spriteBatch);

            foreach (Enemy e in enemies)
            {
                if (e.IsAlive)
                    e.Update(Window);
                else
                    enemies.Remove(e);
            }


            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}