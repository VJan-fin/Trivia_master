using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Trivia_master.Properties;

namespace Trivia_master
{
    class AlphabetAnswer : MediumAnswerPainter
    {
        protected String answer { get; set; }
        protected String CorrectAnswer { get; set; }
        protected Point AnswerLocation { get; set; }
        protected Brush AnswerBrush { get; set; }
        protected HashSet<Char> Set { get; set; }
        protected Color AnswerColor { get; set; }
        protected StringBuilder sb;
        protected int count;
        protected int wrong;

        public AlphabetAnswer(String a, int time = 20) : base(time)
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
            AnswerLocation = new Point(Location.X + (Math.Min(Size.Width, Size.Height) * 4 / 19), Location.Y + (Math.Min(Size.Width, Size.Height) * 5 / 8));
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            if (Answered == 0)
            {
                base.Draw(g);
                g.DrawString(sb.ToString(), Font, AnswerBrush, AnswerLocation);
            }
            else if (Answered == 1)
            {
                g.DrawImage(Resources.Wrong_answer1, new Rectangle(PictureLocation, PictureSize));
                g.DrawString(CorrectAnswer, Font, DefaultBrush, AnswerLocation);
            }
            else if (Answered == 2)
            {
                g.DrawImage(Resources.Correct2, new Rectangle(PictureLocation, PictureSize));
                g.DrawString(CorrectAnswer, Font, AnsweredCorrect, AnswerLocation);
            }
            else if (Answered == 3)
            {
                g.DrawImage(Resources.Timeout, new Rectangle(PictureLocation, PictureSize));
                g.DrawString(CorrectAnswer, Font, DefaultBrush, AnswerLocation);
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
                Answered = 2;
                Form.Answered();
            }
            if (curr == 0)
                wrong++;
            if (wrong == 5)
            {
                Answered = 1;
                Form.Answered();
            }
                
        }

        public override void KeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            AddChar(e.KeyChar);
        }
    }
}
