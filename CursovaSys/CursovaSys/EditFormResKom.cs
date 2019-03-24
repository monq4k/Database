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
    public partial class EditFormResKom : Form
    {
        private int id;
        readonly bool edit;
        public EditFormResKom()
        {
            InitializeComponent();
            результат_командиTableAdapter.Fill(sportMainDataSet.Результат_команди);
            edit = false;
        }
        public EditFormResKom(int id, int Komanda, int Disciplina, int Turnir, string Result, string Misce) : this()
        {
            результат_командиTableAdapter.Fill(sportMainDataSet.Результат_команди);
            дисциплінаTableAdapter.Fill(this.sportMainDataSet.Дисципліна);
            командаTableAdapter.Fill(this.sportMainDataSet.Команда);
            турнірTableAdapter.Fill(this.sportMainDataSet.Турнір);
            edit = true;
            this.id = id;
            comboBox_Disciplina.SelectedValue = Disciplina;
            comboBox_Turnir.SelectedValue = Turnir;
            textBox_Result.Text = Result;
            textBox_Misce.Text = Misce;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "" || textBox_Misce.Text == "" || comboBox_Disciplina.Text == "" || comboBox_Komand.Text == ""||comboBox_Turnir.Text == "")
            {
                MessageBox.Show("Ви заповнили не усі поля");
                return;
            }
            if (edit)
            {
                результат_командиTableAdapter.UpdateQuery(Convert.ToInt32(comboBox_Komand.SelectedValue), Convert.ToInt32(comboBox_Disciplina.SelectedValue),
                    Convert.ToInt32(comboBox_Turnir.SelectedValue), textBox_Result.Text, Convert.ToInt32(textBox_Misce.Text), id);
            }
            else
            {
                результат_командиTableAdapter.Insert(Convert.ToInt32(comboBox_Komand.SelectedValue), Convert.ToInt32(comboBox_Disciplina.SelectedValue),
                    Convert.ToInt32(comboBox_Turnir.SelectedValue), textBox_Result.Text, Convert.ToInt32(textBox_Misce.Text));
            }
            Close();
        }

        private void EditFormResKom_Load(object sender, EventArgs e)
        {
        }

        private void textBox_Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void textBox_Misce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
