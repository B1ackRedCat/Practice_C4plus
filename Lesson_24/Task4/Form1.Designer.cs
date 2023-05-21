namespace Task4
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
            CodeInput = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            XInput = new TextBox();
            label3 = new Label();
            YInput = new TextBox();
            createBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 46);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Буква:";
            // 
            // CodeInput
            // 
            CodeInput.Location = new Point(82, 43);
            CodeInput.Name = "CodeInput";
            CodeInput.Size = new Size(125, 27);
            CodeInput.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(YInput);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(XInput);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CodeInput);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 176);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Управление";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 78);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 2;
            label2.Text = "X:";
            // 
            // XInput
            // 
            XInput.Location = new Point(82, 75);
            XInput.Name = "XInput";
            XInput.Size = new Size(125, 27);
            XInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 111);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 4;
            label3.Text = "Y:";
            // 
            // YInput
            // 
            YInput.Location = new Point(82, 108);
            YInput.Name = "YInput";
            YInput.Size = new Size(125, 27);
            YInput.TabIndex = 5;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(82, 141);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(94, 29);
            createBtn.TabIndex = 6;
            createBtn.Text = "Создать";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox CodeInput;
        private GroupBox groupBox1;
        private Button createBtn;
        private Label label3;
        private TextBox YInput;
        private Label label2;
        private TextBox XInput;
    }
}