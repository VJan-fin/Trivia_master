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
    public partial class AssociationForm<U> : Form1
        where U : MediumAnswerPainter
    {

        IQuestion<string,U> question;
        Category<string, U> category;
        protected String Question { get; set; }
        protected U Answer { get; set; }
        protected int Answere { get; set; }

        public AssociationForm()
        {
            InitializeComponent();
        }

        public AssociationForm(Category<String, U> c, IQuestion<String, U> q)
        {
            InitializeComponent();
            question = q;
            this.category = c;
            Answere = 0;
            DoubleBuffered = true;
            Answer = q.getCorrectAnswer()[0];
            Answer.Form = this; 
            Answer.AlphaFont = button1.Font;
            Answer.Font = triviaLabel2.Font;
            Answer.Reset();
            UpdateView();
        }

        private void Draw(Graphics g)
        {
            if(Answere == 0)
                addAssociations(g);
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
            Invalidate(true);
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
            Answer.MouseMove(e);
        }

        public override Size getSize()
        {
            return Size;
        }

        public override void Answered()
        {
            Answere = 1;
            UpdateView();
        }

        private void addAssociations(Graphics gp)
        {
            Bitmap back = new Bitmap(this.BackgroundImage);
         
            int heightStart = 190, increment = 30, widthStart = 190, widthSize = 300, heightSize = 50;
            var g = Graphics.FromImage(back);
            SolidBrush sb = new SolidBrush(Color.Red);
            Font font = new Font("Forte", 15);

           g.DrawString("Category : "+category.CategoryName, font, sb, new Rectangle(widthStart, 135, widthSize, heightSize));
            for (int i = 0; i < 4; i++)
            {

                Rectangle rec1 = new Rectangle(widthStart, heightStart, widthSize, heightSize);

                g.DrawString((i + 1).ToString() + ". " + question.getQuestion()[i], font, sb, rec1);
                heightStart += increment;
            }
           
            /*int wordCount = question.getCorrectAnswer()[0].Count();
            StringBuilder strb = new StringBuilder();
            for (int i = 1; i <= wordCount; i++)
            {
                strb.Append("_");
                if (i != wordCount)
                  strb.Append(" ");
            }
            triviaLabel2.Text = strb.ToString();*/

            Graphics graph = CreateGraphics();
            /*  Rectangle rec1 = new Rectangle(widthStart, heightStart, widthSize, heightSize);
              heightStart += increment;
            g.DrawString((i + 1).ToString() + ". " + question.getQuestion()[i], font, sb, rec1);
            Rectangle rec2 = new Rectangle(widthStart, heightStart, widthSize, heightSize);
            heightStart += increment;
            Rectangle rec3 = new Rectangle(widthStart, heightStart, widthSize, heightSize);
            heightStart += increment;
            Rectangle rec4 = new Rectangle(widthStart, heightStart, widthSize, heightSize);
            g.DrawString("Category : Computer Science", font, sb, new Rectangle(widthStart, 160, widthSize, heightSize));
            g.DrawString("1. A programming language", font, sb, rec1);
            g.DrawString("2. John McCarthy", font, sb, rec2);
            g.DrawString("3. Artificial intelligence", font, sb, rec3);
            g.DrawString("4. Old as hell", font, sb, rec4);*/
            BackgroundImage = back;
        }
    }
}
