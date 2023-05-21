namespace task_4
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
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            textBoxPatronymic = new TextBox();
            label3 = new Label();
            radioButtonSexFem = new RadioButton();
            radioButtonSexMen = new RadioButton();
            groupBoxSex = new GroupBox();
            groupBoxBirthDay = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBoxCity = new ComboBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            comboBoxPhone = new ComboBox();
            groupBoxWork = new GroupBox();
            radioButtonWork5 = new RadioButton();
            radioButtonWork4 = new RadioButton();
            radioButtonWork3 = new RadioButton();
            radioButtonWork2 = new RadioButton();
            radioButtonWork1 = new RadioButton();
            groupBoxOther = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            label10 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label12 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label13 = new Label();
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            groupBoxSex.SuspendLayout();
            groupBoxBirthDay.SuspendLayout();
            groupBoxWork.SuspendLayout();
            groupBoxOther.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(148, 33);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(125, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(148, 78);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 3;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 82);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 2;
            label2.Text = "Имя";
            label2.Click += label2_Click;
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Location = new Point(148, 123);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(125, 27);
            textBoxPatronymic.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 127);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 4;
            label3.Text = "Отчество";
            // 
            // radioButtonSexFem
            // 
            radioButtonSexFem.AutoSize = true;
            radioButtonSexFem.ForeColor = Color.Black;
            radioButtonSexFem.Location = new Point(6, 56);
            radioButtonSexFem.Name = "radioButtonSexFem";
            radioButtonSexFem.Size = new Size(93, 24);
            radioButtonSexFem.TabIndex = 6;
            radioButtonSexFem.TabStop = true;
            radioButtonSexFem.Text = "Мужской";
            radioButtonSexFem.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexMen
            // 
            radioButtonSexMen.AutoSize = true;
            radioButtonSexMen.ForeColor = Color.Black;
            radioButtonSexMen.Location = new Point(6, 26);
            radioButtonSexMen.Name = "radioButtonSexMen";
            radioButtonSexMen.Size = new Size(92, 24);
            radioButtonSexMen.TabIndex = 7;
            radioButtonSexMen.TabStop = true;
            radioButtonSexMen.Text = "Женский";
            radioButtonSexMen.UseVisualStyleBackColor = true;
            // 
            // groupBoxSex
            // 
            groupBoxSex.Controls.Add(radioButtonSexFem);
            groupBoxSex.Controls.Add(radioButtonSexMen);
            groupBoxSex.ForeColor = Color.Blue;
            groupBoxSex.Location = new Point(387, 33);
            groupBoxSex.Name = "groupBoxSex";
            groupBoxSex.Size = new Size(250, 93);
            groupBoxSex.TabIndex = 8;
            groupBoxSex.TabStop = false;
            groupBoxSex.Text = "Пол";
            groupBoxSex.Enter += groupBox1_Enter;
            // 
            // groupBoxBirthDay
            // 
            groupBoxBirthDay.Controls.Add(dateTimePicker1);
            groupBoxBirthDay.Controls.Add(label6);
            groupBoxBirthDay.Controls.Add(label5);
            groupBoxBirthDay.Controls.Add(label4);
            groupBoxBirthDay.ForeColor = Color.Blue;
            groupBoxBirthDay.Location = new Point(39, 177);
            groupBoxBirthDay.Name = "groupBoxBirthDay";
            groupBoxBirthDay.Size = new Size(598, 95);
            groupBoxBirthDay.TabIndex = 9;
            groupBoxBirthDay.TabStop = false;
            groupBoxBirthDay.Text = "Дата рождения";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(184, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 27);
            dateTimePicker1.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(270, 24);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 11;
            label6.Text = "Год";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(216, 24);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 11;
            label5.Text = "Месяц";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(173, 24);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 10;
            label4.Text = "День";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(39, 292);
            label7.Name = "label7";
            label7.Size = new Size(172, 23);
            label7.TabIndex = 11;
            label7.Text = "Место проживания";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(39, 332);
            label8.Name = "label8";
            label8.Size = new Size(231, 23);
            label8.TabIndex = 12;
            label8.Text = "Адрес электронной почты";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(39, 369);
            label9.Name = "label9";
            label9.Size = new Size(186, 23);
            label9.TabIndex = 13;
            label9.Text = "Мобильный телефон";
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Items.AddRange(new object[] { "Минск", "Гродно", "Витебск", "Брест", "Могилев", "Гомель" });
            comboBoxCity.Location = new Point(293, 291);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(377, 28);
            comboBoxCity.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(293, 328);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(377, 27);
            textBoxEmail.TabIndex = 14;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(437, 365);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(233, 27);
            textBoxPhone.TabIndex = 15;
            // 
            // comboBoxPhone
            // 
            comboBoxPhone.FormattingEnabled = true;
            comboBoxPhone.Items.AddRange(new object[] { "МТС", "А1" });
            comboBoxPhone.Location = new Point(293, 364);
            comboBoxPhone.Name = "comboBoxPhone";
            comboBoxPhone.Size = new Size(103, 28);
            comboBoxPhone.TabIndex = 12;
            // 
            // groupBoxWork
            // 
            groupBoxWork.Controls.Add(radioButtonWork5);
            groupBoxWork.Controls.Add(radioButtonWork4);
            groupBoxWork.Controls.Add(radioButtonWork3);
            groupBoxWork.Controls.Add(radioButtonWork2);
            groupBoxWork.Controls.Add(radioButtonWork1);
            groupBoxWork.ForeColor = Color.Blue;
            groupBoxWork.Location = new Point(39, 408);
            groupBoxWork.Name = "groupBoxWork";
            groupBoxWork.Size = new Size(733, 125);
            groupBoxWork.TabIndex = 16;
            groupBoxWork.TabStop = false;
            groupBoxWork.Text = "Опыт работы";
            // 
            // radioButtonWork5
            // 
            radioButtonWork5.AutoSize = true;
            radioButtonWork5.ForeColor = Color.Black;
            radioButtonWork5.Location = new Point(526, 38);
            radioButtonWork5.Name = "radioButtonWork5";
            radioButtonWork5.Size = new Size(118, 24);
            radioButtonWork5.TabIndex = 4;
            radioButtonWork5.TabStop = true;
            radioButtonWork5.Text = "Более 10 лет";
            radioButtonWork5.UseVisualStyleBackColor = true;
            // 
            // radioButtonWork4
            // 
            radioButtonWork4.AutoSize = true;
            radioButtonWork4.ForeColor = Color.Black;
            radioButtonWork4.Location = new Point(284, 83);
            radioButtonWork4.Name = "radioButtonWork4";
            radioButtonWork4.Size = new Size(118, 24);
            radioButtonWork4.TabIndex = 3;
            radioButtonWork4.TabStop = true;
            radioButtonWork4.Text = "От 5 до 9 лет";
            radioButtonWork4.UseVisualStyleBackColor = true;
            // 
            // radioButtonWork3
            // 
            radioButtonWork3.AutoSize = true;
            radioButtonWork3.ForeColor = Color.Black;
            radioButtonWork3.Location = new Point(284, 38);
            radioButtonWork3.Name = "radioButtonWork3";
            radioButtonWork3.Size = new Size(118, 24);
            radioButtonWork3.TabIndex = 2;
            radioButtonWork3.TabStop = true;
            radioButtonWork3.Text = "От 1 до 5 лет";
            radioButtonWork3.UseVisualStyleBackColor = true;
            // 
            // radioButtonWork2
            // 
            radioButtonWork2.AutoSize = true;
            radioButtonWork2.ForeColor = Color.Black;
            radioButtonWork2.Location = new Point(29, 83);
            radioButtonWork2.Name = "radioButtonWork2";
            radioButtonWork2.Size = new Size(135, 24);
            radioButtonWork2.TabIndex = 1;
            radioButtonWork2.TabStop = true;
            radioButtonWork2.Text = "Меньше 1 года";
            radioButtonWork2.UseVisualStyleBackColor = true;
            // 
            // radioButtonWork1
            // 
            radioButtonWork1.AutoSize = true;
            radioButtonWork1.ForeColor = Color.Black;
            radioButtonWork1.Location = new Point(29, 38);
            radioButtonWork1.Name = "radioButtonWork1";
            radioButtonWork1.Size = new Size(167, 24);
            radioButtonWork1.TabIndex = 0;
            radioButtonWork1.TabStop = true;
            radioButtonWork1.Text = "Прежде не работал";
            radioButtonWork1.UseVisualStyleBackColor = true;
            // 
            // groupBoxOther
            // 
            groupBoxOther.Controls.Add(checkBox6);
            groupBoxOther.Controls.Add(checkBox5);
            groupBoxOther.Controls.Add(checkBox4);
            groupBoxOther.Controls.Add(checkBox3);
            groupBoxOther.Controls.Add(label10);
            groupBoxOther.Controls.Add(checkBox2);
            groupBoxOther.Controls.Add(checkBox1);
            groupBoxOther.Location = new Point(39, 550);
            groupBoxOther.Name = "groupBoxOther";
            groupBoxOther.Size = new Size(296, 169);
            groupBoxOther.TabIndex = 17;
            groupBoxOther.TabStop = false;
            groupBoxOther.Text = "Другие сведения";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(156, 111);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(42, 24);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "D";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(109, 111);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(40, 24);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "C";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(54, 112);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(40, 24);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "B";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(7, 111);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(41, 24);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "А";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 87);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 2;
            label10.Text = "Категория прав";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(8, 60);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(229, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Водителькое удостоверение";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 30);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(189, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Наличие личного авто";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(362, 550);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 70);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Объем заработной платы";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(250, 29);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(38, 29);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(216, 34);
            label12.Name = "label12";
            label12.Size = new Size(28, 20);
            label12.TabIndex = 8;
            label12.Text = "До";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(6, 34);
            label11.Name = "label11";
            label11.Size = new Size(26, 20);
            label11.TabIndex = 7;
            label11.Text = "От";
            label11.Click += label11_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(362, 626);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(410, 93);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Предпочитаемый график работы";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.Black;
            radioButton3.Location = new Point(197, 56);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(161, 24);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "посменная работа";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.ForeColor = Color.Black;
            radioButton4.Location = new Point(197, 26);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(173, 24);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "частичная занятость";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(6, 56);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(139, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "работа на дому";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(6, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(153, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "полная занятость";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(39, 734);
            label13.Name = "label13";
            label13.Size = new Size(124, 20);
            label13.TabIndex = 20;
            label13.Text = "Краткое резюме";
            label13.Click += label13_Click;
            // 
            // button1
            // 
            button1.Location = new Point(299, 904);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 21;
            button1.Text = "Сохранить данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(637, 904);
            button2.Name = "button2";
            button2.Size = new Size(144, 29);
            button2.TabIndex = 22;
            button2.Text = "Очистить форму";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(39, 757);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(742, 130);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 945);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxOther);
            Controls.Add(groupBoxWork);
            Controls.Add(comboBoxPhone);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(comboBoxCity);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBoxBirthDay);
            Controls.Add(groupBoxSex);
            Controls.Add(textBoxPatronymic);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(textBoxSurname);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxSex.ResumeLayout(false);
            groupBoxSex.PerformLayout();
            groupBoxBirthDay.ResumeLayout(false);
            groupBoxBirthDay.PerformLayout();
            groupBoxWork.ResumeLayout(false);
            groupBoxWork.PerformLayout();
            groupBoxOther.ResumeLayout(false);
            groupBoxOther.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxPatronymic;
        private Label label3;
        private RadioButton radioButtonSexFem;
        private RadioButton radioButtonSexMen;
        private GroupBox groupBoxSex;
        private GroupBox groupBoxBirthDay;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBoxCity;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private ComboBox comboBoxPhone;
        private GroupBox groupBoxWork;
        private RadioButton radioButtonWork5;
        private RadioButton radioButtonWork4;
        private RadioButton radioButtonWork3;
        private RadioButton radioButtonWork2;
        private RadioButton radioButtonWork1;
        private GroupBox groupBoxOther;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Label label10;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private Label label12;
        private Label label11;
        private GroupBox groupBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label13;
        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label5;
        private Label label4;
        private RichTextBox richTextBox1;
    }
}