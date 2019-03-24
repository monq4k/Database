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
    public partial class EditFormResSport : Form
    {
        private int id;
        readonly bool edit;
        public EditFormResSport()
        {
            InitializeComponent();
            результат_СпортсменаTableAdapter.Fill(sportMainDataSet.Результат_Спортсмена);
            дисциплінаTableAdapter.Fill(this.sportMainDataSet.Дисципліна);
            спорткомітетTableAdapter.Fill(this.sportMainDataSet.Спорткомітет);
            edit = false;
        }
        public EditFormResSport(int id, int Sportsmen, int Disciplina, string Result) : this()
        {
            дисциплінаTableAdapter.Fill(this.sportMainDataSet.Дисципліна);
            спорткомітетTableAdapter.Fill(this.sportMainDataSet.Спорткомітет);
            edit = true;
            this.id = id;
            comboBox_Sportsmen.SelectedValue = Sportsmen;
            comboBox_Disciplina.SelectedValue = Disciplina;
            textBox_Result.Text = Result;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "" || comboBox_Disciplina.Text == "" || comboBox_Sportsmen.Text == "")
            {
                MessageBox.Show("Ви заповнили не усі поля");
                return;
            }
            if (edit)
            {
                результат_СпортсменаTableAdapter.UpdateQuery(Convert.ToInt32(comboBox_Sportsmen.SelectedValue), Convert.ToInt32(comboBox_Disciplina.SelectedValue),
                     textBox_Result.Text, id);
            }
            else
            {
                результат_СпортсменаTableAdapter.Insert(Convert.ToInt32(comboBox_Sportsmen.SelectedValue), Convert.ToInt32(comboBox_Disciplina.SelectedValue),
                    textBox_Result.Text);
            }
            Close();
        }

        private void EditFormResSport_Load(object sender, EventArgs e)
        {
        }

        private void textBox_Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
