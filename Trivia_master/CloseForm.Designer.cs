﻿namespace Trivia_master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseForm));
            this.SuspendLayout();
            // 
            // alphabetButton1
            // 
            this.alphabetButton1.BackColor = System.Drawing.Color.Transparent;
            this.alphabetButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.alphabetButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alphabetButton1.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphabetButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.alphabetButton1.Location = new System.Drawing.Point(299, 154);
            this.alphabetButton1.Margin = new System.Windows.Forms.Padding(4);
            this.alphabetButton1.Name = "alphabetButton1";
            this.alphabetButton1.Size = new System.Drawing.Size(113, 49);
            this.alphabetButton1.TabIndex = 16;
            this.alphabetButton1.TabStop = false;
            this.alphabetButton1.Text = "No";
            this.alphabetButton1.UseVisualStyleBackColor = true;
            this.alphabetButton1.Click += new System.EventHandler(this.alphabetButton1_Click);
            // 
            // alphabetButton2
            // 
            this.alphabetButton2.BackColor = System.Drawing.Color.Transparent;
            this.alphabetButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.alphabetButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alphabetButton2.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphabetButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.alphabetButton2.Location = new System.Drawing.Point(61, 154);
            this.alphabetButton2.Margin = new System.Windows.Forms.Padding(4);
            this.alphabetButton2.Name = "alphabetButton2";
            this.alphabetButton2.Size = new System.Drawing.Size(113, 49);
            this.alphabetButton2.TabIndex = 15;
            this.alphabetButton2.TabStop = false;
            this.alphabetButton2.Text = "Yes";
            this.alphabetButton2.UseVisualStyleBackColor = true;
            this.alphabetButton2.Click += new System.EventHandler(this.alphabetButton2_Click);
            // 
            // CloseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trivia_master.Properties.Resources.rsz_1rsz_1rsz_1aaaaq;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(493, 252);
            this.Controls.Add(this.alphabetButton1);
            this.Controls.Add(this.alphabetButton2);
            this.BackgroundImage = global::Trivia_master.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(375, 215);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CloseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CloseForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseForm_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseForm_MouseUp);
            this.ResumeLayout(false);
        }

        AlphabetButton alphabetButton1 = new AlphabetButton();
        AlphabetButton alphabetButton2 = new AlphabetButton();

        #endregion

    }
}