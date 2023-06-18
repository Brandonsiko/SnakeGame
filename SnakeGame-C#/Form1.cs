using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        Random randFood = new Random();
        Graphics paper;
        Snake snake = new Snake();
        Food food;
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;

        public Form1()
        {
            InitializeComponent();
            food = new Food(randFood);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            paper = e.Graphics;
            food.DrawFood(paper);
            snake.drawSnake(paper);

            for(int i = 0; i < snake.snakeRec.Length; i++)
            {
                if (snake.snakeRec[i].IntersectsWith(food.foodRec))
                {
                    food.FoodLocation(randFood);
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Down && up ==false)
            {
                down = true;
                up = false;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Left && right== false)
            {
                down = false;
                up = false;
                left = true;
                right = false;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                down =  false;
                up = false;
                left = false;
                right =true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (down)
            {
                snake.MoveDown();
            }
            if (up)
            {
                snake.MoveUp();
            }
            if (left)
            {
                snake.MoveLeft();
            }
            if (right)
            {
                snake.MoveRight();
            }

            this.Invalidate();
        }
    }
}
