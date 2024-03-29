﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter
{
    class Enemy : MovingObject
    {
        bool isAlive = true;

        public Enemy(Texture2D texture, float X, float Y) : base (texture, X, Y, 0f, 0.3f)
        {
        }
    
        public void Update(GameWindow window)
        {
            vector.X += speed.X;
            if (vector.X > window.ClientBounds.Width - texture.Width || vector.X < 0)
                speed.X *= -1;
            vector.Y += speed.Y;

            if (vector.Y > window.ClientBounds.Height)
                isAlive = false;
        }

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }
    
    
    }
}
