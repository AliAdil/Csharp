﻿namespace WindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.changeText = new System.Windows.Forms.Button();
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.labelToChange = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // changeText
            // 
            this.changeText.AutoSize = true;
            this.changeText.Location = new System.Drawing.Point(41, 26);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(150, 23);
            this.changeText.TabIndex = 0;
            this.changeText.Text = "Change the lebel if checked";
            this.changeText.UseVisualStyleBackColor = true;
            this.changeText.Click += new System.EventHandler(this.changeText_Click);
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Checked = true;
            this.enableCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckbox.Location = new System.Drawing.Point(346, 30);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(131, 17);
            this.enableCheckbox.TabIndex = 1;
            this.enableCheckbox.Text = "Enable label changing";
            this.enableCheckbox.UseVisualStyleBackColor = true;
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(38, 255);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(476, 23);
            this.labelToChange.TabIndex = 2;
            this.labelToChange.Text = "Press the button to change my text ";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 140);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newButton.Location = new System.Drawing.Point(0, 0);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(250, 250);
            this.newButton.TabIndex = 4;
            this.newButton.Text = "newButton";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 315);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.enableCheckbox);
            this.Controls.Add(this.changeText);
            this.Name = "Form1";
            this.Text = "My Desktop App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.CheckBox enableCheckbox;
        private System.Windows.Forms.Label labelToChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button newButton;
    }
}

