using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShooter
{
    class Player
    {
        Texture2D texture;
        Vector2 position;
        Vector2 speed;

        public Player(Texture2D texture, float X, float Y, float speedX, float speedY)
        {
            this.texture = texture;
            this.position.X = X;
            this.position.Y = Y;
            this.speed.X = speedX;
            this.speed.Y = speedY;
        }

        public void Update(GameWindow window)
        {
            KeyboardState keyboardState = Keyboard.GetState();
        
           
            if(keyboardState.IsKeyDown(Keys.Right) || keyboardState.IsKeyDown(Keys.D))
            {
                position.X += speed.X;
            }

            if (keyboardState.IsKeyDown(Keys.Left) || keyboardState.IsKeyDown(Keys.A))
            {
                position.X -= position.X;
            }

            if (keyboardState.IsKeyDown(Keys.Up) || keyboardState.IsKeyDown(Keys.W))
            {
                position.Y -= speed.Y;
            }

            if (keyboardState.IsKeyDown(Keys.Down) || keyboardState.IsKeyDown(Keys.S))
            
            {
                position.Y += speed.Y;
            }
        }
    }   
}
