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
using System.Net;
using System.Net.Mail;
using System.IO;

namespace CursovaSys
{
    public partial class Stat : Form
    {
        //const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
        //C:\Users\Roman\Desktop\CursovaSys\CursovaSys\SportMain.mdf;Integrated Security=True";
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SportMain.mdf;Integrated Security=True";
        public Stat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_Numer.Text = "1";
            Random rand = new Random();
            textBox_ID.Text = Convert.ToString(rand.Next(1, 1000));
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter oda;
                oda = new SqlDataAdapter(@"SELECT T.id_Турніру, COUNT(S.id_Спортсмена) as Кількість_спортсменів
                FROM Спортсмен S, Спорткомітет SPK, Турнір T
                WHERE S.id_Спортсмена = SPK.id_Спортсмена
                AND SPK.id_Турніру = T.id_Турніру
                GROUP BY T.id_Турніру", sqlconn);
                oda.Fill(dt);
                dataGridView_Zvit.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_Numer.Text = "2";
            Random rand = new Random();
            textBox_ID.Text = Convert.ToString(rand.Next(1, 1000));
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter oda;
                oda = new SqlDataAdapter(@"Select Т.id_Турніру,Т.Вид_спорту, М.Країна, М.Місто, М.Назва FROM Турнір Т, Місцеположення_турніру М 
            WHERE М.id_Місця = Т.Місце_проведення", sqlconn);
                oda.Fill(dt);
                dataGridView_Zvit.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Роздрукувати звіт?", "Увага", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Excel.Application ExcelApp = new Excel.Application();
                Excel.Workbook ExcelWorkBook;
                //шапка
                ExcelWorkBook = ExcelApp.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 25;
                Excel.Range _excelCells1 = ExcelApp.get_Range("A1", "F2").Cells;
                _excelCells1.Merge(Type.Missing);
                ExcelApp.Cells[1, 1] = "ЗВІТ №" + textBox_ID.Text + " за " + DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");
                ExcelApp.Cells[1, 1].Font.Bold = true;
                ExcelApp.Cells[1, 1].Font.Size = 16;
                ExcelApp.Cells[1, 1].Font.Bold = true;
                ExcelApp.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                ExcelApp.Cells[1, 1].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                //Кол-во спортсменов на турнирах
                if (label_Numer.Text == "1")
                {
                    for (int k = 0; k < dataGridView_Zvit.ColumnCount; k++)
                    {
                        ExcelApp.Cells[4, 3 + k] = dataGridView_Zvit.Columns[k].HeaderText;
                        ExcelApp.Cells[4, 3 + k].Font.Size = 14;
                        ExcelApp.Cells[4, 3 + k].Font.Bold = true;
                    }

                    for (int i = 0; i < dataGridView_Zvit.ColumnCount; i++)
                        for (int j = 0; j < dataGridView_Zvit.RowCount - 1; j++)
                        {
                            ExcelApp.Cells[j + 5, i + 3] = dataGridView_Zvit[i, j].Value.ToString();
                            ExcelApp.Cells[j + 5, i + 3].Font.Size = 12;
                            ExcelApp.Cells[j + 5, i + 3].Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            ExcelApp.Cells[j + 5, i + 3].Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        }
                }
                //Инфа о турнирах
                if (label_Numer.Text == "2")
                {
                    for (int k = 0; k < dataGridView_Zvit.ColumnCount; k++)
                    {
                        ExcelApp.Cells[4, k + 1] = dataGridView_Zvit.Columns[k].HeaderText;
                        ExcelApp.Cells[4, k + 1].Font.Size = 14;
                        ExcelApp.Cells[4, k + 1].Font.Bold = true;
                    }

                    for (int i = 0; i < dataGridView_Zvit.ColumnCount; i++)
                        for (int j = 0; j < dataGridView_Zvit.RowCount - 1; j++)
                        {
                            ExcelApp.Cells[j + 5, i + 1] = dataGridView_Zvit[i, j].Value.ToString();
                            ExcelApp.Cells[j + 5, i + 1].Font.Size = 12;
                            ExcelApp.Cells[j + 5, i + 1].Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            ExcelApp.Cells[j + 5, i + 1].Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        }
                }
                //Індивідуали
                else if (label_Numer.Text == "3")
                {
                    for (int k = 0; k < dataGridView_Zvit.ColumnCount; k++)
                    {
                        ExcelApp.Cells[4, k + 1] = dataGridView_Zvit.Columns[k].HeaderText;
                        ExcelApp.Cells[4, k + 1].Font.Size = 14;
                        ExcelApp.Cells[4, k + 1].Font.Bold = true;
                    }

                    for (int i = 0; i < dataGridView_Zvit.ColumnCount; i++)
                        for (int j = 0; j < dataGridView_Zvit.RowCount - 1; j++)
                        {
                            ExcelApp.Cells[j + 5, i + 1] = dataGridView_Zvit[i, j].Value.ToString();
                            ExcelApp.Cells[j + 5, i + 1].Font.Size = 12;
                            ExcelApp.Cells[j + 5, i + 1].Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            ExcelApp.Cells[j + 5, i + 1].Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        }
                }
                //Командний
                else if (label_Numer.Text == "4")
                {
                    for (int k = 0; k < dataGridView_Zvit.ColumnCount; k++)
                    {
                        ExcelApp.Cells[4, k + 1] = dataGridView_Zvit.Columns[k].HeaderText;
                        ExcelApp.Cells[4, k + 1].Font.Size = 14;
                        ExcelApp.Cells[4, k + 1].Font.Bold = true;
                    }

                    for (int i = 0; i < dataGridView_Zvit.ColumnCount; i++)
                        for (int j = 0; j < dataGridView_Zvit.RowCount - 1; j++)
                        {
                            ExcelApp.Cells[j + 5, i + 1] = dataGridView_Zvit[i, j].Value.ToString();
                            ExcelApp.Cells[j + 5, i + 1].Font.Size = 12;
                            ExcelApp.Cells[j + 5, i + 1].Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                            ExcelApp.Cells[j + 5, i + 1].Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        }
                }
                Excel.Range _excelCells2 = ExcelApp.get_Range("A4", "F4").Cells;
                _excelCells2.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                _excelCells2.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                //Вызываем нашу созданную эксельку.
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void button_LichDelo_Click(object sender, EventArgs e)
        {
            label_Numer.Text = "3";
            Random rand = new Random();
            textBox_ID.Text = Convert.ToString(rand.Next(1, 1000));
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter oda;
                oda = new SqlDataAdapter(@"SELECT DISTINCT S.id_Спортсмена, ПІБ, Стать, 
                Країна_спортсмена, Місто_спортсмена, Дата_народження
                FROM Спортсмен S, Спорткомітет P,Турнір T
                WHERE S.id_Спортсмена = P.id_Спортсмена
                AND P.id_Турніру = T.id_Турніру
                AND Вид_спорту = N'Індивідуальний'", sqlconn);
                oda.Fill(dt);
                dataGridView_Zvit.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
        private void SqlCon(string query, DataGridView i)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SportMain.mdf;Integrated Security=True");
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            i.DataSource = dt;
            sqlconn.Close();
        }
        private void button_Send_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Відправити листи? Очікуйте близнько декілька секунд.", "Підтвердження", MessageBoxButtons.YesNo);
            bool flag = dialogResult == DialogResult.Yes;
            if (flag)
            {
                string query = @"SELECT DISTINCT S.id_Спортсмена, ПІБ, Стать, 
                Країна_спортсмена, Місто_спортсмена, Дата_народження, P.id_Турніру
                FROM Спортсмен S, Спорткомітет P,Турнір T
                WHERE S.id_Спортсмена = P.id_Спортсмена
                AND P.id_Турніру = T.id_Турніру
                AND Вид_спорту <> N'Індивідуальний'";
                this.SqlCon(query, this.dataGridView_Zvit);
                for (int i = 0; i < this.dataGridView_Zvit.RowCount-1; i++)
                {
                    MailAddress from = new MailAddress("roman.hryb@nure.ua", "Гриб Роман");
                    MailAddress to = new MailAddress("roman.hryb@nure.ua");
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "Ви перемогли!";
                    m.Body = "<h2>Запрошуємо вас, <i>" + this.dataGridView_Zvit.Rows[i].Cells[1].Value + "</i>, на офіційне відкриття турніру №" + this.dataGridView_Zvit.Rows[i].Cells[6].Value +" .Загальний збір відбувається у найближчу п'ятницу о 8:00. Успіхів!</h2>";
                    m.IsBodyHtml = true;
                    new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("roman.hryb@nure.ua", "qF9KsfU7"),
                        EnableSsl = true
                    }.Send(m);
                }
                MessageBox.Show("Листи успішно відправлені", "Успішно");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_Numer.Text = "4";
            Random rand = new Random();
            textBox_ID.Text = Convert.ToString(rand.Next(1, 1000));
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter oda;
                oda = new SqlDataAdapter(@"SELECT DISTINCT S.id_Спортсмена, ПІБ, Стать, 
                Країна_спортсмена, Місто_спортсмена, Дата_народження
                FROM Спортсмен S, Спорткомітет P,Турнір T
                WHERE S.id_Спортсмена = P.id_Спортсмена
                AND P.id_Турніру = T.id_Турніру
                AND Вид_спорту <> N'Індивідуальний'", sqlconn);
                oda.Fill(dt);
                dataGridView_Zvit.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
