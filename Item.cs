using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CarGame
{
    [Serializable]
    public abstract class Item
    {
        int top;
        int left;
        int speed;
        int width;
        int height;
        Image image;
        public Item(int top=25,int left=90,int speed=20,int width=50,int height=99)
        {
            Top = top;
            Left = left;
            Speed = speed;
            Width = width;
            Height = height;
        }
        
        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;

            }
        }
        public int Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;

            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;

            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;

            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;

            }
        }
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;

            }
        }
        public abstract PictureBox Draw();
        public abstract int pointsWorth();

    }
}
