using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Programming2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < 6; i++)
            {
                EnumsListBox.Items.Add((Programming2.Enums.Enums1)i);
            }

            EnumsListBox.SetSelected(0, true);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            Array enumValues;
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Enums1.Colors:
                    enumValues = Enum.GetValues(typeof(Colors.Colors1));
                    foreach (Colors.Colors1 value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Enums1.Weekday:
                    enumValues = Enum.GetValues(typeof(Weekday.Weekday1));
                    foreach (Weekday.Weekday1 value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Enums1.Season:
                    enumValues = Enum.GetValues(typeof(Season.Season1));
                    foreach (Season.Season1 value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Enums1.Manufactures:
                    enumValues = Enum.GetValues(typeof(Manufactures.Manufactures1));
                    foreach (Manufactures.Manufactures1 value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Enums1.Genre:
                    enumValues = Enum.GetValues(typeof(Genre.Genre1));
                    foreach (Genre.Genre1 value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Enums1.EducationForm:
                    enumValues = Enum.GetValues(typeof(EducationForm.EducationForm1));
                    foreach (EducationForm.EducationForm1 value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
            
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}