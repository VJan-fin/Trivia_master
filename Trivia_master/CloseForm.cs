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
        Point Location1 { get; set; }
        List<CostomAlphabetButton> lista;
        Font font;
        Point Pstring;
        int curr = 0;
        public CloseForm()
        {
            InitializeComponent();
            timer1.Start();
            lista = new List<CostomAlphabetButton>();

            font = new Font("Forte", 15);
            if (Size.Width > Size.Height)
            {
                Location1 = new Point(Size.Width / 3 - Size.Height / 3, 0);
            }
            else Location1 = new Point(0, Size.Height / 3 - Size.Width / 3);

            int pom = (int)Math.Round(Math.Min(Size.Width, Size.Height) / 8.0, 0);
            Size BtnSize = new Size(pom * 2, pom);
            Point pointNo = new Point(Location1.X + Math.Min(Width, Height) * 16 / 20, Location1.Y + Math.Min(Width, Height) * 4 / 6);
            Point pointYes = new Point(Location1.X + Math.Min(Width, Height) * 4 / 30, Location1.Y + Math.Min(Width, Height) * 4 / 6);
            Pstring = new Point(Location1.X + Math.Min(Width, Height) * 1 / 52, Location1.Y + Math.Min(Width, Height) * 2 / 6);
            CostomAlphabetButton cb = new CostomAlphabetButton(font, pointYes, BtnSize);
            CostomAlphabetButton cb1 = new CostomAlphabetButton(font, pointNo, BtnSize);
            cb.Text = "Yes";
            cb1.Text = "No";
            cb.TextLocation = new Point((int)(Math.Round(cb.Location.X + cb.Size.Width / 3 - cb.Font.Size * 2 / 3, 0)), (int)(Math.Round(cb.Location.Y + cb.Size.Height / 2.0 - cb.Font.Size * 2 / 3, 0)));
            cb1.TextLocation = new Point((int)(Math.Round(cb1.Location.X + cb1.Size.Width / 3 - cb1.Font.Size * 2 / 3, 0)), (int)(Math.Round(cb1.Location.Y + cb1.Size.Height / 2.0 - cb1.Font.Size * 2 / 3, 0)));
            lista.Add(cb);
            lista.Add(cb1);
            Invalidate();
        }
        private void draw(Graphics e)
        {

            Brush br = new SolidBrush(Color.Red);
            foreach (CostomAlphabetButton c in lista)
                c.Draw(e);
            e.DrawString("Are you sure you want to quit?", font, br, Pstring);

        }

        private void alphabetButton2_Click(object sender, EventArgs e)
        {

        }

        private void alphabetButton1_Click(object sender, EventArgs e)
        {
            
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
            foreach (CostomAlphabetButton c in lista)
            {
                if (c.IsIn(e.Location) && c.Text == "Yes")
                {
                    Application.Exit();

                }
                if (c.IsIn(e.Location) && c.Text == "No")
                {

                    Close();

                }
            }
        }

        private void CloseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                this.Location = new Point(this.Location.X + (e.Location.X - mousePoint.X), this.Location.Y + (e.Location.Y - mousePoint.Y));
            }
            Color color = Color.Transparent;
            foreach (CostomAlphabetButton c in lista)
                if (c.IsIn(e.Location))
                    c.BackColor = Color.FromArgb(229, 192, 21);
                else c.BackColor = color;
            Invalidate();
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

        private void CloseForm_Paint(object sender, PaintEventArgs e)
        {
            draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            curr++;
            if (curr == 10)
                timer1.Stop();
        }

        private void CloseForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.N)
                Close();
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Y)
                Application.Exit();
        }

        private void CloseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.N)
            {
                lista[1].BackColor = Color.FromArgb(229, 192, 21);
                Invalidate();
            }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Y)
            {
                lista[0].BackColor = Color.FromArgb(229, 192, 21);
                Invalidate();
            }
        }

        
    }
}
