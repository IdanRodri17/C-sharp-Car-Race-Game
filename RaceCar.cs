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
    public class RaceCar:Car
    {
        public RaceCar(string color)
        {
            Color = color;
            Speed = 30;
            changeColor();
        }
        ~RaceCar() { }
        public void changeColor()
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            if (Color == "pink")
            {
                Image = Image.FromFile(Path.Combine(newPath, @"pics\carPink.png"));
                
            }
            if (Color == "orange")
            {
                Image = Image.FromFile(Path.Combine(newPath, @"pics\carOrange.png"));
                
            }
        }

    }
}
