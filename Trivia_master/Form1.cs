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
    public partial class Form1 : Form, IUpdatableView
    {
        Boolean IsClicked = false;
        Point mousePoint;
        Point currPoint;

        public Form1()
        {
            InitializeComponent();
        }

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
        public virtual void CloseForm()
        {
            Close();
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
          /*  CloseForm cs = new CloseForm();
            if (cs.ShowDialog() == DialogResult.Yes)
            {
                Close();
            }*/
            CloseForm();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        public virtual void CorrectAnswer()
        {
            DialogResult = DialogResult.OK;
        }

        public virtual void IncorrectAnswer()
        {
            DialogResult = DialogResult.No;
        }

        public virtual void UpdateView()
        {
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public virtual Size getSize()
        {
            return this.Size;
        }


        public virtual void TimeElapsed()
        {
            DialogResult = DialogResult.No;
        }

        public virtual void Answered()
        {

        }
    }
}
