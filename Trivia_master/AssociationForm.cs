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

        IQuestion<string,FormPainter> question;
        Category<string, FormPainter> category;
        protected String Question { get; set; }
        protected int Answere { get; set; }
        List<Rectangle> Areas;
        //public int TimeLeft = 21;
        public int heightStart;
        public int increment;
        public int widthStart;
        public int widthSize;
        public int heightSize;
        public int defaultHeightStart;
        SolidBrush sb;
        Font font;
        Font timerFont;
        Point Location;
        
        public AssociationForm()
        {
            InitializeComponent();
        }

        public AssociationForm(Category<String, FormPainter> c, IQuestion<String, FormPainter> q)
        {
            InitializeComponent();
            Areas = new List<Rectangle>();
            //timer1.Start();
            sb = new SolidBrush(Color.Red);
            font = new Font("Forte", 15);
            timerFont = new Font("Forte", 22);
            defaultHeightStart =heightStart = 250;
            increment = 30;
            widthStart = 230;
            widthSize = 400;
            heightSize = 50;
           
            
            question = q;
            this.category = c;
            Answere = 0;
            DoubleBuffered = true;
            Answer = q.getCorrectAnswer()[0];
            Answer.Form = this; 
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
            Answere = 1;
            UpdateView();
        }

        private void addAssociations(Graphics gp)
        {
            heightStart = defaultHeightStart;
            gp.DrawString("Category : " + category.CategoryName, font, sb, new Rectangle(widthStart, 190, widthSize, heightSize));
            for (int i = 0; i < 4; i++)
            {

                Rectangle rec1 = new Rectangle(widthStart, heightStart, widthSize, heightSize);
                Areas.Add(rec1);
                gp.DrawString((i + 1).ToString() + ". " + question.getQuestion()[i], font, sb, rec1);
                heightStart += increment;
            }


            /*private void timer1_Tick(object sender, EventArgs e)
            {
                TimeLeft--;
                if (TimeLeft == 0)
                    timer1.Stop();
                else
                {
             
                    Rectangle rec2 = new Rectangle(500, 300, 40, 40);
                    Bitmap back = new Bitmap(OldPicture);
                   Graphics gp = Graphics.FromImage(back);
                   gp.FillRectangle(new SolidBrush(Color.Transparent), rec2);
                    gp.DrawString(TimeLeft.ToString(), timerFont, sb, rec2);
        
                    BackgroundImage = back;
                }
            }*/
        }

        private void AssociationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
