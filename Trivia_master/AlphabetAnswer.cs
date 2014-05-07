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
        protected Random Random { get; set; }
        public int JokerChance { get; set; }
        public int DevilChance { get; set; }
        protected String Answer { get; set; }
        protected String TheCorrectAnswer { get; set; }
        protected List<CostomAlphabetButton> Buttons { get; set; }
        protected Point AnswerLocation { get; set; }
        protected Brush AnswerBrush { get; set; }
        protected HashSet<Char> Set { get; set; }
        protected Color AnswerColor { get; set; }
        protected int Attempts { get; set; }
        protected int AttemptsToClose { get; set; }
        protected int DefaultAttempts { get; set; }
        protected Point AttemptsRelativeLocation { get; set; }
        protected StringBuilder PresentedAnswer;
        protected int CountLetters { get; set; }
        protected int CountAttempts { get; set; }
        public Point AttemtsLocation {get; set;}
        public int NumOfLetters { get; set; }
        public int TimeToEnd { get; set; }
        public Timer Timer { get; set; }
        protected bool IsChanged { get; set; }

        public AlphabetAnswer(String a , int attepmts = 5) : base()
        {
            Random = new Random();
            Answer = a;
            PresentedAnswer = new StringBuilder();
            AnswerBrush = new SolidBrush(Color.White);
            StringBuilder pm = new StringBuilder();
            NumOfLetters = 0;
            for (int i = 0; i < Answer.Length; i++)
            {
                if (!Answer.ElementAt<char>(i).Equals(' '))
                    NumOfLetters++;
                pm.Append(Char.ToUpper(Answer.ElementAt<Char>(i)));
                pm.Append(" ");
            }
            DefaultAttempts = attepmts;
            AttemtsLocation = new Point(63, 23);
            Attempts = attepmts;
            AttemptsToClose = (int)Math.Round(Attempts * 20.0 / 100, 0);
            TheCorrectAnswer = pm.ToString();
            JokerChance = 2;
            DevilChance = 10;
            Timer = new Timer();
            Timer.Interval = 1000;
            TimeToEnd = 3;
            Timer.Tick += new System.EventHandler(this.TimerTick);
        }

        public void TimerTick(object sender, EventArgs e)
        {
            if (TimeToEnd == 0)
            {
                Timer.Stop();
                if (AnswerState == AnswerStates.Incorrect || AnswerState == AnswerStates.TimeElapsed || AnswerState == AnswerStates.Devil)
                    Form.AnswerFalse();
                else
                    Form.AnswerTrue();
            }
            else
            {
                TimeToEnd--;
            }
        }

        public override void Reset()
        {
            base.Reset();

            TimeToEnd = 3;
            IsChanged = false;
            PresentedAnswer = new StringBuilder();
            
            // Builds a hangman answer.
            for (int i = 0; i < Answer.Length; i++)
            {
                if (Answer.ElementAt<char>(i).Equals(' '))
                    PresentedAnswer.Append("  ");
                else
                    PresentedAnswer.Append("_ ");
            }

            CountLetters = 0;
            CountAttempts = 0;
            Set = new HashSet<char>();
            Attempts = DefaultAttempts;
            AnswerLocation = new Point(FormLocation.X + (Math.Min(FormSize.Width, FormSize.Height) * 4 / 19), FormLocation.Y + (Math.Min(FormSize.Width, FormSize.Height) * 64/100));
            AnsweredAnswerLocation = new Point(FormLocation.X + (Math.Min(FormSize.Width, FormSize.Height) * 4 / 19), FormLocation.Y + (Math.Min(FormSize.Width, FormSize.Height) * 31 / 40));
            AttemptsRelativeLocation = new Point(FormLocation.X + (Math.Min(FormSize.Width, FormSize.Height) * AttemtsLocation.X/100), FormLocation.Y + (Math.Min(FormSize.Width, FormSize.Height) * AttemtsLocation.Y/100));
            int pom = (int)Math.Round(Math.Min(FormSize.Width, FormSize.Height)/16.0, 0);
            Size BtnSize = new Size(pom, pom);
            int XX = AnswerLocation.X;
            int X = XX;
            int Y = FormLocation.Y + (Math.Min(FormSize.Width, FormSize.Height) * 41 / 64);
            int factor = (int)Math.Round(Math.Min(FormSize.Width, FormSize.Height) / 13.913, 0);
            Buttons = new List<CostomAlphabetButton>();
            for (int i = 0; i < 26; i++)
            {
                if (i % 10 == 0)
                {
                    X = XX;
                    Y += factor;
                }
                CostomAlphabetButton cb = new CostomAlphabetButton(SmallerFont, new Point(X, Y), BtnSize);
                cb.Text = ((char)('A' + i)).ToString();
                Buttons.Add(cb);
                X += factor;
            }

            
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            if (!IsChanged && JokerChance != 0 && Random.Next(100) < JokerChance)
            {
                IsChanged = true;
                Form.JokerAnswer();
                return;
            }
            IsChanged = true;
            if (AnswerState == AnswerStates.NotAnswered)
            {
                foreach (CostomAlphabetButton btn in Buttons)
                    btn.Draw(g);

                if(Attempts <= AttemptsToClose)
                    g.DrawString(String.Format("Attempts: {0:00}", Attempts), LargerFont, TimeToCloseBrush, AttemptsRelativeLocation);
                else g.DrawString(String.Format("Attempts: {0:00}", Attempts), LargerFont, DefaultBrush, AttemptsRelativeLocation);
                g.DrawString(PresentedAnswer.ToString(), LargerFont, AnswerBrush, AnswerLocation);
            }
            else if (AnswerState == AnswerStates.Incorrect)
            {
                g.DrawString(PresentedAnswer.ToString(), LargerFont, DefaultBrush, AnsweredAnswerLocation);
            }
            else if (AnswerState == AnswerStates.Correct || AnswerState == AnswerStates.Devil)
            {
                g.DrawString(TheCorrectAnswer, LargerFont, AnsweredCorrectBrush, AnsweredAnswerLocation);
            }
            else if (AnswerState == AnswerStates.TimeElapsed)
            {
                g.DrawString(PresentedAnswer.ToString(), LargerFont, DefaultBrush, AnsweredAnswerLocation);
            }
        }

        protected void AddChar(char c)
        {
            if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) || AnswerState != AnswerStates.NotAnswered)
                return;
            if (Set.Contains(c))
                return;
            Set.Add(c);
            int curr = 0;
            int i = 0;
            String str = PresentedAnswer.ToString();
            foreach (char chr in Answer)
            {
                if (char.ToUpper(c).Equals(char.ToUpper(chr)) && str.ElementAt<Char>(2*i) == '_')
                {
                    PresentedAnswer.Insert(2 * i, c.ToString().ToUpper());
                    PresentedAnswer.Remove(2 * i + 1, 1);
                    curr++;
                }
                i++;
            }
            CountLetters += curr;
            Form.UpdateView();
            if (CountLetters == NumOfLetters)
            {
                if (DevilChance != 0 && Random.Next(100) < DevilChance)
                {
                    Form.DevilAnswer();
                    return;
                }
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
            bool changed = false;
            foreach (CostomAlphabetButton btn in Buttons)
            {
                changed = true;
                if (btn.Enabled && btn.Text.Equals(e.KeyData.ToString().ToUpper()))
                    btn.BackColor = Color.FromArgb(192, 192, 0);
            }
            if(changed)
                Form.UpdateView();
        }

        public override void KeyUp(System.Windows.Forms.KeyEventArgs e)
        {
            bool changed = false;
            foreach (CostomAlphabetButton btn in Buttons)
            {
                if (btn.Enabled && btn.Text.Equals(e.KeyData.ToString().ToUpper()))
                {
                    changed = true;
                    btn.Enabled = false;
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = SystemColors.InactiveCaptionText;
                }
            }
            if(changed)
                Form.UpdateView();
        }

        public override void MouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            if (MouseClicked)
                return;
            bool changed = false;
            foreach (CostomAlphabetButton btn in Buttons)
            {
                if (btn.Enabled && btn.IsIn(e.Location) && btn.BackColor != Color.FromArgb(229, 192, 21))
                {
                    Form.setCursor(Cursors.Hand);
                    btn.BackColor = Color.FromArgb(229, 192, 21);
                    changed = true;
                }
                else if (!btn.IsIn(e.Location) && btn.BackColor != Color.Transparent)
                {
                    btn.BackColor = Color.Transparent;
                    Form.setCursor(Cursors.Default);
                    changed = true;
                }
            }
            if(changed)
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

        public override void CorrectAnswer()
        {
            base.CorrectAnswer();
            Timer.Start();
        }

        public override void IncorrectAnswer()
        {
            base.IncorrectAnswer();
            Timer.Start();
        }

        public override void TimeElapsed()
        {
            base.TimeElapsed();
            Timer.Start();
        }

        public override void DevilAnswer()
        {
            base.DevilAnswer();
            Timer.Start();
        }

        public override void JokerAnswer()
        {
            base.JokerAnswer();
            Timer.Start();
        }
    }
}
