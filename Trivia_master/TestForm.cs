﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia_master
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MultipleChoiceForm mcf = new MultipleChoiceForm();
            mcf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlphabetForm apf = new AlphabetForm();
            apf.ShowDialog();
        }
    }
}
