using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia_master
{
    public partial class MultipleChoiceForm : Form1
    {
        public MultipleChoiceForm()
        {
            InitializeComponent();
        }

        private void labelA1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            //(sender as Label).BackColor = Color.FromArgb(32, 73, 128) - light blue
            (sender as Label).BackColor = Color.FromArgb(229, 192, 21);
        }

        private void labelA1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            // this colour is default
            (sender as Label).BackColor = Color.FromArgb(4, 26, 65);
        }
    }
}
