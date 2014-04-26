using System.Collections.Generic;
using System.Windows.Forms;

namespace Trivia_master
{
    public class Easy : Game<string,string>
    {
        public MultipleChoiceForm easyForm;

        public override bool showQ(Category<string, string> cat)
        {
            IQuestion<string, string> question = cat.getNextQuestion();
            MultipleChoiceForm mcf = new MultipleChoiceForm(cat, question);
            DialogResult res = mcf.ShowDialog();

            if (res == DialogResult.Yes)
                return true;

            return false;
        }
    }
}
