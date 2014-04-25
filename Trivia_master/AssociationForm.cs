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
        public AssociationForm()
        {
            InitializeComponent();
            addAssociations();
        }
        private void addAssociations()
        {
            Bitmap back = new Bitmap(this.BackgroundImage);

            int heightStart = 210, increment = 30, widthStart = 190;
            var g = Graphics.FromImage(back);
            Font font = new Font("Forte", 15);
            Rectangle rec1 = new Rectangle(widthStart, heightStart, 300, 50);
            heightStart += increment;
            Rectangle rec2 = new Rectangle(widthStart, heightStart, 300, 50);
            heightStart += increment;
            Rectangle rec3 = new Rectangle(widthStart, heightStart, 300, 50);
            heightStart += increment;
            Rectangle rec4 = new Rectangle(widthStart, heightStart, 300, 50);
            SolidBrush sb = new SolidBrush(Color.Red);
            g.DrawString("Category : Computer Science", font, sb, new Rectangle(widthStart,160,300,50));
            g.DrawString("1. A programming language", font, sb, rec1);
            g.DrawString("2. John McCarthy", font, sb, rec2);
            g.DrawString("3. Artificial intelligence", font, sb, rec3);
            g.DrawString("4. Old as hell", font, sb, rec4);
            BackgroundImage = back;
        }
    }
}
