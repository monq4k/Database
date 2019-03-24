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
    public partial class EditFormTurnir : Form
    {
        private int id;
        readonly bool edit;
        public EditFormTurnir()
        {
            InitializeComponent();
            турнірTableAdapter.Fill(sportMainDataSet.Турнір);
            місцеположення_турніруTableAdapter.Fill(this.sportMainDataSet.Місцеположення_турніру);
            edit = false;
        }
        public EditFormTurnir(int id, string VidSporta, int Misce, string Kolvo, DateTime dateNach, DateTime dateKonca) : this()
        {
            турнірTableAdapter.Fill(sportMainDataSet.Турнір);
            edit = true;
            this.id = id;
            switch (VidSporta)
            {
                case "Індивідуальний":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "Командний":
                    comboBox1.SelectedIndex = 1;
                    break;
                default:
                    comboBox1.SelectedIndex = 0;
                    break;
            }
            comboBox_Misce.SelectedValue = Misce;
            textBox_Kilkist.Text = Kolvo;
            dateTimePicker_NACALO.Value = dateNach;
            dateTimePicker_KONEC.Value = dateKonca;
        }
        private void EditFormTurnir_Load(object sender, EventArgs e)
        {
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string vid = "";
            if (comboBox1.SelectedIndex == 0)
            {
                vid = "Індивідуальний";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                vid = "Командний";
            }
            if (comboBox1.Text == "" || comboBox_Misce.Text == "" || textBox_Kilkist.Text == "")
            {
                MessageBox.Show("Ви заповнили не усі поля");
                return;
            }
            if (dateTimePicker_NACALO.Value > dateTimePicker_KONEC.Value)
            {
                MessageBox.Show("Дата початку більша за дату кінця!");
                return;
            }
            if (dateTimePicker_NACALO.Value == dateTimePicker_KONEC.Value)
            {
                MessageBox.Show("Дата початку більша за дату кінця!");
                return;
            }
            if (edit)
            {
                турнірTableAdapter.UpdateQuery(vid, Convert.ToInt32(comboBox_Misce.SelectedValue),
                    Convert.ToInt32(textBox_Kilkist.Text), dateTimePicker_NACALO.Value.ToString(),dateTimePicker_KONEC.Value.ToString(), id);
            }
            else
            {
                турнірTableAdapter.Insert(vid, Convert.ToInt32(comboBox_Misce.SelectedValue),
                    Convert.ToInt32(textBox_Kilkist.Text), dateTimePicker_NACALO.Value, dateTimePicker_KONEC.Value);
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_Kilkist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
