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
        public AssociationForm(IQuestion<string,string> iq)
        {
            InitializeComponent();
            question = iq;
            addAssociations();
        }
        private void addAssociations()
        {
            Bitmap back = new Bitmap(this.BackgroundImage);

            int heightStart = 210, increment = 30, widthStart = 190, widthSize = 300, heightSize = 50;
            var g = Graphics.FromImage(back);
            SolidBrush sb = new SolidBrush(Color.Red);
            Font font = new Font("Forte", 15);
            for (int i = 0; i < 4; i++)
            {
                
                Rectangle rec1 = new Rectangle(widthStart, heightStart, widthSize, heightSize);
                
                g.DrawString((i+1).ToString()+". "+question.getQuestion()[i], font, sb, rec1);
                heightStart += increment;
            }
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
