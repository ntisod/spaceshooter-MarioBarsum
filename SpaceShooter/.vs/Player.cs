using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace SpaceShooter {

    class Player
    {
            Texture2D gfx;
            Vector2 position;
            Vector2 speed;

            public Player(Texture2D texture, float X, float Y, float speedX, float speedY)
            {
                this.gfx = texture;
                this.position.X = X;
                this.position.Y = Y;
            }
        //
        // TODO: Add constructor logic here
        //
    }
}