using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Trivia_master
{
    class AlphabetQuestion : MediumQuestionPainter
    {
        private String question;
        private StringBuilder sb;

        public AlphabetQuestion()
        {
            StringBuilder sb = new StringBuilder();
        }

        public AlphabetQuestion(String q)
        {
            question = q;
            sb = new StringBuilder();
        }

        public override void Reset()
        {
            base.Reset();
            int pom = (int)(Math.Min(Size.Width, Size.Height) / 14);
            StringBuilder sb = new StringBuilder(question);
            for (int i = question.Length - 1; i > 0; i--)
            {
                if (i % pom == 0)
                {
                    while (!question.ElementAt(i).ToString().Equals(" ") || i == 0)
                    {
                        i--;
                    }
                    sb.Insert(i, "\n");
                    sb.Remove(i + 1, 1);
                }
            }
            this.sb = sb;
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            g.DrawString(sb.ToString(), Font, new SolidBrush(Color.FromArgb(217, 0, 0)), new Point(Location.X + (Math.Min(Size.Width, Size.Height) / 5), Location.Y + (Math.Min(Size.Width, Size.Height) * 2 / 5)));
        }
    }
}
