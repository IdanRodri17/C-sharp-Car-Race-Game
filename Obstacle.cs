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
    public class Obstacle:Item
    {
        public Obstacle()
        {
            Speed = 25;
        }
        ~Obstacle() { }
        public override int pointsWorth()
        {
            return 0;
        }
        public override PictureBox Draw()
        {

                PictureBox picture = new PictureBox
                {
                    Name = "obstacle",
                    Size = new Size(50, 99),
                    Location = new Point(Left, Top)

                };
                picture.Image = Image;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            return picture;
        }

    }
}
