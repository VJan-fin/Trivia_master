using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Trivia_master
{
    class PuzzlePainter
    {
        public Image PuzzlePiece { get; set; }
        public Point StartPos { get; set; }
        public float CurrPosX { get; set; }
        public float CurrPosY { get; set; }
        public Point FinalPos { get; set; }
        public static Size Size;
        public int Step { get; set; }

        private float deltaX;
        private float deltaY;

        public PuzzlePainter(Image img, Point start, Point end)
        {
            this.PuzzlePiece = img;
            this.StartPos = new Point(start.X, start.Y);
            this.CurrPosX = start.X;
            this.CurrPosY = start.Y;
            this.FinalPos = new Point(end.X, end.Y);
            this.Step = 100;
            this.deltaX = (float)(this.FinalPos.X - this.StartPos.X) / this.Step;
            this.deltaY = (float)(this.FinalPos.Y - this.StartPos.Y) / this.Step;
        }

        public void draw(Graphics g)
        {
            Point tmpPoint = new Point((int)this.CurrPosX, (int)this.CurrPosY);
            g.DrawImage(this.PuzzlePiece, new Rectangle(tmpPoint, PuzzlePainter.Size));
        }

        public void move()
        {
            if (this.Step != 0)
            {
                this.CurrPosX += deltaX;
                this.CurrPosY += deltaY;
                this.Step--;
            }
            else
            {
                this.CurrPosX = this.FinalPos.X;
                this.CurrPosY = this.FinalPos.Y;
            }
            
        }
    }
}
