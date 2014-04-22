using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Trivia_master.Properties;

namespace Trivia_master
{
    class TriviaLabel : Label
    {
        public TriviaLabel() : base ()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(217, 0, 0);
        }
    }
}
