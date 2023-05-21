namespace Task1
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
            listBox1 = new ListBox();
            FormatBtn = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Тестовое предложение", "Предложение текстовое", "А вот еще одно тектовое предложение", "А, тоже текстовое" });
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(336, 144);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FormatBtn
            // 
            FormatBtn.Location = new Point(12, 162);
            FormatBtn.Name = "FormatBtn";
            FormatBtn.Size = new Size(335, 29);
            FormatBtn.TabIndex = 1;
            FormatBtn.Text = "Обработать";
            FormatBtn.UseVisualStyleBackColor = true;
            FormatBtn.Click += FormatBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 198);
            Controls.Add(FormatBtn);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "LR23 Task1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button FormatBtn;
    }
}