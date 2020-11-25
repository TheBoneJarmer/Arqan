using Arqan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example2
{
    public class Block
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int Direction { get; set; }
        public bool UseDelta { get; set; }

        private float r;
        private float g;
        private float b;

        public Block(float x, float y)
        {
            this.X = x;
            this.Y = y;

            r = (new Random().Next(0, 255)) / 255f;
            g = (new Random().Next(0, 255)) / 255f;
            b = (new Random().Next(0, 255)) / 255f;
            Direction = new Random().Next(0, 3);
        }

        public void Update(double deltaTime, float windowWidth, float windowHeight)
        {
            var speed = 0d;

            if (UseDelta)
            {
                speed = 60 * deltaTime;
            }
            else
            {
                speed = 1;
            }

            if (X > windowWidth - 32) Direction = 1;
            if (X < 0) Direction = 0;
            if (Y > windowHeight - 32) Direction = 3;
            if (Y < 0) Direction = 2;

            if (Direction == 0) this.X += speed;
            if (Direction == 1) this.X -= speed;
            if (Direction == 2) this.Y += speed;
            if (Direction == 3) this.Y -= speed;
        }

        public void Render()
        {
            GL.glColor3f(r, g, b);
            GL.glBegin(GL.GL_QUADS);
            GL.glVertex2d(X, Y);
            GL.glVertex2d(X + 32, Y);
            GL.glVertex2d(X + 32, Y + 32);
            GL.glVertex2d(X, Y + 32);
            GL.glEnd();
        }
    }
}
