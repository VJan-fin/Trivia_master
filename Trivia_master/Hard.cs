using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia_master
{
    public class Hard : Game<string, string>
    {
        public AssociationForm form;

        public override bool showQ(Category<string, string> cat)
        {
<<<<<<< HEAD
             IQuestion<string,string> question = cat.getNextQuestion();
             AssociationForm form = new AssociationForm(question,cat);
             form.ShowDialog();
=======
            IQuestion<string, string> question = cat.getNextQuestion();
            AssociationForm form = new AssociationForm(question);
            form.ShowDialog();
>>>>>>> 5262a978e5e0da414297ecb438880c23bae741ef

            return false;
        }
    }

}
