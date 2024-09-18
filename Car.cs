using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace CarGame
{
    [Serializable]
    public class Car :Obstacle
    {
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
        public Car(string color="")
        {
            Color = color;
            Speed = 20;
            Width = 50;
            Height = 99;
            
        }
        ~Car() { }
       
    }
}
