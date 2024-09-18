using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace CarGame
{
    [Serializable]
    public class Player
    {
        int left;
        string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;

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


        public Player(int left=190,string color="yellow")
        {
            Left = left;
            Color = color;
        }
        ~Player(){ }
        public PictureBox Draw() {
            PictureBox picture = new PictureBox
            {
                Name = "player",
                Size = new Size(50, 99),
                Location = new Point(Left, 430)
                
        };
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            picture.Image = changeColor();
            return picture;
        }
      public Image changeColor()
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            if (Color == "red")
            {
                return Image.FromFile(Path.Combine(newPath, @"pics\carRed.png"));
            }
            if (Color == "grey")
            {
                return Image.FromFile(Path.Combine(newPath, @"pics\carGrey.png"));
            }
            if (Color == "green")
            {
                return Image.FromFile(Path.Combine(newPath, @"pics\carGreen.png"));
            }
            return Image.FromFile(Path.Combine(newPath, @"pics\carYellow.png"));
        }

    }
}
