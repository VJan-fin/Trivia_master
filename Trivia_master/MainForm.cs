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
    public partial class MainForm<T, U> : Form1
    {
        State<T, U> state;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(State<T, U> state)
        {
            InitializeComponent();
            this.state = state;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            alphabetButton1.Text = state.Category[0].ToString();
            
        }

    }
}
