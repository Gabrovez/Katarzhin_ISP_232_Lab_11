namespace WindowsFormsApp1
{
    partial class Typing_Game
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
            this.correct_ones = new System.Windows.Forms.TextBox();
            this.no_matter = new System.Windows.Forms.TextBox();
            this.Wrong_ones = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // correct_ones
            // 
            this.correct_ones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correct_ones.Location = new System.Drawing.Point(62, 45);
            this.correct_ones.Name = "correct_ones";
            this.correct_ones.Size = new System.Drawing.Size(171, 29);
            this.correct_ones.TabIndex = 0;
            this.correct_ones.Text = "Correct words: 0";
            // 
            // no_matter
            // 
            this.no_matter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.no_matter.Location = new System.Drawing.Point(269, 348);
            this.no_matter.Name = "no_matter";
            this.no_matter.Size = new System.Drawing.Size(235, 29);
            this.no_matter.TabIndex = 1;
            this.no_matter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.no_matter_KeyDown_1);
            // 
            // Wrong_ones
            // 
            this.Wrong_ones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wrong_ones.Location = new System.Drawing.Point(536, 45);
            this.Wrong_ones.Name = "Wrong_ones";
            this.Wrong_ones.Size = new System.Drawing.Size(185, 29);
            this.Wrong_ones.TabIndex = 2;
            this.Wrong_ones.Text = "Incorrect words: 0";
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.Location = new System.Drawing.Point(300, 207);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(150, 35);
            this.Input.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(269, 410);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Press Enter to enter a word ";
            // 
            // Typing_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Wrong_ones);
            this.Controls.Add(this.no_matter);
            this.Controls.Add(this.correct_ones);
            this.Name = "Typing_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing_game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox correct_ones;
        private System.Windows.Forms.TextBox no_matter;
        private System.Windows.Forms.TextBox Wrong_ones;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox textBox1;
    }
}

