namespace WindowsForm
{
    partial class FlashyThing
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
            this.button1 = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.multi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(79, 41);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(147, 62);
            this.test.TabIndex = 1;
            this.test.Text = "What is my Name";
            // 
            // multi
            // 
            this.multi.AutoSize = true;
            this.multi.Location = new System.Drawing.Point(24, 121);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(23, 13);
            this.multi.TabIndex = 2;
            this.multi.Text = "2*3";
            // 
            // FlashyThing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.test);
            this.Controls.Add(this.button1);
            this.Name = "FlashyThing";
            this.Text = "FlashyThing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label multi;
    }
}