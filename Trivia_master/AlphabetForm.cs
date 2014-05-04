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
    public partial class AlphabetForm : Form1
    {
        protected MediumQuestionPainter Question { get; set; }
        protected int Answere { get; set; }
        public AlphabetForm(Category<MediumQuestionPainter, MediumAnswerPainter> c, IQuestion<MediumQuestionPainter, MediumAnswerPainter> q, int TimeToClose = 3)
        {
            Answere = 0;
            InitializeComponent();
            DoubleBuffered = true;
            Question = q.getQuestion()[0];
            Question.Form = this;
            Question.Font = lblKategorija.Font;
            Question.Reset();
            Answer = q.getCorrectAnswer()[0];
            Answer.Form = this;
            Answer.SmallerFont = lblKategorija.Font;
            Answer.LargerFont = lblOdgovor.Font;
            Answer.Reset();
            lblKategorija.Text = c.ToString();
            Invalidate(true);
        }

        private void Draw(Graphics g)
        {
            if(Answere == 0)
                Question.Draw(g);
            Answer.Draw(g);
        }

        private void AlphabetForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Question.KeyPress(e);
            Answer.KeyPress(e);
        }

        private void AlphabetForm_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        private void AlphabetForm_KeyDown(object sender, KeyEventArgs e)
        {
            Question.KeyDown(e);
            Answer.KeyDown(e);
        }

        private void AlphabetForm_KeyUp(object sender, KeyEventArgs e)
        {
            Question.KeyUp(e);
            Answer.KeyUp(e);
        }

        public override void UpdateView()
        {
            Invalidate();
        }

        private void AlphabetForm_MouseDown(object sender, MouseEventArgs e)
        {
            Question.MouseDown(e);
            Answer.MouseDown(e);
        }

        private void AlphabetForm_MouseUp(object sender, MouseEventArgs e)
        {
            Question.MouseUp(e);
            Answer.MouseUp(e);
        }

        private void AlphabetForm_MouseMove(object sender, MouseEventArgs e)
        {
            Question.MouseMove(e);
            Answer.MouseMove(e);
        }

        public override Size getSize()
        {
            return Size;
        }

        public override void Answered()
        {
            lblKategorija.Visible = false;
            lblOdgovor.Visible = false;
            label2.Visible = false;
            Answere = 1;
            UpdateView();
        }
    }
}
