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
        IQuestion<Image,FormPainter> question;
        Category<T, U> category;
        protected Image Question { get; set; }
        protected int Answere { get; set; }

        public MainForm(Category<T, U> c, IQuestion<Image, FormPainter> q)
        {
            InitializeComponent();
            question = q;
            Question = q.getQuestion()[0];
            this.category = c;
            Answere = 0;
            DoubleBuffered = true;
            Answer = q.getCorrectAnswer()[0];
            Answer.Form = this; 
            Answer.Reset();
            pictureBox2.Image = Question;
            UpdateView();
        }

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
            question = state.Question;
            Question = question.getQuestion()[0];
            Answere = 0;
            DoubleBuffered = true;
            Answer = question.getCorrectAnswer()[0];
            Answer.Form = this;
            Answer.Reset();
            pictureBox2.Image = Question;
            Answer.Reset();
            UpdateView();
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
            this.Focus();
            foreach (var item in this.Boxes)
            {
                if (item.Text == (sender as QuestionBox).Text)
                    break;
                ind++;
            }
            if (state.ShowQ(state.Category[ind]) == true)
            {
                (sender as QuestionBox).Visible = false;
                this.Focus();
            }
            else
            {
                (sender as QuestionBox).Visible = false;
                this.Focus();
                (sender as QuestionBox).Visible = true;
            }
        }

        private void Draw(Graphics g)
        {
            Answer.Draw(g);
        }

        private void AlphabetForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Answer.KeyPress(e);
        }

        private void AlphabetForm_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        private void AlphabetForm_KeyDown(object sender, KeyEventArgs e)
        {
            Answer.KeyDown(e);
        }

        private void AlphabetForm_KeyUp(object sender, KeyEventArgs e)
        {
            Answer.KeyUp(e);
        }

        public override void UpdateView()
        {
            Invalidate();
        }

        private void AlphabetForm_MouseDown(object sender, MouseEventArgs e)
        {
            Answer.MouseDown(e);
        }

        private void AlphabetForm_MouseUp(object sender, MouseEventArgs e)
        {
            Answer.MouseUp(e);
        }

        private void AlphabetForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Opacity < 0.9)
                return;
            Answer.MouseMove(e);
        }

        public override Size getSize()
        {
            return Size;
        }

        public override void Answered()
        {
            foreach (QuestionBox box in Boxes)
                box.Visible = false;
            Answere = 1;
            UpdateView();
        }

    }
}
