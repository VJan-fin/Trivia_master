using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    /// <summary>
    /// Document class that serves other documents
    /// All methods are just calls to other documents' methods
    /// </summary>
    public class FormPainter : MediumAnswerPainter
    {
        List<MediumAnswerPainter> objectPaintList;

        public FormPainter(MediumAnswerPainter Answer)
            : base()
        {
            objectPaintList = new List<MediumAnswerPainter>();
            objectPaintList.Add(Answer);

        }
        public void AddComponent(MediumAnswerPainter Component)
        {

            objectPaintList.Add(Component);
        }

        public override void KeyDown(System.Windows.Forms.KeyEventArgs e)
        {  
            foreach(MediumAnswerPainter map in objectPaintList)
                map.KeyDown(e);
        }

        public override void KeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            foreach (MediumAnswerPainter map in objectPaintList)
                map.KeyPress(e);
        }

        public override void KeyUp(System.Windows.Forms.KeyEventArgs e)
        {
            foreach (MediumAnswerPainter map in objectPaintList)
                map.KeyUp(e);
        }

        public override void MouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            foreach (MediumAnswerPainter map in objectPaintList)
                map.MouseDown(e);
        }

        public override void MouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            foreach (MediumAnswerPainter map in objectPaintList)
                map.MouseMove(e);
        }

        public override void MouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            foreach (MediumAnswerPainter map in objectPaintList)
                map.MouseUp(e);
        }

        public override void Draw(System.Drawing.Graphics g)
        {
            foreach (MediumAnswerPainter map in objectPaintList)
                map.Draw(g);
        }

        public override void Reset()
        {
            foreach (MediumAnswerPainter map in objectPaintList)
            {
                map.Form = Form;
                map.Reset();
            }
        }

        public override void CorrectAnswer()
        {
            foreach (MediumAnswerPainter map in objectPaintList)
                map.CorrectAnswer();
            Form.Answered();
        }

        public override void IncorrectAnswer()
        {
            foreach (MediumAnswerPainter map in objectPaintList)
                map.IncorrectAnswer();
            Form.Answered();
        }

        public override void TimeElapsed()
        {
            foreach (MediumAnswerPainter map in objectPaintList)
                map.TimeElapsed();
            Form.Answered();
        }

        public override void DevilAnswer()
        {
            foreach (MediumAnswerPainter map in objectPaintList)
                map.DevilAnswer();
            Form.Answered();
        }

        public override void JokerAnswer()
        {
            foreach (MediumAnswerPainter map in objectPaintList)
                map.JokerAnswer();
            Form.Answered();
        }    
    }
}
