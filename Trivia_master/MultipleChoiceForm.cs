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
    public partial class MultipleChoiceForm : Form1
    {
        private IQuestion<string, string> question;
        private Category<string, string> cat;
        private string correctAnswer;
        private bool isAnswered;
        private bool isGuessed;
        private int remainingTime = 20;
        private int timeToClose = 3;

        public MultipleChoiceForm()
        {
            InitializeComponent();
        }

        public MultipleChoiceForm(Category<string, string> cat, IQuestion<string, string> question)
        {
            InitializeComponent();
            DoubleBuffered = true;
            labelTimer.Text = String.Format("{0,2:D2}:{1,2:D2}", remainingTime / 60, remainingTime % 60);
            this.isGuessed = false;
            this.pictureBox2.Visible = false;
            this.isAnswered = false;
            this.cat = cat;
            this.question = question;
            this.labelCategory.Text = this.cat.CategoryName;
            this.labelQ.Text = question.getQuestion()[0];
            this.labelA1.Text = question.getAnswers()[0];
            this.labelA2.Text = this.question.getAnswers()[1];
            this.labelA3.Text = this.question.getAnswers()[2];
            this.labelA4.Text = this.question.getAnswers()[3];
            this.correctAnswer = this.question.getCorrectAnswer()[0];
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void labelA1_MouseEnter(object sender, EventArgs e)
        {
            if (!this.isAnswered)
            {
                this.Cursor = Cursors.Hand;
                //(32, 73, 128) - light blue
                (sender as Label).BackColor = Color.FromArgb(229, 192, 21);
            }
        }

        private void labelA1_MouseLeave(object sender, EventArgs e)
        {
            if (!this.isAnswered)
            {
                this.Cursor = Cursors.Default;
                // this colour is default
                (sender as Label).BackColor = Color.FromArgb(4, 26, 65);
            }
        }

        private void labelA1_Click(object sender, EventArgs e)
        {
            if (!this.isAnswered)
            {
                Label tmp = sender as Label;
                this.isAnswered = true;
                this.Cursor = Cursors.Default;

                Bitmap bmp;
                if (tmp.Text == correctAnswer)
                {
                    bmp = new Bitmap(Resources.Correct2);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = bmp;
                    pictureBox2.Visible = true;
                    label6.Visible = false;
                    labelCategory.Visible = false;
                    labelQ.Visible = false;
                    labelTimer.Visible = false;
                    tmp.BackColor = Color.FromArgb(0, 146, 17);
                    this.isGuessed = true;
                    Invalidate();
                }
                else
                {
                    bmp = new Bitmap(Resources.Wrong_answer1);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = bmp;
                    pictureBox2.Visible = true;
                    label6.Visible = false;
                    labelCategory.Visible = false;
                    labelQ.Visible = false;
                    labelTimer.Visible = false;
                    tmp.BackColor = Color.FromArgb(181, 0, 0);
                    tmp.ForeColor = Color.White;
                    Invalidate();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!this.isAnswered && remainingTime != 0)
            {
                remainingTime--;
                labelTimer.Text = String.Format("{0,2:D2}:{1,2:D2}", remainingTime / 60, remainingTime % 60);
                if (remainingTime <= 5)
                    labelTimer.ForeColor = Color.FromArgb(229, 192, 21);
            }
            else if(!this.isAnswered)
            {
                this.isAnswered = true;
                Bitmap bmp = new Bitmap(Resources.Timeout);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = bmp;
                pictureBox2.Visible = true;
                label6.Visible = false;
                labelCategory.Visible = false;
                labelQ.Visible = false;
                labelTimer.Visible = false;
                Invalidate();
            }
            else if(this.isAnswered)
            {
                this.timeToClose--;
                if (this.timeToClose <= 0)
                {
                    if (this.isGuessed)
                        this.DialogResult = DialogResult.Yes;
                    else
                        this.DialogResult = DialogResult.No;
                }
            }
        }
    }
}
