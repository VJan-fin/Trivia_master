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
        public void checkCharacter(char c)
        {
            if (c.ToString().ToUpper().Equals(Text))
            {   
                Enabled = false;
                //BackColor = SystemColors.InactiveCaption;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Enabled = false;
        }
    }
}
