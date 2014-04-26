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
    public partial class CloseForm : Form
    {
        Boolean IsClicked = false;
        Point mousePoint;
        Point currPoint;
        public CloseForm()
        {
            InitializeComponent();
               Bitmap bm = new Bitmap(BackgroundImage);
            Graphics g = Graphics.FromImage(bm);
            Rectangle rec1 = new Rectangle(22, 16, Width-45, Height-32);
            g.DrawImage(Properties.Resources.TRU_BRICK_2_DARK_BLUE, rec1);
            Rectangle rec2 = new Rectangle(100, 40, 200, 90);
           Font font = new Font("Forte", 18);
           SolidBrush sb = new SolidBrush(Color.Red);
           g.DrawString("Are you sure you want to quit?", font, sb, rec2);
           BackgroundImage = bm;
        }

        private void alphabetButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void alphabetButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsClicked = true;
                mousePoint = e.Location;
                Cursor = Cursors.SizeAll;
                currPoint = this.Location;
            }
        }

        private void CloseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                this.Location = new Point(this.Location.X + (e.Location.X - mousePoint.X), this.Location.Y + (e.Location.Y - mousePoint.Y));
            }
        }

        private void CloseForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Location.Y < 0) this.Location = new Point(this.Location.X, 0);
                IsClicked = false;
                Cursor = Cursors.Default;
            }
        }

        private void CloseForm_MouseClick(object sender, MouseEventArgs e)
        {

        }

    }
}
