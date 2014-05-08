using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Trivia_master.Properties;

namespace Trivia_master
{
    public partial class StartingForm : Form1
    {
        protected Easy Easy { get; set; }
        protected Medium Medium { get; set; }
        protected Hard Hard { get; set; }
        public StartingForm(Easy easy, Medium medium, Hard hard)
        {
            InitializeComponent();
            this.Easy = easy;
            this.Medium = medium;
            this.Hard = hard;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Easy.createState();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medium.createState();
        }
        public override void CloseForm()
        {
            CloseForm cs = new CloseForm();
            if (cs.ShowDialog() == DialogResult.Yes)
            {
                Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hard.createState();
    
        }

        private bool IsClicked = false;
        private Point mousePoint;
        private Point currPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsClicked = true;
                mousePoint = e.Location;
                Cursor = Cursors.SizeAll;
                currPoint = this.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                this.Location = new Point(this.Location.X + (e.Location.X - mousePoint.X), this.Location.Y + (e.Location.Y - mousePoint.Y));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Location.Y < 0) this.Location = new Point(this.Location.X, 0);
                IsClicked = false;
                Cursor = Cursors.Default;
            }
        }

        private void StartingForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }

        // Don't remove
        protected override void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
