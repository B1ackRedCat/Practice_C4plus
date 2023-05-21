namespace Task4
{
    public partial class Form1 : Form
    {
        List<Button> buttons;
        List<TextBox> textBoxs;
        List<Label> labels;

        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>();
            textBoxs = new List<TextBox>();
            labels = new List<Label>();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(XInput.Text);
            int y = Convert.ToInt32(YInput.Text);
            switch (CodeInput.Text)
            {
                case "К":
                    Button tempBtn = new Button();
                    tempBtn.Location = new Point(x, y);
                    tempBtn.Text = "Кнопка";
                    tempBtn.Height = 30;
                    tempBtn.Width = 95;
                    tempBtn.MouseHover += new EventHandler(HoverElem);
                    buttons.Add(tempBtn);
                    Controls.Add(buttons[buttons.Count-1]);
                    break;
                case "П":
                    TextBox tempTxtBox = new TextBox();
                    tempTxtBox.Location = new Point(x, y);
                    tempTxtBox.Text = "Поле ввода";
                    tempTxtBox.Height = 30;
                    tempTxtBox.Width = 95;
                    tempTxtBox.MouseHover += new EventHandler(HoverElem);
                    textBoxs.Add(tempTxtBox);
                    Controls.Add(textBoxs[textBoxs.Count-1]);
                    break;
                case "М":
                    Label tempLbl = new Label();
                    tempLbl.Location = new Point(x, y);
                    tempLbl.Text = "Метка";
                    tempLbl.Height = 30;
                    tempLbl.Width = 95;
                    tempLbl.MouseHover += new EventHandler(HoverElem);
                    labels.Add(tempLbl);
                    Controls.Add(labels[labels.Count - 1]);
                    break;
            }
        }

        private void HoverElem(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                buttons.Remove(buttons.Where(x => x.Location == ((Button)sender).Location).First());
                ((Button)sender).Dispose();
            }
            if (sender is TextBox)
            {
                textBoxs.Remove(textBoxs.Where(x => x.Location == ((TextBox)sender).Location).First());
                ((TextBox)sender).Dispose();
            }
            if (sender is Label)
            {
                labels.Remove(labels.Where(x => x.Location == ((Label)sender).Location).First());
                ((Label)sender).Dispose();
            }
        }
    }
}