using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia_master
{
    public partial class AlphabetForm<T, U> : Form1 where T : MediumQuestionPainter  where U : MediumAnswerPainter
    {
        IQuestion<T, U> question;
        protected T Question { get; set; }
        protected U Answer { get; set; }
        List<AlphabetButton> list;
        int count;
        public AlphabetForm(Category<T, U> c, IQuestion<T, U> q)
        {
            InitializeComponent();
            count = 0;
            DoubleBuffered = true;
            question = q;
            Question = q.getQuestion()[0];
            Answer = q.getCorrectAnswer()[0];
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
            lblKategorija.Text = c.ToString();
            Question.Font = lblKategorija.Font;
            Answer.Font = lblOdgovor.Font;
            Answer.reset();
        }

        public override void UpdateView()
        {
            Invalidate();
        }

        public override void CorrectAnswer()
        {
            DialogResult = DialogResult.OK;
        }

        public override void IncorrectAnswer()
        {
            DialogResult = DialogResult.No;
        }

        private void Draw(Graphics g)
        {
            Question.Draw(g);
            Answer.Draw(g);
        }

        private void AlphabetForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (AlphabetButton btn in list)
                if (btn.Text.Equals(e.KeyChar.ToString().ToUpper()) && btn.Enabled == false)
                    return;
            if (!question.getCorrectAnswer()[0].AddChar(e.KeyChar))
            {
                count++;
                if (count == 5)
                    DialogResult = DialogResult.No;
            }
            if (question.getCorrectAnswer()[0].IsCorrect())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void AlphabetForm_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        private void AlphabetForm_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (AlphabetButton btn in list)
                if (btn.Text.Equals(e.KeyData.ToString().ToUpper()) && btn.Enabled != false)
                    btn.BackColor = Color.Yellow;
            Invalidate();
        }

        private void AlphabetForm_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (AlphabetButton btn in list)
                if (btn.Text.Equals(e.KeyData.ToString().ToUpper()) && btn.Enabled != false)
                {
                    btn.BackColor = Color.Transparent;
                    btn.Enabled = false;
                }
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (!question.getCorrectAnswer()[0].AddChar(btn.Text.ElementAt<Char>(0)))
            {
                count++;
                if (count == 5)
                    DialogResult = DialogResult.No;
            }
            if (question.getCorrectAnswer()[0].IsCorrect())
            {
                DialogResult = DialogResult.OK;
            }
            btn.Enabled = false;
            Invalidate();
        }
    }
}
