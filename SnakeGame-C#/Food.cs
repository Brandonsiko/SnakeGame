using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;


namespace SnakeGame
{
    public class Food
    {
        public int x, y, width, height;
        public SolidBrush brush;
        public Rectangle foodRec;

         public Food(Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;

            brush = new SolidBrush(Color.Black);
            foodRec = new Rectangle(x,y,width,height);
            width = 10;
            height = 10;

        }
        public void FoodLocation(Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;
        }
        public void DrawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;

            paper.FillRectangle(brush, foodRec);
        }
    }
}
