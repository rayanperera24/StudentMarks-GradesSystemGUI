namespace student_marks_and_grades_system
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            txt4 = new TextBox();
            txt5 = new TextBox();
            txt6 = new TextBox();
            txt7 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "St ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 73);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 121);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Science Marks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 152);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Maths Marks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 185);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 4;
            label5.Text = "English Marks";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 256);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Avarage";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 256);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "Grade";
            // 
            // button1
            // 
            button1.Location = new Point(40, 309);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 7;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(234, 309);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 8;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(109, 33);
            txt1.Name = "txt1";
            txt1.Size = new Size(290, 23);
            txt1.TabIndex = 9;
            // 
            // txt2
            // 
            txt2.Location = new Point(109, 73);
            txt2.Name = "txt2";
            txt2.Size = new Size(290, 23);
            txt2.TabIndex = 10;
            // 
            // txt3
            // 
            txt3.Location = new Point(135, 118);
            txt3.Name = "txt3";
            txt3.Size = new Size(264, 23);
            txt3.TabIndex = 11;
            // 
            // txt4
            // 
            txt4.Location = new Point(135, 152);
            txt4.Name = "txt4";
            txt4.Size = new Size(264, 23);
            txt4.TabIndex = 12;
            // 
            // txt5
            // 
            txt5.Location = new Point(135, 185);
            txt5.Name = "txt5";
            txt5.Size = new Size(264, 23);
            txt5.TabIndex = 13;
            // 
            // txt6
            // 
            txt6.Location = new Point(89, 253);
            txt6.Name = "txt6";
            txt6.Size = new Size(135, 23);
            txt6.TabIndex = 14;
            // 
            // txt7
            // 
            txt7.Location = new Point(295, 253);
            txt7.Name = "txt7";
            txt7.Size = new Size(104, 23);
            txt7.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(424, 450);
            Controls.Add(txt7);
            Controls.Add(txt6);
            Controls.Add(txt5);
            Controls.Add(txt4);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private TextBox txt4;
        private TextBox txt5;
        private TextBox txt6;
        private TextBox txt7;
    }
}