using Programming2.Model;

namespace Programming2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Array initValues = System.Enum.GetValues(typeof(Enums));
            foreach (Enums value in initValues)
            {
                EnumsListBox.Items.Add(value);
            }
            

            EnumsListBox.SelectedIndex = 0;

            Array initSeasonValues = System.Enum.GetValues(typeof(Season));
            foreach (Season value in initSeasonValues)
            {
                SeasonNamesComboBox.Items.Add(value);
            }
            

            SeasonNamesComboBox.SelectedIndex = 0;

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            Array enumValues;
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Colors:
                    enumValues = Enum.GetValues(typeof(Colors));
                    foreach (Colors value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Weekday:
                    enumValues = Enum.GetValues(typeof(Weekday));
                    foreach (Weekday value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Season:
                    enumValues = Enum.GetValues(typeof(Season));
                    foreach (Season value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Manufactures:
                    enumValues = Enum.GetValues(typeof(Manufactures));
                    foreach (Manufactures value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Genre:
                    enumValues = Enum.GetValues(typeof(Genre));
                    foreach (Genre value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.EducationForm:
                    enumValues = Enum.GetValues(typeof(EducationForm));
                    foreach (EducationForm value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
            
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            textBox1.Text = ((int)item).ToString();
        }

        private void ParseWeekdayButton_Click(object sender, EventArgs e)
        {
            string textWeekdayTextBox = WeekdayTextBox.Text;
            Weekday value;
            if (Enum.TryParse(textWeekdayTextBox, out value))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({value} - {(int)value})"; //Change +1 => 0
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого дня недели";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonNamesComboBox.SelectedItem)
            {
                case Season.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }
    }
}