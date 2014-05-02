using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    class FormPainter : MediumAnswerPainter
    {
        List<MediumAnswerPainter> objectPaintList;
        public int AnswerType { get; set; }
        public AlphabetAnswer Answer { get; set; }
        //2- Correct, 1 - False, 3 - TimeElapsed
        public FormPainter()
            : base()
        {
            objectPaintList = new List<MediumAnswerPainter>();
           
            AnswerType=-1;

        }
        public override void KeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            foreach(MediumAnswerPainter map in objectPaintList)
            {
                map.KeyDown(e);
            }
        }
        public override void KeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            foreach (MediumAnswerPainter map in objectPaintList)
            {
                map.KeyPress(e);
            }
        }
        public override void KeyUp(System.Windows.Forms.KeyEventArgs e)
        {
            foreach (MediumAnswerPainter map in objectPaintList)
            {
                map.KeyUp(e);
            }
        }
        public override void MouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            foreach (MediumAnswerPainter map in objectPaintList)
            {
                map.MouseDown(e);
            }
        }
        public override void MouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            foreach (MediumAnswerPainter map in objectPaintList)
            {
                map.MouseMove(e);
            }
        }
        public override void MouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            foreach (MediumAnswerPainter map in objectPaintList)
            {
                map.MouseUp(e);
            }
        }
        public override void Draw(System.Drawing.Graphics g)
        {
            if (AnswerType == -1)
            {
                foreach (MediumAnswerPainter map in objectPaintList)
                {
                    map.Draw(g);
                }
            }
            else
            {
                Answer.Answered = AnswerType;
                Answer.Draw(g);
            }
        }
        public override void Reset()
        {
            foreach (MediumAnswerPainter map in objectPaintList)
            {
                map.Reset();
            }
        }
        public void correctAnswer()
        {
            AnswerType = 2;
            Form.Answered();
        }
        public void falseAnswer()
        {
            AnswerType = 1;
            Form.Answered();
        }
        public void timeElapsed()
        {
            AnswerType = 3;
            Form.Answered();
        }
    }
}
