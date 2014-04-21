using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Trivia_master.Properties;

namespace Trivia_master
{
    class TriviaLabel : Label
    {
        Point prev = new Point(0, 0);

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Location.X != prev.X || this.Location.Y != prev.Y)
            {
                Bitmap background = new Bitmap(Parent.BackgroundImage);
                Bitmap bck = new Bitmap(background, Math.Min(Parent.Width, Parent.Height), Math.Min(Parent.Width, Parent.Height));
                Bitmap cropped;
                if (Parent.Width > Parent.Height)
                {
                    int pom = (Parent.Width - Parent.Height) / 2;
                    cropped = bck.Clone(new Rectangle(new Point(Location.X - pom, Location.Y), this.Size), bck.PixelFormat);
                }
                else
                {
                    int pom = (Parent.Height - Parent.Width) / 2;
                    cropped = bck.Clone(new Rectangle(new Point(Location.X, Location.Y - pom), this.Size), bck.PixelFormat);
                }
                this.BackgroundImage = cropped;
                prev = this.Location;
            }
            base.OnPaint(e);
        }
    }
}
