using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Trivia_master
{
    public abstract class MediumQuestionPainter
    {
        public Font Font { get; set; }
        public abstract void Draw(Graphics g);
    }
}
