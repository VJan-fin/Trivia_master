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
            Answer.Font = lblOdgovor.Font;
            Answer.Reset();
            lblKategorija.Text = c.ToString();
            list = new List<AlphabetButton>();
            list.Add(button1);
            list.Add(triviaButton1);
            list.Add(triviaButton2);
            list.Add(triviaButton3);
            list.Add(triviaButton4);
            list.Add(triviaButton5);
            list.Add(triviaButton6);
            list.Add(triviaButton7);
            list.Add(triviaButton8);
            list.Add(triviaButton9);
            list.Add(triviaButton10);
            list.Add(triviaButton11);
            list.Add(triviaButton12);
            list.Add(triviaButton13);
            list.Add(triviaButton14);
            list.Add(triviaButton15);
            list.Add(triviaButton16);
            list.Add(triviaButton17);
            list.Add(triviaButton18);
            list.Add(triviaButton19);
            list.Add(triviaButton20);
            list.Add(triviaButton21);
            list.Add(triviaButton22);
            list.Add(triviaButton23);
            list.Add(triviaButton24);
            list.Add(triviaButton25);
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
            if (Answere != 0)
                return;
            foreach (Button btn in list)
            {
                if (btn.Enabled && btn.Text.Equals(e.KeyData.ToString().ToUpper()))
                    btn.BackColor = Color.FromArgb(192, 192, 0);
            }
            Question.KeyDown(e);
            Answer.KeyDown(e);
        }

        private void AlphabetForm_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Button btn in list)
            {
                if (btn.Enabled && btn.Text.Equals(e.KeyData.ToString().ToUpper()) && btn.BackColor == Color.FromArgb(192, 192, 0))
                {
                    btn.BackColor = Color.Transparent;
                    btn.Enabled = false;
                }
            }
            if (Answere != 0)
                return;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeToClose--;
            if (TimeToClose == 0)
            {
                timer1.Stop();
                if (Answere == 1)
                    base.IncorrectAnswer();
                else base.CorrectAnswer();
            }
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
