using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Trivia_master
{
    public abstract class MediumQuestionPainter
    {
        protected Size Size { get; set; }
        protected Point Location { get; set; }
        public IUpdatableView Form { get; set; }
        public Font Font { get; set; }
        public abstract void Draw(Graphics g);
        public virtual void KeyPress(KeyPressEventArgs e) { }
        public virtual void KeyDown(KeyEventArgs e) { }
        public virtual void KeyUp(KeyEventArgs e) { }
        public virtual void MouseUp(MouseEventArgs e) { }
        public virtual void MouseDown(MouseEventArgs e) { }
        public virtual void MouseMove(MouseEventArgs e) { }
        public virtual void Reset()
        {
            Size = Form.getSize();
            if (Size.Width > Size.Height)
            {
                Location = new Point(Size.Width / 2 - Size.Height / 2, 0);
            }
            else Location = new Point(0, Size.Height / 2 - Size.Width / 2);
        }
    }
}
