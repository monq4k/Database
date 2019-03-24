using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursovaSys
{
    public partial class EditForm : Form
    {
        private int id;
        readonly bool edit;
        public EditForm()
        {
            InitializeComponent();
            спортсменTableAdapter.Fill(sportMainDataSet.Спортсмен);
            edit = false;
        }
        public EditForm(int id, string PIB, string gender, string country, string city, DateTime date) : this()
        {
            спортсменTableAdapter.Fill(sportMainDataSet.Спортсмен);

            edit = true;
            this.id = id;
            textBox_PIB.Text = PIB;
            switch (gender)
            {
                case "Чоловік":
                    comboBox_Gender.SelectedIndex = 0;
                    break;
                case "Жінка":
                    comboBox_Gender.SelectedIndex = 1;
                    break;
            }
            textBox_Country.Text = country;
            textBox_City.Text = city;
            dateTimePicker_DOB.Value = date;
        }


        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportMainDataSet.Спортсмен' table. You can move, or remove it, as needed.
            this.спортсменTableAdapter.Fill(this.sportMainDataSet.Спортсмен);

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (comboBox_Gender.SelectedIndex == 0)
            {
                gender = "Чоловік";
            }
            else if (comboBox_Gender.SelectedIndex == 1)
            {
                gender = "Жінка";
            }
            if (textBox_City.Text == "" || textBox_Country.Text == "" || textBox_PIB.Text == "" || comboBox_Gender.Text == "")
            {
                MessageBox.Show("Ви заповнили не усі поля");
                return;
            }
            if (edit)
            {
                спортсменTableAdapter.UpdateQuery(textBox_PIB.Text, gender, textBox_Country.Text, textBox_City.Text,
                    dateTimePicker_DOB.Value.ToString(), id);
            }
            else
            {
                спортсменTableAdapter.Insert(textBox_PIB.Text, gender, textBox_Country.Text, textBox_City.Text,
                    dateTimePicker_DOB.Value);
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_PIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (Char.IsNumber(e.KeyChar));
        }

        private void textBox_Country_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (Char.IsNumber(e.KeyChar));
        }

        private void textBox_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (Char.IsNumber(e.KeyChar));
        }
    }
}
