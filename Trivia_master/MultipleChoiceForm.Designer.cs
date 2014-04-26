namespace Trivia_master
{
    partial class MultipleChoiceForm
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
            this.labelQ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelA1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelA2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelA3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelA4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQ
            // 
            this.labelQ.BackColor = System.Drawing.Color.Transparent;
            this.labelQ.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQ.Location = new System.Drawing.Point(196, 377);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(577, 145);
            this.labelQ.TabIndex = 7;
            this.labelQ.Text = "Who was the first president of the USA?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(297, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Category:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCategory.Location = new System.Drawing.Point(437, 229);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(103, 31);
            this.labelCategory.TabIndex = 16;
            this.labelCategory.Text = "History";
            // 
            // labelA1
            // 
            this.labelA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(65)))));
            this.labelA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelA1.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelA1.Location = new System.Drawing.Point(237, 576);
            this.labelA1.Name = "labelA1";
            this.labelA1.Size = new System.Drawing.Size(247, 62);
            this.labelA1.TabIndex = 18;
            this.labelA1.Text = "George Washington";
            this.labelA1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelA1.Click += new System.EventHandler(this.labelA1_Click);
            this.labelA1.MouseEnter += new System.EventHandler(this.labelA1_MouseEnter);
            this.labelA1.MouseLeave += new System.EventHandler(this.labelA1_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(65)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(203, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 62);
            this.label1.TabIndex = 17;
            this.label1.Text = "A:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelA2
            // 
            this.labelA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(65)))));
            this.labelA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelA2.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelA2.Location = new System.Drawing.Point(583, 576);
            this.labelA2.Name = "labelA2";
            this.labelA2.Size = new System.Drawing.Size(247, 62);
            this.labelA2.TabIndex = 20;
            this.labelA2.Text = "Abraham Lincoln";
            this.labelA2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelA2.Click += new System.EventHandler(this.labelA1_Click);
            this.labelA2.MouseEnter += new System.EventHandler(this.labelA1_MouseEnter);
            this.labelA2.MouseLeave += new System.EventHandler(this.labelA1_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(65)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(547, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 62);
            this.label3.TabIndex = 19;
            this.label3.Text = "B:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelA3
            // 
            this.labelA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(65)))));
            this.labelA3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelA3.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelA3.Location = new System.Drawing.Point(237, 679);
            this.labelA3.Name = "labelA3";
            this.labelA3.Size = new System.Drawing.Size(247, 62);
            this.labelA3.TabIndex = 22;
            this.labelA3.Text = "John F. Kennedy";
            this.labelA3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelA3.Click += new System.EventHandler(this.labelA1_Click);
            this.labelA3.MouseEnter += new System.EventHandler(this.labelA1_MouseEnter);
            this.labelA3.MouseLeave += new System.EventHandler(this.labelA1_MouseLeave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(65)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(203, 679);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 62);
            this.label5.TabIndex = 21;
            this.label5.Text = "C:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelA4
            // 
            this.labelA4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(65)))));
            this.labelA4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelA4.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelA4.Location = new System.Drawing.Point(583, 679);
            this.labelA4.Name = "labelA4";
            this.labelA4.Size = new System.Drawing.Size(247, 62);
            this.labelA4.TabIndex = 24;
            this.labelA4.Text = "Theodore Roosevelt";
            this.labelA4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelA4.Click += new System.EventHandler(this.labelA1_Click);
            this.labelA4.MouseEnter += new System.EventHandler(this.labelA1_MouseEnter);
            this.labelA4.MouseLeave += new System.EventHandler(this.labelA1_MouseLeave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(65)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(547, 679);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 62);
            this.label8.TabIndex = 23;
            this.label8.Text = "D:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(303, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(451, 324);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTimer.Location = new System.Drawing.Point(687, 218);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(131, 46);
            this.labelTimer.TabIndex = 26;
            // 
            // MultipleChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trivia_master.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(925, 788);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelA4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelA3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelA2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelA1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MultipleChoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MultipleChoiceForm";
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.labelQ, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.labelCategory, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.labelA1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.labelA2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.labelA3, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.labelA4, 0);
            this.Controls.SetChildIndex(this.labelTimer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelA1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelA2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelA3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelA4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;


    }
}