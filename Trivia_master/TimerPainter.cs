using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Trivia_master
{
    class TimerPainter : MediumAnswerPainter
    {
        protected Timer Timer { get; set; }
        protected int RemainingTime { get; set; }
        protected int Time { get; set; }
        protected Point TimerLocation { get; set; }
        protected Font Font { get; set; }
        protected Brush TimerBrush { get; set; }
        protected Brush TimeToCloseBrush { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public TimerPainter(int time = 20)
        {
            this.Time = time;
            X = 80;
            Y = 27.5;
            RemainingTime = Time;
            Font = new Font("Forte", 24, FontStyle.Bold);
            TimerBrush = new SolidBrush(Color.FromArgb(217, 0, 0));
            TimeToCloseBrush = new SolidBrush(Color.FromArgb(229, 192, 21));
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += new System.EventHandler(this.Up);
        }

        public void Up(object sender, EventArgs e)
        {
            if (RemainingTime != 0)
            {
                RemainingTime--;
                Form.UpdateView();
            }
            else Form.TimeElapsed();
        }

        public override void Reset()
        {
            Size = Form.getSize();
            if (Size.Width > Size.Height)
            {
                Location = new Point(Size.Width / 2 - Size.Height / 2, 0);
            }
            else Location = new Point(0, Size.Height / 2 - Size.Width / 2);
            RemainingTime = Time;
            TimerLocation = new Point(Location.X + (int)(Math.Min(Size.Width, Size.Height) * X/100), Location.Y + (int)(Math.Min(Size.Width, Size.Height) * Y/100));
            Timer.Start();
        }


        public override void Draw(Graphics g)
        {
            if (!(RemainingTime <= TimeToClose))
                g.DrawString(String.Format("{0,2:D2}:{1,2:D2}", RemainingTime / 60, RemainingTime % 60), Font, DefaultBrush, TimerLocation);
            else g.DrawString(String.Format("{0,2:D2}:{1,2:D2}", RemainingTime / 60, RemainingTime % 60), Font, TimeToCloseBrush, TimerLocation);
        }

    }
}
