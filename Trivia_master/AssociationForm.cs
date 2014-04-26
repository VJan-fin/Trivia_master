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
        public AssociationForm(IQuestion<string,string> iq, Category<string,string> cat)
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
                
                g.DrawString((i+1).ToString()+". "+question.getQuestion()[i], font, sb, rec1);
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
            BackgroundImage = back;
        }
    }
}
