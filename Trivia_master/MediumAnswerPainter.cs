﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Trivia_master
{
    public abstract class MediumAnswerPainter
    {
        protected Timer Timer { get; set; }
        protected int RemainingTime { get; set; }
        protected int Time { get; set; }
        protected int TimeToClose { get; set; }
        protected Point TimerLocation { get; set; }
        protected Size Size { get; set; }
        protected int Answered { get; set; }
        public Font AlphaFont { get; set; }
        protected Point Location { get; set; }
        protected bool MouseClicked { get; set; }
        protected Point PictureLocation { get; set; }
        protected Size PictureSize { get; set; }
        protected Brush DefaultBrush { get; set; }
        protected Brush TimeToCloseBrush { get; set; }
        protected Brush AnsweredCorrect { get; set; }
        protected Point AnsweredAnswerLocation { get; set; }
        public IUpdatableView Form { get; set; }
        public Font Font { get; set; }
        public int TimeToEnd { get; set; }
        public virtual void KeyPress(KeyPressEventArgs e) { }
        public virtual void KeyDown(KeyEventArgs e) { }
        public virtual void KeyUp(KeyEventArgs e) { }
        public virtual void MouseUp(MouseEventArgs e) { }
        public virtual void MouseDown(MouseEventArgs e) { }
        public virtual void MouseMove(MouseEventArgs e) { }
        public virtual void Draw(Graphics g)
        {
            if (!(RemainingTime <= TimeToClose))
                g.DrawString(String.Format("{0,2:D2}:{1,2:D2}", RemainingTime / 60, RemainingTime % 60), Font, DefaultBrush, TimerLocation);
            else g.DrawString(String.Format("{0,2:D2}:{1,2:D2}", RemainingTime / 60, RemainingTime % 60), Font, TimeToCloseBrush, TimerLocation);
        }

        public MediumAnswerPainter(int time = 20)
        {
            DefaultBrush = new SolidBrush(Color.FromArgb(217, 0, 0));
            TimeToCloseBrush = new SolidBrush(Color.FromArgb(229, 192, 21));
            Time = time;
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += new System.EventHandler(this.Up);
            AnsweredCorrect = new SolidBrush(Color.FromArgb(0, 146, 17));
            PictureSize = new Size(263, 263);
        }

        public void Up(object sender, EventArgs e)
        {
            if (RemainingTime == 0 && Answered == 0)
            {
                Answered = 3;
                Form.Answered();
            }
            else
            if (Answered == 0)
            {
                RemainingTime--;
                Form.UpdateView();
            }
            else
            if (TimeToEnd == 0)
            {
                Timer.Stop();
                if (Answered == 1)
                    Form.IncorrectAnswer();
                if (Answered == 2)
                    Form.CorrectAnswer();
                if (Answered == 3)
                    Form.TimeElapsed();
            }
            else
            {
                TimeToEnd--;
            }
            //Form.UpdateView();
        }

        public virtual void Reset()
        {
            MouseClicked = false;
            Size = Form.getSize();
            if (Size.Width > Size.Height)
            {
                Location = new Point(Size.Width / 2 - Size.Height / 2, 0);
            }
            else Location = new Point(0, Size.Height / 2 - Size.Width / 2);
            TimeToEnd = 3;
            PictureLocation = new Point(Location.X + (Math.Min(Size.Width, Size.Height) * 7 / 20), Location.Y + (Math.Min(Size.Width, Size.Height) * 4 / 15));
            RemainingTime = Time;
            Answered = 0;
            TimeToClose = (int)Math.Round(Time / 100.0 * 15, 0);
            TimerLocation = new Point(Location.X + (Math.Min(Size.Width, Size.Height) * 4 / 5), Location.Y + (Math.Min(Size.Width, Size.Height) * 11 / 40));
            Timer.Start();
        }
    }
}
