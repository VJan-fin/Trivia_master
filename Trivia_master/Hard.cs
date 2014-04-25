using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia_master
{
    public class Hard : Game<string, string>
    {
        public Form easyForma; // treba da se stavi konkretnata forma koja se odnesuva na Easy

        public override bool showQ(Category<string, string> cat)
        {
            throw new NotImplementedException();
        }
    }

}
