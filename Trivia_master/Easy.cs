using System.Collections.Generic;
using System.Windows.Forms;

namespace Trivia_master
{
    public class Easy : Game<string,string>
    {
        public Form easyForma; // treba da se stavi konkretnata forma koja se odnesuva na Easy

        public override void createState()
        {
            //this.state = new State<string, string>(this);
        }

        public void doldeliPrasanje()
        {
            
        }
    }
}
