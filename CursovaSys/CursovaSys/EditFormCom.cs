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
    public partial class EditFormCom : Form
    {
        private int id;
        readonly bool edit;
        public EditFormCom()
        {
            InitializeComponent();
            командаTableAdapter.Fill(sportMainDataSet.Команда);
            edit = false;
        }
        public EditFormCom(int id, string Name, string country, string city, DateTime date) : this()
        {
            командаTableAdapter.Fill(sportMainDataSet.Команда);

            edit = true;
            this.id = id;
            textBox_Name.Text = Name;
            textBox_Country.Text = country;
            textBox_City.Text = city;
            dateTimePicker_DOB.Value = date;
        }
        private void EditFormCom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportMainDataSet.Команда' table. You can move, or remove it, as needed.
            this.командаTableAdapter.Fill(this.sportMainDataSet.Команда);

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_City.Text == "" || textBox_Country.Text == "" || textBox_Name.Text == "")
            {
                MessageBox.Show("Ви заповнили не усі поля");
                return;
            }
            if (edit)
            {
                командаTableAdapter.UpdateQuery(textBox_Name.Text, textBox_Country.Text, textBox_City.Text,
                    dateTimePicker_DOB.Value.ToString(), id);
            }
            else
            {
                командаTableAdapter.Insert(textBox_Name.Text, textBox_Country.Text, textBox_City.Text,
                    dateTimePicker_DOB.Value);
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
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
