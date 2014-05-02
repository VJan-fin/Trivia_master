using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Trivia_master.Properties;
using System.Windows.Forms;

namespace Trivia_master
{
    public class AlphabetAnswer : MediumAnswerPainter
    {
        protected String answer { get; set; }
        protected String CorrectAnswer { get; set; }
        protected List<CostomAlphabetButton> Buttons { get; set; }
        protected Point AnswerLocation { get; set; }
        protected Brush AnswerBrush { get; set; }
        protected HashSet<Char> Set { get; set; }
        protected Color AnswerColor { get; set; }
        protected int Attempts { get; set; }
        protected int AttemptsToClose { get; set; }
        protected int DefaultAttempts { get; set; }
        protected Point AttemptsLocation { get; set; }
        protected StringBuilder sb;
        protected int count;
        protected int wrong;
        public Point AttemptsRelativeLocation {get; set;}

        public AlphabetAnswer(String a, int time = 20, int attepmts = 5) : base(time)
        {
            answer = a;
            sb = new StringBuilder();
            AnswerBrush = new SolidBrush(Color.White);
            Answered = 0;
            StringBuilder pm = new StringBuilder();
            for (int i = 0; i < answer.Length; i++)
            {
                pm.Append(Char.ToUpper(answer.ElementAt<Char>(i)));
                pm.Append(" ");
            }
            DefaultAttempts = attepmts;
            AttemptsRelativeLocation = new Point(63, 23);
            Attempts = attepmts;
            AttemptsToClose = (int)Math.Round(Attempts * 20.0 / 100, 0);
            CorrectAnswer = pm.ToString();
        }

        public override void Reset()
        {
            Answered = 0;
            base.Reset();
            sb = new StringBuilder();
            for (int i = 0; i < answer.Length; i++)
            {
                sb.Append("_ ");
            }
            count = 0;
            wrong = 0;
            Set = new HashSet<char>();
            Attempts = DefaultAttempts;
            AnswerLocation = new Point(Location.X + (Math.Min(Size.Width, Size.Height) * 4 / 19), Location.Y + (Math.Min(Size.Width, Size.Height) * 5 / 8));
            AnsweredAnswerLocation = new Point(Location.X + (Math.Min(Size.Width, Size.Height) * 4 / 19), Location.Y + (Math.Min(Size.Width, Size.Height) * 31 / 40));
            AttemptsLocation = new Point(Location.X + (Math.Min(Size.Width, Size.Height) * AttemptsRelativeLocation.X/100), Location.Y + (Math.Min(Size.Width, Size.Height) * AttemptsRelativeLocation.Y/100));
            int pom = (int)Math.Round(Math.Min(Size.Width, Size.Height)/16.0, 0);
            Size BtnSize = new Size(pom, pom);
            int XX = AnswerLocation.X;
            int X = XX;
            int Y = Location.Y + (Math.Min(Size.Width, Size.Height) * 41 / 64);
            int factor = (int)Math.Round(Math.Min(Size.Width, Size.Height) / 13.913, 0);
            Buttons = new List<CostomAlphabetButton>();
            for (int i = 0; i < 26; i++)
            {
                if (i % 10 == 0)
                {
                    X = XX;
                    Y += factor;
                }
                CostomAlphabetButton cb = new CostomAlphabetButton(AlphaFont, new Point(X, Y), BtnSize);
                cb.Text = ((char)('A' + i)).ToString();
                Buttons.Add(cb);
                X += factor;
            }
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            if (Answered == 0)
            {
                foreach (CostomAlphabetButton btn in Buttons)
                {
                    btn.Draw(g);
                }

                if(Attempts <= AttemptsToClose)
                    g.DrawString(String.Format("Attempts: {0:00}", Attempts), Font, TimeToCloseBrush, AttemptsLocation);
                else g.DrawString(String.Format("Attempts: {0:00}", Attempts), Font, DefaultBrush, AttemptsLocation);
                g.DrawString(sb.ToString(), Font, AnswerBrush, AnswerLocation);
            }
            else if (Answered == 1)
            {
                g.DrawImage(Resources.Wrong_answer1, new Rectangle(PictureLocation, PictureSize));
                g.DrawString(CorrectAnswer, Font, DefaultBrush, AnsweredAnswerLocation);
            }
            else if (Answered == 2)
            {
                g.DrawImage(Resources.Correct2, new Rectangle(PictureLocation, PictureSize));
                g.DrawString(CorrectAnswer, Font, AnsweredCorrect, AnsweredAnswerLocation);
            }
            else if (Answered == 3)
            {
                g.DrawImage(Resources.Timeout, new Rectangle(PictureLocation, PictureSize));
                g.DrawString(CorrectAnswer, Font, DefaultBrush, AnsweredAnswerLocation);
            }
        }

        protected void AddChar(char c)
        {
            if (Set.Contains(c))
                return;
            Set.Add(c);
            int curr = 0;
            int i = 0;
            String str = sb.ToString();
            foreach (char chr in answer)
            {
                if (char.ToUpper(c).Equals(char.ToUpper(chr)) && str.ElementAt<Char>(2*i) == '_')
                {
                    sb.Insert(2 * i, c.ToString().ToUpper());
                    sb.Remove(2 * i + 1, 1);
                    curr++;
                }
                i++;
            }
            count += curr;
            Form.UpdateView();
            if (count == answer.Length)
            {
                Form.CorrectAnswer();
            }
            if (curr == 0)
                Attempts--;
            if (Attempts == 0)
            {
                Form.IncorrectAnswer();
            }
                
        }

        public override void KeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            AddChar(e.KeyChar);
        }

        public override void KeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            foreach (CostomAlphabetButton btn in Buttons)
            {
                if (btn.Enabled && btn.Text.Equals(e.KeyData.ToString().ToUpper()))
                    btn.BackColor = Color.FromArgb(192, 192, 0);
            }
            Form.UpdateView();
        }

        public override void KeyUp(System.Windows.Forms.KeyEventArgs e)
        {
            foreach (CostomAlphabetButton btn in Buttons)
            {
                if (btn.Enabled && btn.Text.Equals(e.KeyData.ToString().ToUpper()))
                {
                    btn.Enabled = false;
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = SystemColors.InactiveCaptionText;
                }
            }
            Form.UpdateView();
        }

        public override void MouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            if (MouseClicked)
                return;
            Form.setCursor(Cursors.Default);
            foreach (CostomAlphabetButton btn in Buttons)
            {
                if (btn.Enabled && btn.IsIn(e.Location))
                {
                    Form.setCursor(Cursors.Hand);
                    btn.BackColor = Color.FromArgb(229, 192, 21);
                }
                else btn.BackColor = Color.Transparent;
            }
            Form.UpdateView();
        }

        public override void MouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            MouseClicked = true;
            foreach (CostomAlphabetButton btn in Buttons)
            {
                if (btn.Enabled && btn.IsIn(e.Location))
                {
                    Form.setCursor(Cursors.Hand);
                    btn.BackColor = Color.FromArgb(192, 192, 0);
                }
                else btn.BackColor = Color.Transparent;
            }
            Form.UpdateView();
        }

        public override void MouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            MouseClicked = false;
            foreach (CostomAlphabetButton btn in Buttons)
            {
                if (btn.Enabled && btn.IsIn(e.Location))
                {
                    btn.BackColor = Color.Transparent;
                    btn.Enabled = false;
                    btn.ForeColor = SystemColors.InactiveCaptionText;
                    AddChar(btn.Text.ElementAt<char>(0));
                }
                else btn.BackColor = Color.Transparent;
            }
        }
    }
}
