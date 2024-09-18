
namespace CarGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.Road1 = new System.Windows.Forms.PictureBox();
            this.Road2 = new System.Windows.Forms.PictureBox();
            this.Road3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.explosion = new System.Windows.Forms.PictureBox();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greyStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.Road1);
            this.panel1.Controls.Add(this.Road2);
            this.panel1.Controls.Add(this.Road3);
            this.panel1.Location = new System.Drawing.Point(44, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 844);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(352, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 3;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Location = new System.Drawing.Point(325, 755);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 50);
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // Road1
            // 
            this.Road1.Location = new System.Drawing.Point(3, 146);
            this.Road1.Name = "Road1";
            this.Road1.Size = new System.Drawing.Size(550, 294);
            this.Road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road1.TabIndex = 1;
            this.Road1.TabStop = false;
            this.Road1.Click += new System.EventHandler(this.Road1_Click);
            // 
            // Road2
            // 
            this.Road2.Location = new System.Drawing.Point(0, 620);
            this.Road2.Name = "Road2";
            this.Road2.Size = new System.Drawing.Size(550, 672);
            this.Road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road2.TabIndex = 2;
            this.Road2.TabStop = false;
            this.Road2.Click += new System.EventHandler(this.Road2_Click);
            // 
            // Road3
            // 
            this.Road3.Location = new System.Drawing.Point(0, -532);
            this.Road3.Name = "Road3";
            this.Road3.Size = new System.Drawing.Size(550, 672);
            this.Road3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road3.TabIndex = 3;
            this.Road3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // explosion
            // 
            this.explosion.Location = new System.Drawing.Point(75, 780);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(50, 51);
            this.explosion.TabIndex = 5;
            this.explosion.TabStop = false;
            this.explosion.Visible = false;
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startOver);
            // 
            // pauseStripMenuItem1
            // 
            this.pauseStripMenuItem1.Enabled = false;
            this.pauseStripMenuItem1.Name = "pauseStripMenuItem1";
            this.pauseStripMenuItem1.Size = new System.Drawing.Size(73, 29);
            this.pauseStripMenuItem1.Text = "Pause";
            this.pauseStripMenuItem1.Click += new System.EventHandler(this.pauseStripMenuItem1_Click);
            // 
            // changeColorStripMenuItem1
            // 
            this.changeColorStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yellowStripMenuItem1,
            this.redStripMenuItem1,
            this.greyStripMenuItem1,
            this.greenStripMenuItem1});
            this.changeColorStripMenuItem1.Name = "changeColorStripMenuItem1";
            this.changeColorStripMenuItem1.Size = new System.Drawing.Size(164, 29);
            this.changeColorStripMenuItem1.Text = "Change Your Car!";
            // 
            // yellowStripMenuItem1
            // 
            this.yellowStripMenuItem1.ForeColor = System.Drawing.Color.Gold;
            this.yellowStripMenuItem1.Name = "yellowStripMenuItem1";
            this.yellowStripMenuItem1.Size = new System.Drawing.Size(163, 34);
            this.yellowStripMenuItem1.Text = "Yellow";
            this.yellowStripMenuItem1.Click += new System.EventHandler(this.yellowStripMenuItem1_Click);
            // 
            // redStripMenuItem1
            // 
            this.redStripMenuItem1.ForeColor = System.Drawing.Color.Crimson;
            this.redStripMenuItem1.Name = "redStripMenuItem1";
            this.redStripMenuItem1.Size = new System.Drawing.Size(163, 34);
            this.redStripMenuItem1.Text = "Red";
            this.redStripMenuItem1.Click += new System.EventHandler(this.redStripMenuItem1_Click);
            // 
            // greyStripMenuItem1
            // 
            this.greyStripMenuItem1.ForeColor = System.Drawing.Color.SlateGray;
            this.greyStripMenuItem1.Name = "greyStripMenuItem1";
            this.greyStripMenuItem1.Size = new System.Drawing.Size(163, 34);
            this.greyStripMenuItem1.Text = "Grey";
            this.greyStripMenuItem1.Click += new System.EventHandler(this.greyStripMenuItem1_Click);
            // 
            // greenStripMenuItem1
            // 
            this.greenStripMenuItem1.ForeColor = System.Drawing.Color.ForestGreen;
            this.greenStripMenuItem1.Name = "greenStripMenuItem1";
            this.greenStripMenuItem1.Size = new System.Drawing.Size(163, 34);
            this.greenStripMenuItem1.Text = "Green";
            this.greenStripMenuItem1.Click += new System.EventHandler(this.greenStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseStripMenuItem1,
            this.changeColorStripMenuItem1,
            this.saveStripMenuItem1,
            this.loadStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveStripMenuItem1
            // 
            this.saveStripMenuItem1.Name = "saveStripMenuItem1";
            this.saveStripMenuItem1.Size = new System.Drawing.Size(116, 30);
            this.saveStripMenuItem1.Text = "Save Game";
            this.saveStripMenuItem1.Click += new System.EventHandler(this.saveStripMenuItem1_Click);
            // 
            // loadStripMenuItem1
            // 
            this.loadStripMenuItem1.Name = "loadStripMenuItem1";
            this.loadStripMenuItem1.Size = new System.Drawing.Size(118, 30);
            this.loadStripMenuItem1.Text = "Load Game";
            this.loadStripMenuItem1.Click += new System.EventHandler(this.loadStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(631, 833);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Road2;
        private System.Windows.Forms.PictureBox Road1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Road3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeColorStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yellowStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem greyStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem greenStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadStripMenuItem1;
    }
}

