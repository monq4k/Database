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
    public partial class Form_Enter : Form
    {
        public Form_Enter()
        {
            InitializeComponent();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "admin" && textBox_Password.Text == "admin")
            {
                Form_Main f = new Form_Main();
                f.Show();
                this.Hide();
            }
            else if (textBox_Login.Text == "" || textBox_Login.Text == " " || textBox_Password.Text == "" || textBox_Password.Text == " ")
            {
                label_Error.Visible = true;
                label_Error.Text = "Не всі поля заповнені!";
            }
            else
            {
                label_Error.Visible = true;
                label_Error.Text = "Не правильний логін або пароль!";
            }
        }

        private void Form_Enter_Load(object sender, EventArgs e)
        {

        }

        private void Form_Enter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
