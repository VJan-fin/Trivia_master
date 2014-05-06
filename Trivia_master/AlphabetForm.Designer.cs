using System.Windows.Forms;
namespace Trivia_master
{
    partial class AlphabetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlphabetForm));
            this.label2 = new Trivia_master.TriviaLabel();
            this.lblKategorija = new Trivia_master.TriviaLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblOdgovor = new Trivia_master.TriviaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(223, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Category:";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.BackColor = System.Drawing.Color.Transparent;
            this.lblKategorija.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKategorija.Location = new System.Drawing.Point(328, 186);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(0, 22);
            this.lblKategorija.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(227, 153);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(338, 263);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // lblOdgovor
            // 
            this.lblOdgovor.AutoSize = true;
            this.lblOdgovor.BackColor = System.Drawing.Color.Transparent;
            this.lblOdgovor.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdgovor.ForeColor = System.Drawing.Color.White;
            this.lblOdgovor.Location = new System.Drawing.Point(157, 418);
            this.lblOdgovor.Name = "lblOdgovor";
            this.lblOdgovor.Size = new System.Drawing.Size(221, 35);
            this.lblOdgovor.TabIndex = 32;
            this.lblOdgovor.Text = "_ _ _ _ _ _ _ _";
            this.lblOdgovor.Visible = false;
            // 
            // AlphabetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 640);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.lblOdgovor);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlphabetForm";
            this.Opacity = 0D;
            this.Text = "butt";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AlphabetForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlphabetForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphabetForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AlphabetForm_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AlphabetForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AlphabetForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AlphabetForm_MouseUp);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblOdgovor, 0);
            this.Controls.SetChildIndex(this.lblKategorija, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TriviaLabel label2;
        private TriviaLabel lblKategorija;
        private PictureBox pictureBox2;
        private TriviaLabel lblOdgovor;

    }
}