using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Trivia_master
{
    public abstract class MediumAnswerPainter
    {
        protected enum AnswerStates
        {
            NotAnswered,
            Correct,
            Incorrect,
            TimeElapsed,
            Joker,
            Devil
        };

        protected AnswerStates AnswerState { get; set; }
        protected Point FormLocation { get; set; }
        protected Size FormSize { get; set; }
        protected Brush DefaultBrush { get; set; }
        protected Brush TimeToCloseBrush { get; set; }
        protected Brush AnsweredCorrectBrush { get; set; }
        public Font SmallerFont { get; set; }
        public Font LargerFont { get; set; }
        public Form1 Form { get; set; }
        protected bool MouseClicked { get; set; }

        

        protected Point AnsweredAnswerLocation { get; set; }

        /// <summary>
        /// Form Events
        /// </summary>
        /// <param name="e"></param>
        public virtual void KeyPress(KeyPressEventArgs e) { }
        public virtual void KeyDown(KeyEventArgs e) { }
        public virtual void KeyUp(KeyEventArgs e) { }
        public virtual void MouseUp(MouseEventArgs e) { }
        public virtual void MouseDown(MouseEventArgs e) { }
        public virtual void MouseMove(MouseEventArgs e) { }

        /// <summary>
        /// Draws a component
        /// </summary>
        /// <param name="g"></param>
        public abstract void Draw(Graphics g);
        
        /// <summary>
        /// Changes AnswerType to Correct
        /// needed to change behavior
        /// </summary>
        public virtual void CorrectAnswer() { AnswerState = AnswerStates.Correct; }

        /// <summary>
        /// Changes AnswerType to Incorrect
        /// needed to change behavior
        /// </summary>
        public virtual void IncorrectAnswer() { AnswerState = AnswerStates.Incorrect; }

        /// <summary>
        /// Changes AnswerType to TimeElapsed
        /// needed to change behavior
        /// </summary>
        public virtual void TimeElapsed() { AnswerState = AnswerStates.TimeElapsed; }


        public MediumAnswerPainter()
        {
            AnswerState = AnswerStates.NotAnswered;
            SmallerFont = new Font("Forte", 15);
            LargerFont = new Font("Forte", 24, FontStyle.Bold);
            DefaultBrush = new SolidBrush(Color.FromArgb(217, 0, 0));
            TimeToCloseBrush = new SolidBrush(Color.FromArgb(229, 192, 21));
            AnsweredCorrectBrush = new SolidBrush(Color.FromArgb(0, 146, 17));
        }

        public virtual void DevilAnswer()
        {
            AnswerState = AnswerStates.Devil;
        }

        public virtual void JokerAnswer()
        {
            AnswerState = AnswerStates.Joker;
        }

        /// <summary>
        /// Resets current state of object according to Form that represents it.
        /// </summary>
        public virtual void Reset()
        {
            AnswerState = AnswerStates.NotAnswered;
            MouseClicked = false;
            FormSize = Form.getSize();
            if (FormSize.Width > FormSize.Height)
            {
                FormLocation = new Point(FormSize.Width / 2 - FormSize.Height / 2, 0);
            }
            else FormLocation = new Point(0, FormSize.Height / 2 - FormSize.Width / 2);
        }
    }
}
