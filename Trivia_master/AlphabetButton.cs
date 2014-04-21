using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Trivia_master
{
    class AlphabetButton : TriviaButton
    {
        protected override void OnClick(EventArgs e)
        {
            Enabled = false;
            BackColor = SystemColors.InactiveCaption;
            base.OnClick(e);
        }

        public void checkCharacter(char c)
        {
            if (c.ToString().ToUpper().Equals(Text))
            {   
                Enabled = false;
                BackColor = SystemColors.InactiveCaption;
            }
        }

        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs kevent)
        {
            bck = BackgroundImage;
            Cursor = Cursors.Hand;
            BackColor = Color.FromArgb(229, 192, 21);
            Bitmap bm = new Bitmap(BackgroundImage);
            Graphics g = Graphics.FromImage(bm);
            g.FillRectangle(new SolidBrush(Color.FromArgb(229, 192, 21)), ClientRectangle);
            BackgroundImage = bm;
            base.OnKeyDown(kevent);
        }
    }
}
