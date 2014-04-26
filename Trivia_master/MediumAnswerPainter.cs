using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Trivia_master
{
    public abstract class MediumAnswerPainter
    {
        public Font Font { get; set; }
        public abstract void Draw(Graphics g);

        public virtual bool AddChar(char c)
        {
            return false;
        }

        public virtual bool IsCorrect()
        {
            return false;
        }

        public virtual void reset()
        {
        }
    }
}
