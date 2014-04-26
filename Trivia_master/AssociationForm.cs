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
<<<<<<< HEAD
        IQuestion<string,string> question;
        Category<string, string> category;
        public AssociationForm(IQuestion<string,string> iq, Category<string,string> cat)
=======
        IQuestion<string, string> question;

        public AssociationForm()
        {
            InitializeComponent();
        }

        public AssociationForm(IQuestion<string, string> iq)
>>>>>>> 5262a978e5e0da414297ecb438880c23bae741ef
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
<<<<<<< HEAD
           g.DrawString("Category : "+category.CategoryName, font, sb, new Rectangle(widthStart, 135, widthSize, heightSize));
=======

>>>>>>> 5262a978e5e0da414297ecb438880c23bae741ef
            for (int i = 0; i < 4; i++)
            {

                Rectangle rec1 = new Rectangle(widthStart, heightStart, widthSize, heightSize);

                g.DrawString((i + 1).ToString() + ". " + question.getQuestion()[i], font, sb, rec1);
                heightStart += increment;
            }
<<<<<<< HEAD
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
=======
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
>>>>>>> 5262a978e5e0da414297ecb438880c23bae741ef
            BackgroundImage = back;
        }
    }
}
