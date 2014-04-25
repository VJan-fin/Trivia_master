using System.Collections.Generic;
using System.Windows.Forms;

namespace Trivia_master
{
    public class Easy : Game<string,string>
    {
        public MultipleChoiceForm easyForm; // treba da se stavi konkretnata forma koja se odnesuva na Easy

        public override bool showQ(Category<string, string> cat)
        {
            IQuestion<string, string> question = cat.getNextQuestion();
            //MessageBox.Show(cat.ToString());
            MultipleChoiceForm mcf = new MultipleChoiceForm(cat, question);
            mcf.ShowDialog();

            return true;
        }
    }
}
