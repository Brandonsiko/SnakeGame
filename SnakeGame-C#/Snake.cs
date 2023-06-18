using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake
    {
        public Rectangle[] snakeRec;
        private SolidBrush brush;
        public int x, y, width, height;

        public Snake()
        {
            snakeRec = new Rectangle[3];
            brush = new SolidBrush(Color.Red);
            x = 20;
            y = 0;
            width = 10;
            height = 10;

            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }
         public void drawSnake(Graphics paper)
         {
             foreach(Rectangle rec in snakeRec)
             {
            paper.FillRectangle(brush, rec);
             }
         } 
        public void drawSnake()
        {
            for(int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }
        public void MoveDown()
        {
            drawSnake();
            snakeRec[0].Y += 10;
        }
        public void MoveLeft()
        {
            drawSnake();
            snakeRec[0].X -= 10;
        }
        public void MoveUp()
        {
            drawSnake();
            snakeRec[0].Y -= 10;
        }
        public void MoveRight()
        {
            drawSnake();
            snakeRec[0].X += 10;
        }
    }
}
