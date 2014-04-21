using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Trivia_master
{
    class TriviaButton : Button
    {
        public Image bck;
        public Point prev = new Point(0, -1);
        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            prev = this.Location;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            bck = BackgroundImage;
            Cursor = Cursors.Hand;
            BackColor = Color.FromArgb(229, 192, 21);
            Bitmap bm = new Bitmap(BackgroundImage);
            Graphics g = Graphics.FromImage(bm);
            g.FillRectangle(new SolidBrush(Color.FromArgb(229, 192, 21)), ClientRectangle);
            BackgroundImage = bm;
            base.OnEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            BackgroundImage = bck;
            base.OnMouseLeave(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (prev.Y != -1 && (this.Location.X != prev.X || this.Location.Y != prev.Y))
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
                prev = new Point(0, -1);
            }
            base.OnPaint(e);
        }
    }
}
