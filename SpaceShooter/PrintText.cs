﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter
{
    class PrintText
    {
        SpriteFont font;

        //  printtext kunstruktor som tar spritefont objekt som är en font som har laddats in genom content
        public PrintText(SpriteFont font)
        {
            this.font = font;
        }

        // skriv ut texten på skärmen
        public void print(string text, SpriteBatch spriteBatch, int X, int Y)
        {
            spriteBatch.DrawString(font, text, new Vector2(X, Y), Color.White);
        }

    }
}
