using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Trivia_master
{
    public class TriviaButton : Button
    {
        public TriviaButton() : base()
        {
            ForeColor = Color.FromArgb(217, 0, 0);
            BackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = Color.White;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 192, 21);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 0);
            BackgroundImage = null;
        }
    }
}
