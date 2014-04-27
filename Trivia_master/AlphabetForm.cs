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
    public partial class AlphabetForm<T, U> : Form1 where T : MediumQuestionPainter  where U : MediumAnswerPainter
    {
        protected T Question { get; set; }
        protected U Answer { get; set; }
        protected int Answere { get; set; }
        protected int TimeToClose { get; set; }
        List<AlphabetButton> list;
        public AlphabetForm(Category<T, U> c, IQuestion<T, U> q, int TimeToClose = 3)
        {
            Answere = 0;
            this.TimeToClose = TimeToClose;
            InitializeComponent();
            DoubleBuffered = true;
            Question = q.getQuestion()[0];
            Question.Form = this;
            Question.Font = lblKategorija.Font;
            Question.Reset();
            Answer = q.getCorrectAnswer()[0];
            Answer.Form = this;
            Answer.AlphaFont = lblKategorija.Font;
            Answer.Font = lblOdgovor.Font;
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
