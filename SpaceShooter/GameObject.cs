﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter
{
    //      klassobject för spelobject som har bild och position
    class GameObject
    {
        protected Texture2D texture;
        protected Vector2 vector;
        
        //     kunstruktor för att skapa object 
        public GameObject(Texture2D texture, float X, float Y)
        {
            this.texture = texture;
            this.vector.X = X;
            this.vector.Y = Y;
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, vector, Color.White);
        }

        //     Egenskaper för object

        public float X{ get { return vector.X; } }
        public float Y{ get { return vector.Y; } }
        public float Width{ get { return texture.Width; } }
        public float Height{ get { return texture.Height; } }
    }

    abstract class MovingObject : GameObject
    {
        protected Vector2 speed;
        //    kunstruktor för att skapa objektet
        public MovingObject(Texture2D texture, float X, float Y, float speedX, float speedY) : base(texture, X, Y)
        {
            this.speed.X = speedX;
            this.speed.Y = speedY;
        }
    }

    abstract class PhysicalObject : MovingObject
    {
        protected bool isAlive = true;

        // kunstruktor 
        public PhysicalObject(Texture2D texture, float X, float Y, float speedX, float speedY)
            : base(texture, X, Y, speedX, speedY)
        {
        }
        // kollision checkning mellan objekt
        public bool checkCollision(PhysicalObject other)
        {
            Rectangle myRect = new Rectangle(Convert.ToInt32(X);
        }

    }
}
