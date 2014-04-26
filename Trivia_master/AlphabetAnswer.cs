using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Trivia_master
{
    class AlphabetAnswer : MediumAnswerPainter
    {
        String answer;
        StringBuilder sb;
        int count;

        public AlphabetAnswer(String a)
        {
            answer = a;
            sb = new StringBuilder();
            reset();
        }

        public override void reset()
        {
            sb = new StringBuilder();
            for (int i = 0; i < answer.Length; i++)
            {
                sb.Append("_ ");
            }
            count = 0;
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            g.DrawString(sb.ToString(), Font, new SolidBrush(Color.White), new Point(157, 409));
        }

        public override bool AddChar(char c)
        {
            int curr = 0;
            int i = 0;
            foreach (char chr in answer)
            {
                if (char.ToUpper(c).Equals(char.ToUpper(chr)))
                {
                    sb.Insert(2 * i, c.ToString().ToUpper());
                    sb.Remove(2 * i + 1, 1);
                    curr++;
                }
                i++;
            }
            count += curr;
            if (curr == 0)
                return false;
            return true;
        }

        public override bool IsCorrect()
        {
            if (count == answer.Length) return true;
            return false;
        }
    }
}
