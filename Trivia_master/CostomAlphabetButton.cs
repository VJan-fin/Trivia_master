using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Trivia_master
{
    public class CostomAlphabetButton
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Font Font { get; set; }
        public String Text { get; set; }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public bool Enabled { get; set; }
        public Rectangle Rectangle { get; set; }
        public Pen Pen { get; set; }
        public Point TextLocation { get; set; }
        public Brush BackGround { get; set; }
        public Brush Fore { get; set; }

        public CostomAlphabetButton(Font fnt, Point location, Size size)
        {
            Font = fnt;
            Location = location;
            Size = size;
            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(217, 0, 0);
            Text = "";
            BackGround = new SolidBrush(BackColor);
            Rectangle = new Rectangle(Location, Size);
            Pen = new Pen(new SolidBrush(Color.White));
            TextLocation = new Point((int)(Math.Round(Location.X + Size.Width / 2.0 - Font.Size*2/3, 0)), (int)(Math.Round(Location.Y + Size.Height / 2.0 - Font.Size*2/3 , 0)));
            Fore = new SolidBrush(ForeColor);
            Enabled = true;

        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(BackColor), Rectangle);
            g.DrawRectangle(Pen, Rectangle);
            g.DrawString(Text, Font, new SolidBrush(ForeColor), TextLocation);
        }

        public bool IsIn(Point pt)
        {
            if(pt.X >= Location.X && pt.X <= Location.X + Size.Width && pt.Y >= Location.Y && pt.Y <= Location.Y + Size.Height)
                return true;
            return false;
        }
    }
}
