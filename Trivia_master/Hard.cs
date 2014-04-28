using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia_master
{
    public class Hard : Game<string, AlphabetAnswer>
    {
        public AssociationForm form;

        public override bool showQ(Category<string, AlphabetAnswer> cat)
        {

            IQuestion<string, AlphabetAnswer> question = cat.getNextQuestion();
            AssociationForm form = new AssociationForm(cat, question);
            if (form.ShowDialog() == DialogResult.OK)
                return true;


            return false;
        }
    }

}
