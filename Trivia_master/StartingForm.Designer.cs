namespace Trivia_master
{
    partial class StartingForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.QBox1 = new Trivia_master.QuestionBox();
            this.questionBox1 = new Trivia_master.QuestionBox();
            this.questionBox2 = new Trivia_master.QuestionBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Trivia_master.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(220, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(586, 317);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // QBox1
            // 
            this.QBox1.BackColor = System.Drawing.Color.Transparent;
            this.QBox1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(103)))), ((int)(((byte)(172)))));
            this.QBox1.FlatAppearance.BorderSize = 4;
            this.QBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QBox1.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QBox1.Location = new System.Drawing.Point(220, 589);
            this.QBox1.Margin = new System.Windows.Forms.Padding(4);
            this.QBox1.Name = "QBox1";
            this.QBox1.Size = new System.Drawing.Size(160, 94);
            this.QBox1.TabIndex = 64;
            this.QBox1.TabStop = false;
            this.QBox1.Text = "Easy";
            this.QBox1.UseVisualStyleBackColor = true;
            this.QBox1.Click += new System.EventHandler(this.button1_Click);
            // 
            // questionBox1
            // 
            this.questionBox1.BackColor = System.Drawing.Color.Transparent;
            this.questionBox1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(103)))), ((int)(((byte)(172)))));
            this.questionBox1.FlatAppearance.BorderSize = 4;
            this.questionBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionBox1.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionBox1.Location = new System.Drawing.Point(433, 589);
            this.questionBox1.Margin = new System.Windows.Forms.Padding(4);
            this.questionBox1.Name = "questionBox1";
            this.questionBox1.Size = new System.Drawing.Size(160, 94);
            this.questionBox1.TabIndex = 65;
            this.questionBox1.TabStop = false;
            this.questionBox1.Text = "Medium";
            this.questionBox1.UseVisualStyleBackColor = true;
            this.questionBox1.Click += new System.EventHandler(this.button2_Click);
            // 
            // questionBox2
            // 
            this.questionBox2.BackColor = System.Drawing.Color.Transparent;
            this.questionBox2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(103)))), ((int)(((byte)(172)))));
            this.questionBox2.FlatAppearance.BorderSize = 4;
            this.questionBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionBox2.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionBox2.Location = new System.Drawing.Point(646, 589);
            this.questionBox2.Margin = new System.Windows.Forms.Padding(4);
            this.questionBox2.Name = "questionBox2";
            this.questionBox2.Size = new System.Drawing.Size(160, 94);
            this.questionBox2.TabIndex = 66;
            this.questionBox2.TabStop = false;
            this.questionBox2.Text = "Hard";
            this.questionBox2.UseVisualStyleBackColor = true;
            this.questionBox2.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(437, 706);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 30);
            this.label1.TabIndex = 67;
            this.label1.Text = "v1.0 \r\n©2014 Viktor Janevski, Aleksandar Kuzmanoski, Dimitar Spasovski";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 788);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionBox2);
            this.Controls.Add(this.questionBox1);
            this.Controls.Add(this.QBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "StartingForm";
            this.Text = "Trivia Master";
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.QBox1, 0);
            this.Controls.SetChildIndex(this.questionBox1, 0);
            this.Controls.SetChildIndex(this.questionBox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private QuestionBox QBox1;
        private QuestionBox questionBox1;
        private QuestionBox questionBox2;
        private System.Windows.Forms.Label label1;
    }
}