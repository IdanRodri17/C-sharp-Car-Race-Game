using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace CarGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
           KeyPreview = true;
            InitializeComponent();
        }
        int roadSpeed=100;
        ItemsList items = new ItemsList();
        PictureBox item = new PictureBox();
        Random itemPosition = new Random();
        Random itemType = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));

            pauseStripMenuItem1.Enabled = true;
            startToolStripMenuItem.Enabled = false;
            Road1.Top += roadSpeed;
            Road2.Top += roadSpeed;
            Road3.Top += roadSpeed;
            if (Road2.Top > 672)
            {
                Road2.Top = -672;
            }
            if (Road1.Top > 672)
            {
                Road1.Top = -672;
            }
            if (Road3.Top > 672)
            {
                Road3.Top = -672;
            }

            item.Top += items.showFirst().Speed;
            if (item.Top > 430)
            {
                items.Remove();
                item.Top =-400;
                numToType(itemType.Next(0, 9));
                items.showFirst().Left = itemPosition.Next(40, 340);
                item = items.showFirst().Draw();
                this.Controls.Add(item);
                item.BringToFront();
                item.BackColor = Color.Black;
                

            }
            if (player.Bounds.IntersectsWith(item.Bounds))
            {
                if (items.showFirst().pointsWorth() == 0)
                {
                    timer1.Stop();
                    startToolStripMenuItem.Text = "start over";
                    startToolStripMenuItem.Click -= new EventHandler(unpause);
                    startToolStripMenuItem.Click += new EventHandler(startOver);
                    pauseStripMenuItem1.Enabled = false;
                    startToolStripMenuItem.Enabled = true;

                    
                    explosion.Visible = true;
                    
                    explosion.Image = Image.FromFile(Path.Combine(newPath, @"pics\explosion.gif"));
                    player.Controls.Add(explosion);
                    explosion.Location = new Point(8, 0);
                    explosion.BackColor = Color.Transparent;
                    explosion.SizeMode = PictureBoxSizeMode.StretchImage;

                    System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Path.Combine(newPath, @"sounds\hit.wav"));
                    playCrash.Play();

                    saveStripMenuItem1.Enabled = false;
                    

                }
                if (items.showFirst().pointsWorth() > 0)
                {
                    items.Score += items.showFirst().pointsWorth();
                    items.Remove();
                    item.Top = -400;
                    numToType(itemType.Next(0, 9));
                    items.showFirst().Left = itemPosition.Next(40, 340);
                    item = items.showFirst().Draw();
                    this.Controls.Add(item);
                    item.BringToFront();
                    item.BackColor = Color.Black;

                    System.Media.SoundPlayer playGain = new System.Media.SoundPlayer(Path.Combine(newPath, @"sounds\coin.wav"));
                    playGain.Play();

                    
                }
            }
            label1.Text = "coins: " + items.Score;
        }

       

        private void Road1_Click(object sender, EventArgs e)
        {

        }

        private void Road2_Click(object sender, EventArgs e)
        {
           
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            Road1.Image = Image.FromFile(Path.Combine(newPath, @"pics\roadTrack.jpg"));
            Road2.Image = Image.FromFile(Path.Combine(newPath, @"pics\roadTrack.jpg"));
            Road3.Image = Image.FromFile(Path.Combine(newPath, @"pics\roadTrack.jpg"));
            player = items.Player.Draw();
            this.Controls.Add(player);
            player.BringToFront();
            player.BackColor = Color.Black;
            menuStrip1.BringToFront();
            label1.Text = "coins: " + items.Score;

            saveStripMenuItem1.Enabled = false;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if(items.showFirst().Speed<40&& items.showFirst().Speed>10)
                    items.showFirst().Speed += 10;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (items.showFirst().Speed < 40 && items.showFirst().Speed > 10)
                    items.showFirst().Speed -= 10;
            }
            if (e.KeyCode == Keys.Left)
            {
               
                if (player.Left > 40)
                {
                    items.Player.Left += -12;
                    player.Left = items.Player.Left;
                }
            }
            if (e.KeyCode == Keys.Right )
            {
                if (player.Right < 380)
                {
                    items.Player.Left += 12;
                    player.Left = items.Player.Left;

                }
            }
         

        }

        public void numToType(int num)
        {

            if (num == 0)
            {
                items.Add( new Truck("blue"));
                
            }
            if (num == 1)
            {
                items.Add(new Truck("white"));
            }

            if (num == 2)
            {
                items.Add(new RaceCar("orange"));
            }
            if (num == 3)
            {
                items.Add(new RaceCar("pink"));
            }
            if (num == 4)
            {
                items.Add(new Tree("oak"));
            }
            if (num == 5)
            {
                items.Add(new Tree("cypress"));
            }
            if (num == 6)
            {
                items.Add(new Prize("coin"));
            }
            if (num == 7)
            {
                items.Add(new Prize("bill"));
            }
            if (num == 8)
            {
                items.Add(new Prize("trophy"));
            }




        }
        private void unpause(object sender, EventArgs e)
        {
            timer1.Start();


            saveStripMenuItem1.Enabled = true;
            
        }
        private void startOver(object sender, EventArgs e)
        {
            this.Controls.Remove(item);
             numToType(itemType.Next(0, 9));           
            items.showFirst().Left = itemPosition.Next(40, 340);
            item = items.showFirst().Draw();
            this.Controls.Add(item);
            item.BringToFront();
            item.BackColor = Color.Black;
            items.Score = 0;
            timer1.Start();
            explosion.Visible = false;

            saveStripMenuItem1.Enabled = true;
            

        }

        private void pauseStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startToolStripMenuItem.Text = "continue";
            startToolStripMenuItem.Click -= new EventHandler(startOver);
            startToolStripMenuItem.Click += new EventHandler(unpause);
            pauseStripMenuItem1.Enabled = false;
            startToolStripMenuItem.Enabled = true;

            saveStripMenuItem1.Enabled = true;
            
        }

        private void redStripMenuItem1_Click(object sender, EventArgs e)
        {
            items.Player.Color = "red";
            player.Image = items.Player.changeColor();
            label1.Text = items.Player.Color;


        }

        private void greyStripMenuItem1_Click(object sender, EventArgs e)
        {
            items.Player.Color = "grey";
            player.Image = items.Player.changeColor();
            label1.Text = items.Player.Color;
        }

        private void greenStripMenuItem1_Click(object sender, EventArgs e)
        {
            items.Player.Color = "green";
            player.Image = items.Player.changeColor();
            label1.Text = items.Player.Color;
        }

        private void yellowStripMenuItem1_Click(object sender, EventArgs e)
        {
            items.Player.Color = "yellow";
            player.Image = items.Player.changeColor();
            label1.Text = items.Player.Color;
        }

        private void saveStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startToolStripMenuItem.Text = "continue";
            startToolStripMenuItem.Click -= new EventHandler(startOver);
            startToolStripMenuItem.Click += new EventHandler(unpause);
            pauseStripMenuItem1.Enabled = false;
            startToolStripMenuItem.Enabled = true;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, items);
                }
            }
        }

        private void loadStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startToolStripMenuItem.Text = "continue";
            startToolStripMenuItem.Click -= new EventHandler(startOver);
            startToolStripMenuItem.Click += new EventHandler(unpause);
            pauseStripMenuItem1.Enabled = false;
            startToolStripMenuItem.Enabled = true;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                items = (ItemsList)binaryFormatter.Deserialize(stream);
                this.Controls.Remove(player);
                
                player = items.Player.Draw();
                this.Controls.Add(player);
                player.BringToFront();
                player.BackColor = Color.Black;

                this.Controls.Remove(item);

                numToType(itemType.Next(0, 9));
                //items.showFirst().Left = itemPosition.Next(40, 340);
                item = items.showFirst().Draw();
                this.Controls.Add(item);
                item.BringToFront();
                item.BackColor = Color.Black;

                timer1.Start();
                explosion.Visible = false;

                saveStripMenuItem1.Enabled = true;
                

            }
        }
    }
}

