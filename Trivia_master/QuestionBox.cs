using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    public partial class QuestionBox : AlphabetButton
    {
        public QuestionBox() : base()
        {
            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Enabled = true;
        }
    }
}
