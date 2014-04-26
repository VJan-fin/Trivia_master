using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Trivia_master
{
    class AlphabetQuestion : MediumQuestionPainter
    {
        String question;

        public AlphabetQuestion(String q)
        {
            StringBuilder sb = new StringBuilder(q);
            for (int i = q.Length - 1; i > 0; i--)
            {
                if (i % 45 == 0)
                {
                    while (!q.ElementAt(i).ToString().Equals(" ") || i == 0)
                    {
                        i--;
                    }
                    sb.Insert(i, "\n");
                    sb.Remove(i + 1, 1);
                }
            }
            question = sb.ToString();
        }
        public override void Draw(System.Drawing.Graphics g)
        {
            g.DrawString(question, Font, new SolidBrush(Color.FromArgb(217, 0, 0)), new Point(200, 230));
        }
    }
}
