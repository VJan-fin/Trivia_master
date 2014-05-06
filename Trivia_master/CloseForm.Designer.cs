namespace Trivia_master
{
    partial class CloseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CloseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trivia_master.Properties.Resources.Blue_Frame1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 222);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CloseForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CloseForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CloseForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CloseForm_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseForm_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseForm_MouseUp);
            this.ResumeLayout(false);

        }

        AlphabetButton alphabetButton1 = new AlphabetButton();
        AlphabetButton alphabetButton2 = new AlphabetButton();

        #endregion
        private System.Windows.Forms.Timer timer1;

    }
}