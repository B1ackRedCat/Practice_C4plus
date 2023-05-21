namespace task_2
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
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(44, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 32);
            label1.TabIndex = 0;
            label1.Text = "X =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(44, 79);
            label2.Name = "label2";
            label2.Size = new Size(50, 32);
            label2.TabIndex = 1;
            label2.Text = "Y =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightCyan;
            label3.Location = new Point(44, 129);
            label3.Name = "label3";
            label3.Size = new Size(51, 32);
            label3.TabIndex = 2;
            label3.Text = "Z =";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCyan;
            textBox1.Location = new Point(44, 198);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(439, 163);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.LightCyan;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightCyan;
            button1.Location = new Point(43, 403);
            button1.Name = "button1";
            button1.Size = new Size(95, 37);
            button1.TabIndex = 4;
            button1.Text = "Пуск";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Indigo;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.LightCyan;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.LightCyan;
            button2.Location = new Point(332, 403);
            button2.Name = "button2";
            button2.Size = new Size(151, 37);
            button2.TabIndex = 5;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightCyan;
            textBox2.Location = new Point(106, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightCyan;
            textBox3.Location = new Point(106, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightCyan;
            textBox4.Location = new Point(106, 132);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(178, 27);
            textBox4.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(533, 464);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.MidnightBlue;
            Name = "Form1";
            Text = "Task 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}