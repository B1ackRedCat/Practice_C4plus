namespace task_1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(234, 30);
            label1.TabIndex = 0;
            label1.Text = "Введите значение Х:\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 91);
            label2.Name = "label2";
            label2.Size = new Size(233, 30);
            label2.TabIndex = 1;
            label2.Text = "Введите значение Y:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 143);
            label3.Name = "label3";
            label3.Size = new Size(233, 30);
            label3.TabIndex = 2;
            label3.Text = "Введите значение Z:\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(272, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 223);
            label4.Name = "label4";
            label4.Size = new Size(396, 30);
            label4.TabIndex = 6;
            label4.Text = "Результат выполнения программы:\r\n";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(36, 260);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(436, 129);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(427, 419);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 8;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(572, 460);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Task 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
    }
}