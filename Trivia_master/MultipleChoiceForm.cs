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
        private IQuestion<string, string> question;
        private Category<string, string> cat;
        private string correctAnswer;

        public MultipleChoiceForm()
        {
            InitializeComponent();
        }

        public MultipleChoiceForm(Category<string, string> cat, IQuestion<string, string> question)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.cat = cat;
            this.question = question;
            this.labelCategory.Text = this.cat.CategoryName;
            this.labelQ.Text = question.getQuestion()[0];
            this.labelA1.Text = question.getAnswers()[0];
            this.labelA2.Text = this.question.getAnswers()[1];
            this.labelA3.Text = this.question.getAnswers()[2];
            this.labelA4.Text = this.question.getAnswers()[3];
            this.correctAnswer = this.question.getCorrectAnswer()[0];
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
