using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia_master
{
    public class Hard : Game<string, AlphabetAnswer>
    {
        public AssociationForm<AlphabetAnswer> form;

        public override bool showQ(Category<string, AlphabetAnswer> cat)
        {

            IQuestion<string, AlphabetAnswer> question = cat.getNextQuestion();
            AssociationForm<AlphabetAnswer> form = new AssociationForm<AlphabetAnswer>(cat, question);
            if (form.ShowDialog() == DialogResult.OK)
                return true;


            return false;
        }
    }

}
