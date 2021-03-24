using System;
using System.Collections.Generic;
using System.Drawing;

namespace POO_WF2
{
    class Ball
    {
        private Rectangle ball;
        private SolidBrush brush;
        private int speedX;

        public Ball(int x, int y)
        {
            ball = new Rectangle(x, y, 30, 30);            
            brush = new SolidBrush(Color.Blue);
            speedX = 3;
        }

        public void Update(int screenWidth)
        {
            ball.X += speedX;

            CollisionWithScreen(screenWidth);
        }
        public void Draw(Graphics g) 
        { 
            g.FillEllipse(brush, ball); 
        }

        private void CollisionWithScreen(int screenWidth)
        {
            if (ball.X < 0 || ball.X + ball.Width + ball.Width / 2 > screenWidth) speedX *= -1;
        }
    }
}
