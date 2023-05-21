namespace task_3
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
            label4 = new Label();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 39);
            label1.Name = "label1";
            label1.Size = new Size(254, 23);
            label1.TabIndex = 0;
            label1.Text = "Введите границы диапазона:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 77);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 1;
            label2.Text = "X1 =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(207, 77);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 2;
            label3.Text = "X2 =";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkSeaGreen;
            textBox1.Cursor = Cursors.No;
            textBox1.Location = new Point(107, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkSeaGreen;
            textBox2.Cursor = Cursors.No;
            textBox2.Location = new Point(256, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 27);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(57, 130);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 5;
            label4.Text = "Введите шаг:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkSeaGreen;
            textBox3.Location = new Point(179, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DarkSeaGreen;
            textBox5.Location = new Point(478, 127);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(79, 27);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(295, 130);
            label6.Name = "label6";
            label6.Size = new Size(182, 23);
            label6.TabIndex = 9;
            label6.Text = "Введите значение A:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkSeaGreen;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(57, 195);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Both;
            textBox4.Size = new Size(474, 144);
            textBox4.TabIndex = 11;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(234, 383);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 12;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(581, 449);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Button button1;
    }
}