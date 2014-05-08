using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Trivia_master.Properties;
using System.Drawing.Drawing2D;

namespace Trivia_master
{
    public partial class Form1 : Form, IUpdatableView
    {
      public  MediumAnswerPainter Answer;
        Boolean IsClicked = false;
        Point mousePoint;
        Point currPoint;
        int curr;

        public Form1()
        {
            InitializeComponent();
            curr = 0;
            timer1.Start();
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
            DialogResult = DialogResult.No;
            //Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked && Cursor != Cursors.Hand)
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
            Answer.CorrectAnswer();
        }

        public virtual void IncorrectAnswer()
        {
            Answer.IncorrectAnswer();
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
            Answer.TimeElapsed();
        }

        public virtual void DevilAnswer()
        {
            Answer.DevilAnswer();
        }

        public virtual void JokerAnswer()
        {
            Answer.JokerAnswer();
        }

        public virtual void Answered()
        {

        }


        public void setCursor(Cursor crs)
        {
            this.Cursor = crs;
        }


        public void AnswerTrue()
        {
            DialogResult = DialogResult.OK;
        }

        public void AnswerFalse()
        {
            DialogResult = DialogResult.No;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            curr++;
            if (curr == 10)
                timer1.Stop();
        }

        protected virtual void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
