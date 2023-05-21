using System.Windows.Forms;

namespace task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GroupBox groupBox = groupBoxSex;
            string sexValue = "";
            foreach (var control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    sexValue = radioButton.Text;
                    break;
                }
                else sexValue = "[��� �� ������]";
            }

            GroupBox workExpirience = groupBoxWork;
            string exp = "";

            foreach (var control in workExpirience.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    exp = radioButton.Text;
                    break;
                }
                else exp = "[���� �� ������]";
            }

            GroupBox drivingFactor = groupBoxOther;

            string isCar;

            if (checkBox1.Checked) isCar = "��"; else isCar = "���";

            string isDriver;
            if (checkBox2.Checked) isDriver = "����";
            else isDriver = "�����������";

            decimal valueFrom = numericUpDown1.Value;
            decimal valueTo = numericUpDown2.Value;

            DateTime birth = dateTimePicker1.Value;
            richTextBox1.Text =
                $"{textBoxSurname.Text} " +
                $"{textBoxName.Text} " +
                $"{textBoxPatronymic.Text} " +
                $"\n���: {sexValue} " +
                $"\n���� ��������: {birth.ToString("dd.MM.yyyy")} " +
                $"\n�����: {comboBoxCity.Text} " +
                $"\n��. �����: {textBoxEmail.Text} " +
                $"\n���. �������: {comboBoxPhone.Text}, {textBoxPhone.Text} " +
                $"\n���� ������: {exp}. " +
                $"\n������������ �����: {isDriver}; ������� ����: {isCar}. " +
                $"\n�������� ��������: {valueFrom}-{valueTo}$";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}