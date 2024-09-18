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
    public class Tree : Obstacle
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
        public Tree(string type="oak"){
            Type = type;
            Speed = 25;
            Height = 100;
            Width = 40;
            changeType();
        }
        ~Tree() { }
        public void changeType()
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            if (Type == "oak")
            {
                Image = Image.FromFile(Path.Combine(newPath, @"pics\tree2.png"));

            }
            if (Type == "cypress")
            {
                Image = Image.FromFile(Path.Combine(newPath, @"pics\tree1.png"));
            }
        }

    }
}
