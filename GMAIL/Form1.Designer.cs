﻿namespace GMAIL
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 76);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 124);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 2;
            label2.Text = "To";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 23);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 161);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Subject";
            // 
            // button1
            // 
            button1.Location = new Point(258, 249);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 10;
            button1.Text = "Attach";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(78, 300);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(262, 102);
            textBox6.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(358, 319);
            button2.Name = "button2";
            button2.Size = new Size(82, 31);
            button2.TabIndex = 12;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(358, 371);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 13;
            button3.Text = "New Letter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(320, 76);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 109);
            listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private TextBox textBox6;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
    }
}