namespace KeyboardMe
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SoftwareTxt = new System.Windows.Forms.TextBox();
            this.enter1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(585, 448);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(357, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SoftwareTxt
            // 
            this.SoftwareTxt.Location = new System.Drawing.Point(12, 107);
            this.SoftwareTxt.Name = "SoftwareTxt";
            this.SoftwareTxt.Size = new System.Drawing.Size(357, 20);
            this.SoftwareTxt.TabIndex = 3;
            this.SoftwareTxt.Text = "softname 2";
            this.SoftwareTxt.TextChanged += new System.EventHandler(this.SoftwareTxt_TextChanged);
            // 
            // enter1
            // 
            this.enter1.Location = new System.Drawing.Point(12, 68);
            this.enter1.Name = "enter1";
            this.enter1.Size = new System.Drawing.Size(357, 20);
            this.enter1.TabIndex = 4;
            this.enter1.Text = "Enter software name like (*name - Notepad)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enter 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 152);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.enter1);
            this.Controls.Add(this.SoftwareTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SoftwareTxt;
        private System.Windows.Forms.TextBox enter1;
        private System.Windows.Forms.Button button2;
    }
}

