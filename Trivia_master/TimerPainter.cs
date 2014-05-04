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
        protected int TimeToClose { get; set; }
        protected int RemainingTime { get; set; }
        protected int Time { get; set; }
        protected Point TimerLocation { get; set; }
        public Point Location { get; set; }

        public TimerPainter(int time = 20) : base()
        {
            this.Time = time;
            Location = new Point(80, 28);
            RemainingTime = Time;
            TimeToClose = (int)(Time * 15 / 100);
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += new System.EventHandler(this.TimerTick);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (RemainingTime != 0)
            {
                RemainingTime--;
                Form.UpdateView();
            }
            else
            {
                Timer.Stop();
                Form.TimeElapsed();
            }
        }

        public override void Reset()
        {
            FormSize = Form.getSize();
            if (FormSize.Width > FormSize.Height)
            {
                FormLocation = new Point(FormSize.Width / 2 - FormSize.Height / 2, 0);
            }
            else FormLocation = new Point(0, FormSize.Height / 2 - FormSize.Width / 2);
            RemainingTime = Time;
            TimerLocation = new Point(FormLocation.X + (int)(Math.Min(FormSize.Width, FormSize.Height) * Location.X/100), FormLocation.Y + (int)(Math.Min(FormSize.Width, FormSize.Height) * Location.Y/100));
            Timer.Start();
        }

        public override void Draw(Graphics g)
        {
            if (AnswerState == AnswerStates.NotAnswered)
            {
                if (!(RemainingTime <= TimeToClose))
                    g.DrawString(String.Format("{0,2:D2}:{1,2:D2}", RemainingTime / 60, RemainingTime % 60), LargerFont, DefaultBrush, TimerLocation);
                else g.DrawString(String.Format("{0,2:D2}:{1,2:D2}", RemainingTime / 60, RemainingTime % 60), LargerFont, TimeToCloseBrush, TimerLocation);
            }
        }

        public override void CorrectAnswer()
        {
            base.CorrectAnswer();
            Timer.Stop();
        }

        public override void IncorrectAnswer()
        {
            base.IncorrectAnswer();
            Timer.Stop();
        }

        public override void TimeElapsed()
        {
            base.TimeElapsed();
            Timer.Stop();
        }

        public override void JokerAnswer()
        {
            base.JokerAnswer();
            Timer.Stop();
        }

        public override void DevilAnswer()
        {
            base.DevilAnswer();
            Timer.Stop();
        }
    }
}
