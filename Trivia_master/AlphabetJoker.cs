using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trivia_master.Properties;
using System.Drawing;

namespace Trivia_master
{
    class AlphabetJoker : MediumAnswerPainter

    {
        public AlphabetJoker()
            : base()
        {
            PictureSize = new Size(300, 300);
        }

        public override void Reset()
        {
            base.Reset();
            PictureLocation = new Point(Location.X + (Math.Min(Size.Width, Size.Height) * 13 / 40), Location.Y + (Math.Min(Size.Width, Size.Height) * 1 / 3));
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            if(Answered != 0)
                g.DrawImage(Resources.Joker1, new Rectangle(PictureLocation, PictureSize));
            if (Answered == 0)
            {
                Answered = 2;
                Form.Answered();
            }
        }
    }
}
