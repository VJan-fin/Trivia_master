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

            IQuestion<string, string> question = cat.getNextQuestion();
            AssociationForm form = new AssociationForm(question,cat);
            if (form.ShowDialog() == DialogResult.Yes)
                return true;


            return false;
        }
    }

}
