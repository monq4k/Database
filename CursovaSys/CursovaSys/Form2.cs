using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace CursovaSys
{
    public partial class Form_Main : Form
    {
        //const string ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SportMain.mdf;Integrated Security=True";
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = спортсменBindingSource;
            label_NameTable.Text = "Спортсмени";
            // TODO: This line of code loads data into the 'sportMainDataSet3.Результат_команди' table. You can move, or remove it, as needed.
            this.результат_командиTableAdapter.Fill(this.sportMainDataSet3.Результат_команди);
            // TODO: This line of code loads data into the 'sportMainDataSet3.Результат_Спортсмена' table. You can move, or remove it, as needed.
            this.результат_СпортсменаTableAdapter.Fill(this.sportMainDataSet3.Результат_Спортсмена);
            // TODO: This line of code loads data into the 'sportMainDataSet3.Спорткомітет' table. You can move, or remove it, as needed.
            this.спорткомітетTableAdapter.Fill(this.sportMainDataSet3.Спорткомітет);
            // TODO: This line of code loads data into the 'sportMainDataSet3.Турнір' table. You can move, or remove it, as needed.
            this.турнірTableAdapter.Fill(this.sportMainDataSet3.Турнір);
            // TODO: This line of code loads data into the 'sportMainDataSet3.Спортсмен' table. You can move, or remove it, as needed.
            this.спортсменTableAdapter1.Fill(this.sportMainDataSet3.Спортсмен);
            // TODO: This line of code loads data into the 'sportMainDataSet3.Команда' table. You can move, or remove it, as needed.
            this.командаTableAdapter1.Fill(this.sportMainDataSet3.Команда);
            // TODO: This line of code loads data into the 'sportMainDataSet2.Команда' table. You can move, or remove it, as needed.
            dataGridView_Table.AutoGenerateColumns = true;
            comboBox_Filter.Items.Add("---немає---");
            comboBox_Filter.Items.Add("ПІБ");
            comboBox_Filter.Items.Add("Країна_спортсмена");
            comboBox_Filter.Items.Add("Місто_спортсмена");
            comboBox_Filter.Items.Add("Стать");
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void SportsMenu_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = спортсменBindingSource;
            dataGridView_Table.DataSource = спортсменBindingSource;
            label_NameTable.Text = "Спортсмени";
            comboBox_Filter.Items.Clear();
            comboBox_Filter.Items.Add("---немає---");
            comboBox_Filter.Items.Add("ПІБ");
            comboBox_Filter.Items.Add("Країна_спортсмена");
            comboBox_Filter.Items.Add("Місто_спортсмена");
            comboBox_Filter.Items.Add("Стать");
        }

        private void ComandMenu_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = командаBindingSource;
            dataGridView_Table.DataSource = командаBindingSource;
            label_NameTable.Text = "Команди";
            comboBox_Filter.Items.Clear();
            comboBox_Filter.Items.Add("---немає---");
            comboBox_Filter.Items.Add("Назва");
            comboBox_Filter.Items.Add("Країна_команди");
            comboBox_Filter.Items.Add("Місто_команди");
        }
        private void TournamentMenu_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = турнірBindingSource;
            dataGridView_Table.DataSource = турнірBindingSource;
            label_NameTable.Text = "Турніри";
            comboBox_Filter.Items.Clear();
            comboBox_Filter.Items.Add("---немає---");
            comboBox_Filter.Items.Add("Вид_спорту");
        }
        private void спорткомітетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = спорткомітетBindingSource;
            dataGridView_Table.DataSource = спорткомітетBindingSource;
            label_NameTable.Text = "Спорткомітет";
        }
        private void длярозробниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.Show();
        }
        private void результатиСпортсменівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = результатСпортсменаBindingSource;
            dataGridView_Table.DataSource = результатСпортсменаBindingSource;
            label_NameTable.Text = "Результати спортсменів";
        }
        private void результатиКомандToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = результаткомандиBindingSource;
            dataGridView_Table.DataSource = результаткомандиBindingSource;
            label_NameTable.Text = "Результати команд";
        }
        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Enter f = new Form_Enter();
            f.Show();
        }
        //поиск
        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Search.Text == "" || textBox_Search.Text == " ")
            {
                for (int i = 0; i < dataGridView_Table.RowCount; i++)
                {
                    dataGridView_Table.Rows[i].Selected = false;
                }
            }
            else
            {
                for (int i = 0; i < dataGridView_Table.RowCount; i++)
                {
                    dataGridView_Table.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView_Table.ColumnCount; j++)
                        if (dataGridView_Table.Rows[i].Cells[j].Value != null)
                            if (dataGridView_Table.Rows[i].Cells[j].Value.ToString().Contains(textBox_Search.Text))
                            {
                                dataGridView_Table.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
        private bool edit = true;
        //добавление
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (dataGridView_Table.DataSource == спортсменBindingSource)
            {
                if (!edit) return;
                var edt = new EditForm();
                edt.ShowDialog();
                спортсменTableAdapter1.Fill(sportMainDataSet3.Спортсмен);
                sportMainDataSet3.AcceptChanges();
            }
            else if (dataGridView_Table.DataSource == командаBindingSource)
            {
                if (!edit) return;
                var edt = new EditFormCom();
                edt.ShowDialog();
                командаTableAdapter1.Fill(sportMainDataSet3.Команда);
                sportMainDataSet3.AcceptChanges();
            }
            else if (dataGridView_Table.DataSource == турнірBindingSource)
            {
                if (!edit) return;
                var edt = new EditFormTurnir();
                edt.ShowDialog();
                турнірTableAdapter.Fill(sportMainDataSet3.Турнір);
                sportMainDataSet3.AcceptChanges();
            }
            else if (dataGridView_Table.DataSource == спорткомітетBindingSource)
            {
                if (!edit) return;
                var edt = new EditFormSportcom();
                edt.ShowDialog();
                спорткомітетTableAdapter.Fill(sportMainDataSet3.Спорткомітет);
                sportMainDataSet3.AcceptChanges();
            }

            else if (dataGridView_Table.DataSource == результаткомандиBindingSource)
            {
                if (!edit) return;
                var edt = new EditFormResKom();
                edt.ShowDialog();
                результат_командиTableAdapter.Fill(sportMainDataSet3.Результат_команди);
                sportMainDataSet3.AcceptChanges();
            }

            else if (dataGridView_Table.DataSource == результатСпортсменаBindingSource)
            {
                if (!edit) return;
                var edt = new EditFormResSport();
                edt.ShowDialog();
                результат_СпортсменаTableAdapter.Fill(sportMainDataSet3.Результат_Спортсмена);
                sportMainDataSet3.AcceptChanges();
            }
        }
        //обновление
        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView_Table.DataSource == спортсменBindingSource)
            {
                if (!edit) return;
                var st = new SportMainDataSet.СпортсменDataTable();
                спортсменTableAdapter1.FillBy(st, Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditForm(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    Convert.ToDateTime(row[5])
                    );
                edt.ShowDialog();
                спортсменTableAdapter1.Fill(sportMainDataSet3.Спортсмен);
                sportMainDataSet3.AcceptChanges();
            }
            else if (dataGridView_Table.DataSource == командаBindingSource)
            {
                if (!edit) return;
                var st = new SportMainDataSet.КомандаDataTable();
                командаTableAdapter1.FillBy(st, Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditFormCom(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    Convert.ToDateTime(row[4])
                    );
                edt.ShowDialog();
                командаTableAdapter1.Fill(sportMainDataSet3.Команда);
                sportMainDataSet3.AcceptChanges();
            }
            else if (dataGridView_Table.DataSource == турнірBindingSource)
            {
                if (!edit) return;
                var st = new SportMainDataSet.ТурнірDataTable();
                турнірTableAdapter.FillBy(st, Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditFormTurnir(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    Convert.ToInt32(row[2]),
                    row[3].ToString(),
                    Convert.ToDateTime(row[4]),
                    Convert.ToDateTime(row[5])
                    );
                edt.ShowDialog();
                турнірTableAdapter.Fill(sportMainDataSet3.Турнір);
                sportMainDataSet3.AcceptChanges();
            }
            else if (dataGridView_Table.DataSource == спорткомітетBindingSource)
            {
                if (!edit) return;
                var st = new SportMainDataSet.СпорткомітетDataTable();
                спорткомітетTableAdapter.FillBy(st, Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditFormSportcom(
                    Convert.ToInt32(row[0]),
                    Convert.ToInt32(row[1]),
                    Convert.ToInt32(row[2]),
                    Convert.ToInt32(row[3])
                    );
                edt.ShowDialog();
                спорткомітетTableAdapter.Fill(sportMainDataSet3.Спорткомітет);
                sportMainDataSet3.AcceptChanges();
            }
            else if (dataGridView_Table.DataSource == результаткомандиBindingSource)
            {
                if (!edit) return;
                var st = new SportMainDataSet.Результат_командиDataTable();
                результат_командиTableAdapter.FillBy(st, Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditFormResKom(
                    Convert.ToInt32(row[0]),
                    Convert.ToInt32(row[1]),
                    Convert.ToInt32(row[2]),
                    Convert.ToInt32(row[3]),
                    row[4].ToString(),
                    row[5].ToString()
                    );
                edt.ShowDialog();
                результат_командиTableAdapter.Fill(sportMainDataSet3.Результат_команди);
                sportMainDataSet3.AcceptChanges();
            }
            else if (dataGridView_Table.DataSource == результатСпортсменаBindingSource)
            {
                if (!edit) return;
                var st = new SportMainDataSet.Результат_СпортсменаDataTable();
                результат_СпортсменаTableAdapter.FillBy(st, Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditFormResSport(
                    Convert.ToInt32(row[0]),
                    Convert.ToInt32(row[1]),
                    Convert.ToInt32(row[2]),
                    row[3].ToString()
                    );
                edt.ShowDialog();
                результат_СпортсменаTableAdapter.Fill(sportMainDataSet3.Результат_Спортсмена);
                sportMainDataSet3.AcceptChanges();
            }
        }
        //удаление
        private void button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вибрані дані будуть видалені без можливості відновлення, видалити дані?", "Увага!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridView_Table.DataSource == спортсменBindingSource)
                {
                    try
                    {
                        спортсменTableAdapter1.DeleteQuery(
                         Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value)
                         );
                        спортсменTableAdapter1.Fill(sportMainDataSet3.Спортсмен);
                        sportMainDataSet3.AcceptChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Ви не можете видалити дане поле!");
                    }
                }
                else if (dataGridView_Table.DataSource == командаBindingSource)
                {
                    try
                    {
                        командаTableAdapter1.DeleteQuery(
                         Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value)
                         );
                        командаTableAdapter1.Fill(sportMainDataSet3.Команда);
                        sportMainDataSet3.AcceptChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Ви не можете видалити дане поле!");
                    }
                }
                else if (dataGridView_Table.DataSource == турнірBindingSource)
                {
                    try
                    {
                        турнірTableAdapter.DeleteQuery(
                         Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value)
                         );
                        турнірTableAdapter.Fill(sportMainDataSet3.Турнір);
                        sportMainDataSet3.AcceptChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Ви не можете видалити дане поле!");
                    }
                }
                else if (dataGridView_Table.DataSource == спорткомітетBindingSource)
                {
                    try
                    {
                        спорткомітетTableAdapter.DeleteQuery(
                         Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value)
                         );
                        спорткомітетTableAdapter.Fill(sportMainDataSet3.Спорткомітет);
                        sportMainDataSet3.AcceptChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Ви не можете видалити дане поле!");
                    }
                }

                else if (dataGridView_Table.DataSource == результаткомандиBindingSource)
                {
                    try
                    {
                        результат_командиTableAdapter.DeleteQuery(
                         Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value)
                         );
                        результат_командиTableAdapter.Fill(sportMainDataSet3.Результат_команди);
                        sportMainDataSet3.AcceptChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Ви не можете видалити дане поле!");
                    }
                }

                else if (dataGridView_Table.DataSource == результатСпортсменаBindingSource)
                {
                    try
                    {
                        результат_СпортсменаTableAdapter.DeleteQuery(
                         Convert.ToInt32(dataGridView_Table.SelectedRows[0].Cells[0].Value)
                         );
                        результат_СпортсменаTableAdapter.Fill(sportMainDataSet3.Результат_Спортсмена);
                        sportMainDataSet3.AcceptChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Ви не можете видалити дане поле!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        //вызов окна статистика
        private void button2_Click(object sender, EventArgs e)
        {
            var stat = new Stat();
            stat.ShowDialog();
        }

        private void textBox_Search_Enter(object sender, EventArgs e)
        {
            if (textBox_Search.Text == "Пошук...")
            {
                textBox_Search.Text = "";

                textBox_Search.ForeColor = Color.Black;
            }
        }

        private void textBox_Search_Leave(object sender, EventArgs e)
        {
            if (textBox_Search.Text == "")
            {
                textBox_Search.Text = "Пошук...";

                textBox_Search.ForeColor = Color.Silver;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void допомогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("За допомогою пункту меню - 'Бази даних' можна перемикатися між таблицями" +
                ".\n\tДля редагування даних використовуйте кнопки: \n\t'Додати', щоб додати дані, \n\t'" +
                "Видалити' - для видалення даних, \n\t'Оновити' - оновити вже існуючі дані. Кнопка \n\t'Статистика' відкриває вікно статистики із спортивних змагань" +
                "яке дозволяє роздрукувати вже існуючі таблиці.", "Інформація");
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Роздрукувати звіт?", "Увага", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Excel.Application ExcelApp = new Excel.Application();
                Excel.Workbook ExcelWorkBook;
                Excel.Worksheet ExcelWorkSheet;
                //Книга.
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                //Таблица.
                ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

                for (int i = 0; i < dataGridView_Table.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView_Table.ColumnCount; j++)
                    {
                        ExcelApp.Cells[i + 1, j + 1] = dataGridView_Table.Rows[i].Cells[j].Value;
                    }
                }
                //Вызываем нашу созданную эксельку.
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        //фильтр
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Table.DataSource == спортсменBindingSource)
                {
                    string Category = "[" + comboBox_Filter.Text + "]";
                    string Value = comboBox_Value.Text;
                    спортсменBindingSource.Filter = Category + " LIKE'" + Value + "%'";
                }
                else if (dataGridView_Table.DataSource == командаBindingSource)
                {
                    string Category = "[" + comboBox_Filter.Text + "]";
                    string Value = comboBox_Value.Text;
                    командаBindingSource.Filter = Category + " LIKE'" + Value + "%'";
                }
                else if (dataGridView_Table.DataSource == турнірBindingSource)
                {
                    string Category = "[" + comboBox_Filter.Text + "]";
                    string Value = comboBox_Value.Text;
                    турнірBindingSource.Filter = Category + " LIKE'" + Value + "'";
                }
            }
            catch
            {
                MessageBox.Show("При виконанні фільтрації виникла помилка або стовпців з такими назвами не існує", "Помилка");
            }
        }

        private void comboBox_Filter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_Filter.Text == "ПІБ")
            {
                comboBox_Value.DataSource = спортсменBindingSource;
                comboBox_Value.DisplayMember = "ПІБ";
            }
            else if (comboBox_Filter.Text == "Стать")
            {
                comboBox_Value.DataSource = null;
                comboBox_Value.Items.Clear();
                comboBox_Value.Items.Add("Чоловік");
                comboBox_Value.Items.Add("Жінка");
            }
            else if (comboBox_Filter.Text == "Країна_спортсмена")
            {

                comboBox_Value.DataSource = спортсменBindingSource;
                comboBox_Value.DisplayMember = "Країна_спортсмена";
            }
            else if (comboBox_Filter.Text == "Місто_спортсмена")
            {
                comboBox_Value.DataSource = спортсменBindingSource;
                comboBox_Value.DisplayMember = "Місто_спортсмена";
            }
            else if (comboBox_Filter.Text == "Назва")
            {
                comboBox_Value.DataSource = командаBindingSource;
                comboBox_Value.DisplayMember = "Назва";
            }
            else if (comboBox_Filter.Text == "Країна_команди")
            {

                comboBox_Value.DataSource = командаBindingSource;
                comboBox_Value.DisplayMember = "Країна_команди";
            }
            else if (comboBox_Filter.Text == "Місто_країни")
            {
                comboBox_Value.DataSource = командаBindingSource;
                comboBox_Value.DisplayMember = "Місто_країни";
            }
            else if (comboBox_Filter.Text == "Вид_спорту")
            {
                comboBox_Value.DataSource = null;
                comboBox_Value.Items.Clear();
                comboBox_Value.Items.Add("Командний");
                comboBox_Value.Items.Add("Індивідуальний");
            }
        }
        //очистка фильтра
        private void button_CleanFilter_Click(object sender, EventArgs e)
        {
            comboBox_Value.DataSource = null;
            comboBox_Value.Items.Clear();
            спортсменBindingSource.Filter = null;
            командаBindingSource.Filter = null;
            турнірBindingSource.Filter = null;
            comboBox_Filter.Text = "---немає---";
        }




        //произвольные запросы

    }
}
