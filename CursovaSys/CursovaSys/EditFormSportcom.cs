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
    public partial class EditFormSportcom : Form
    {
        private int id;
        readonly bool edit;
        public EditFormSportcom()
        {
            InitializeComponent();
            спорткомітетTableAdapter.Fill(sportMainDataSet.Спорткомітет);
            спортсменTableAdapter.Fill(this.sportMainDataSet.Спортсмен);
            результат_СпортсменаTableAdapter.Fill(this.sportMainDataSet.Результат_Спортсмена);
            командаTableAdapter.Fill(this.sportMainDataSet.Команда);
            турнірTableAdapter.Fill(this.sportMainDataSet.Турнір);
            edit = false;
        }
        public EditFormSportcom(int id, int Sportsmen, int Komanda, int Tournir) : this()
        {
            спорткомітетTableAdapter.Fill(sportMainDataSet.Спорткомітет);
            спортсменTableAdapter.Fill(sportMainDataSet.Спортсмен);

            edit = true;
            this.id = id;
            comboBox_Sportsmen.SelectedValue = Sportsmen;
            comboBox_Komanda.SelectedValue = Komanda;
            comboBox_Tournir.SelectedValue = Tournir;
        }
        private void EditFormSportcom_Load(object sender, EventArgs e)
        {
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (comboBox_Sportsmen.Text == "" || comboBox_Komanda.Text == "" || comboBox_Tournir.Text == "")
            {
                MessageBox.Show("Ви заповнили не усі поля");
                return;
            }
            if (edit)
            {
                спорткомітетTableAdapter.UpdateQuery(Convert.ToInt32(comboBox_Sportsmen.SelectedValue), 
                    Convert.ToInt32(comboBox_Komanda.SelectedValue),
                    Convert.ToInt32(comboBox_Tournir.SelectedValue), id);
            }
            else
            {
                спорткомітетTableAdapter.Insert(Convert.ToInt32(comboBox_Sportsmen.SelectedValue),
                    Convert.ToInt32(comboBox_Komanda.SelectedValue), Convert.ToInt32(comboBox_Tournir.SelectedValue));
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
