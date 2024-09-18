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
    public class Prize:Item
    {
        string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;

            }
        }
        public Prize(string type="coin")
        {
            Type = type;
            Speed = 25;
            
            int cost=changeType();
        }
        ~Prize() { }
        public int changeType()
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            if (Type == "coin")
            {
                Image = Image.FromFile(Path.Combine(newPath, @"pics\coin.png"));
                Height = 30;
                Width = 30;
                return 5;

            }
            if (Type == "bill")
            {
                Image = Image.FromFile(Path.Combine(newPath, @"pics\bill.png"));
                Height = 20;
                Width = 99;
                return 10;
            }
            if (Type == "trophy")
            {
                Image = Image.FromFile(Path.Combine(newPath, @"pics\trophy.png"));
                Height = 70;
                Width = 30;
                return 20;
            }
            return 10;
        }
        public override int pointsWorth()
        {
            return changeType();
        }
        public override PictureBox Draw()
        {

            PictureBox picture = new PictureBox
            {
                Name = "prize",
                Size = new Size(60, 60),
                Location = new Point(Left, Top)

            };
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            picture.Image = Image;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            return picture;
        }

    }
}
