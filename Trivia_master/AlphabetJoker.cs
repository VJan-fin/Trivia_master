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
