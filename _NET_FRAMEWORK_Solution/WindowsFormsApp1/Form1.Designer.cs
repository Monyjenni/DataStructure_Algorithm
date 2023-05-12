namespace WindowsFormsApp1
{
    partial class Form1
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
            this.UserNameTextBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HelloButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.AutoSize = true;
            this.UserNameTextBox.Location = new System.Drawing.Point(99, 77);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(145, 16);
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.Text = "Please type your name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 22);
            this.textBox1.TabIndex = 2;
            // 
            // HelloButton
            // 
            this.HelloButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HelloButton.Location = new System.Drawing.Point(210, 236);
            this.HelloButton.Name = "HelloButton";
            this.HelloButton.Size = new System.Drawing.Size(120, 41);
            this.HelloButton.TabIndex = 3;
            this.HelloButton.Text = "Hello";
            this.HelloButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HelloButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UserNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button HelloButton;
        private System.Windows.Forms.Label label1;
    }
}

