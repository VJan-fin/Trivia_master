using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Trivia_master.Properties;

namespace Trivia_master
{
    class AnsweredPicturePainter : MediumAnswerPainter
    {
        protected Bitmap CorrectAnswerImage { get; set; }
        protected Bitmap IncorrectIncoImage { get; set; }
        protected Bitmap TimeElapsedImage { get; set; }
        protected Bitmap Joker { get; set; }
        protected Bitmap Devil { get; set; }
        protected Point PictureLocation { get; set; }
        protected Size PictureSize { get; set; }
        protected Point JokerPictureLocation { get; set; }
        protected Size JokerPictureSize { get; set; }

        public AnsweredPicturePainter() : base()
        {
            CorrectAnswerImage = Resources.Correct2;
            IncorrectIncoImage = Resources.Wrong_answer1;
            TimeElapsedImage = Resources.Timeout;
            Joker = Resources.Joker1;
            Devil = Resources.Devil1;
        }

        public override void Reset()
        {
            base.Reset();
            int size = (int)(FormSize.Width * 0.411);
            PictureSize = new Size(size, size);
            PictureLocation = new Point(FormLocation.X + (Math.Min(FormSize.Width, FormSize.Height) * 7 / 20), FormLocation.Y + (Math.Min(FormSize.Width, FormSize.Height) * 4 / 15));

            JokerPictureSize = new Size(size, size);
            JokerPictureLocation = new Point(FormLocation.X + (Math.Min(FormSize.Width, FormSize.Height) * 13 / 40), FormLocation.Y + (Math.Min(FormSize.Width, FormSize.Height) * 1 / 3));
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            if(AnswerState == AnswerStates.Joker)
                g.DrawImage(Joker, new Rectangle(JokerPictureLocation, JokerPictureSize));
            else if(AnswerState == AnswerStates.NotAnswered)
                return;
            else if(AnswerState == AnswerStates.Incorrect)
                g.DrawImage(IncorrectIncoImage, new Rectangle(PictureLocation, PictureSize));
            else if(AnswerState == AnswerStates.Correct)
                g.DrawImage(CorrectAnswerImage, new Rectangle(PictureLocation, PictureSize));
            else if(AnswerState == AnswerStates.TimeElapsed)
                g.DrawImage(TimeElapsedImage, new Rectangle(PictureLocation, PictureSize));
            else if (AnswerState == AnswerStates.Devil)
                g.DrawImage(Devil, new Rectangle(PictureLocation, PictureSize));
        }
    }
}
