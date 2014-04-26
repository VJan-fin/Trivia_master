using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia_master
{
    public class Hard : Game<string, string>
    {
        public AssociationForm form; // treba da se stavi konkretnata forma koja se odnesuva naHard

        public override bool showQ(Category<string, string> cat)
        {
             IQuestion<string,string> question = cat.getNextQuestion();
             AssociationForm form = new AssociationForm(question);
             form.ShowDialog();

             return false;
        }
    }

}
