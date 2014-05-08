using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia_master
{
    public class Medium : Game<MediumQuestionPainter,MediumAnswerPainter>
    {
        public AlphabetForm mediumForma;

        public override bool showQ(Category<MediumQuestionPainter, MediumAnswerPainter> cat)
        {
            IQuestion<MediumQuestionPainter, MediumAnswerPainter> pom = cat.getNextQuestion();
            mediumForma = new AlphabetForm(cat, pom);
            if (mediumForma.ShowDialog() == DialogResult.OK)
                return true;
            else return false;
        }
    }
}

