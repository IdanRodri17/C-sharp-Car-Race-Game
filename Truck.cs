using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace CarGame
{
    [Serializable]
    public class Truck:Car
    {
        public Truck(string color)
        {
            Color = color;
            Speed = 15;
            changeColor();
        }
        ~Truck() { }
        public void changeColor()
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            if (Color == "white")
            {
                Image = Image.FromFile(Path.Combine(newPath, @"pics\TruckWhite.png"));
                
            }
            if (Color == "blue")
            {
                Image = Image.FromFile(Path.Combine(newPath, @"pics\TruckBlue.png"));
            }
        }
    }
}
