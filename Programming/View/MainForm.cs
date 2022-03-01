using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Programming.Model
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            for(int i = 0; i < 6; i++)
            {
                EnumsListBox.Items.Add((Enums.Enums)i);
            }

            EnumsListBox.SetSelected(0, true);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            Array enumValues;
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Enums.Colors:
                    enumValues = Enum.GetValues(typeof(Colors.Colors));
                    foreach (Colors.Colors value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Enums.Weekday:
                    enumValues = Enum.GetValues(typeof(Weekday.Weekday));
                    foreach (Weekday.Weekday value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Enums.Season:
                    enumValues = Enum.GetValues(typeof(Season.Season));
                    foreach (Season.Season value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Enums.Manufactures:
                    enumValues = Enum.GetValues(typeof(Manufactures.Manufactures));
                    foreach (Manufactures.Manufactures value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Enums.Genre:
                    enumValues = Enum.GetValues(typeof(Genre.Genre));
                    foreach (Genre.Genre value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
                case Enums.Enums.EducationForm:
                    enumValues = Enum.GetValues(typeof(EducationForm.EducationForm));
                    foreach (EducationForm.EducationForm value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }

                    break;
            }
        }
    }
}