
namespace Kalkulator_Github
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddingButton = new System.Windows.Forms.Button();
            this.NumberA = new System.Windows.Forms.TextBox();
            this.NumberB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddingButton
            // 
            this.AddingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddingButton.Location = new System.Drawing.Point(493, 119);
            this.AddingButton.Name = "AddingButton";
            this.AddingButton.Size = new System.Drawing.Size(100, 50);
            this.AddingButton.TabIndex = 0;
            this.AddingButton.Text = "Dodawanie";
            this.AddingButton.UseVisualStyleBackColor = false;
            this.AddingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberA
            // 
            this.NumberA.Location = new System.Drawing.Point(111, 84);
            this.NumberA.Name = "NumberA";
            this.NumberA.Size = new System.Drawing.Size(125, 25);
            this.NumberA.TabIndex = 1;
            // 
            // NumberB
            // 
            this.NumberB.Location = new System.Drawing.Point(111, 144);
            this.NumberB.Name = "NumberB";
            this.NumberB.Size = new System.Drawing.Size(125, 25);
            this.NumberB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumberB);
            this.Controls.Add(this.NumberA);
            this.Controls.Add(this.AddingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddingButton;
        private System.Windows.Forms.TextBox NumberA;
        private System.Windows.Forms.TextBox NumberB;
    }
}

