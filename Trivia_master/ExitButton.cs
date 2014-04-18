using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Trivia_master.Properties;

namespace Trivia_master
{
    class ExitButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Brushes.Transparent, this.ClientRectangle);
            e.Graphics.DrawImage(Resources.exitButton, 0, 0);
        }
    }
}
