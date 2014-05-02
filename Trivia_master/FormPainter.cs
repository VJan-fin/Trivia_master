using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
   public class FormPainter : MediumAnswerPainter
    {
        List<MediumAnswerPainter> objectPaintList;
        public int AnswerType { get; set; }
        public AlphabetAnswer Answer { get; set; }
        public bool Changed { get; set; }
        //2- Correct, 1 - False, 3 - TimeElapsed
        public FormPainter(AlphabetAnswer aa)
            : base()
        {
            objectPaintList = new List<MediumAnswerPainter>();
            Answer = aa;
            objectPaintList.Add(Answer);
            Changed = false;
            AnswerType=-1;

        }
        public void AddComponent(MediumAnswerPainter mp)
        {

            objectPaintList.Add(mp);
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
              //  Answer.Draw(g);
            }
            else
            {
                Answer.Answered = AnswerType;
                Answer.Draw(g);
            }
        }
        public override void Reset()
        {
            AnswerType = -1;
            Changed = false;
            foreach (MediumAnswerPainter map in objectPaintList)
            {
                map.Form = Form;
                map.Reset();
            }
        }
        public void correctAnswer()
        {
            if (!Changed)
            {
                Changed = true;
                AnswerType = 2;
                Answer.Answered = 2;
                Answer.Timer.Start();
                Form.Answered();
            }
        }
        public void falseAnswer()
        {
            if (!Changed)
            {
                Changed = true;
                AnswerType = 1;
                Answer.Answered = 1;
                Answer.Timer.Start();
                Form.Answered();
            }
        }
        public void timeElapsed()
        {
            if (!Changed)
            {
                Changed = true;
                AnswerType = 3;
                Answer.Answered = 3;
                Answer.Timer.Start();
                Form.Answered();
            }
        }
    }
}
