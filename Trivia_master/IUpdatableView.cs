using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Trivia_master
{
    public interface IUpdatableView
    {
        void UpdateView();
        void CorrectAnswer();
        void IncorrectAnswer();
        Size getSize();
        void TimeElapsed();
        void Answered();
        void setCursor(Cursor crs);
    }
}
