using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    interface IUpdatableView
    {
        void UpdateView();
        void CorrectAnswer();
        void IncorrectAnswer();
    }
}
