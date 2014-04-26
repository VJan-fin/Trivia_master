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
    public partial class AssociationForm : Form1
    {

        IQuestion<string,string> question;
        Category<string, string> category;

   
        public AssociationForm()
        {
            InitializeComponent();
        }

        public AssociationForm(IQuestion<string, string> iq, Category<string,string> cat)
        {
            InitializeComponent();
            question = iq;
            this.category = cat;
            addAssociations();
        }

        private void addAssociations()
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

            int wordCount = question.getCorrectAnswer()[0].Count();
            StringBuilder strb = new StringBuilder();
            for (int i = 1; i <= wordCount; i++)
            {
                strb.Append("_");
                if (i != wordCount)
                  strb.Append(" ");
            }
            triviaLabel2.Text = strb.ToString();

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
