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
        private List<QuestionBox> Boxes;

        public MainForm()
        {
            InitializeComponent();
            this.Boxes = new List<QuestionBox>();
        }

        public MainForm(State<T, U> state)
        {
            InitializeComponent();
            this.state = state;
            this.Boxes = new List<QuestionBox>();
            this.Boxes.Add(this.QBox1);
            this.Boxes.Add(this.QBox2);
            this.Boxes.Add(this.QBox3);
            this.Boxes.Add(this.QBox4);
            this.Boxes.Add(this.QBox5);
            this.Boxes.Add(this.QBox6);
            this.Boxes.Add(this.QBox7);
            this.Boxes.Add(this.QBox8);
            this.Boxes.Add(this.QBox9);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var item in this.Boxes)
            {
                item.Text = state.Category[i++].ToString();
            }        
        }

        private void alphabetButton1_Click(object sender, EventArgs e)
        {
            int ind = 0;
            foreach (var item in this.Boxes)
            {
                if (item.Text == (sender as QuestionBox).Text)
                    break;
                ind++;
            }
            (sender as QuestionBox).Visible = !state.ShowQ(state.Category[ind]);
        }
    }
}
