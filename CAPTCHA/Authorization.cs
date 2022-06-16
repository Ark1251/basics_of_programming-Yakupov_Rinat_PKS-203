using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPTCHA
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "ДвоичныйКот" && PasswordBox.Text == "0101")
            {
                FormToOpen F3 = new FormToOpen();
                F3.Show();
                this.Hide();
            }
            else
            {
                string message = " Вы ввели неверные данные. Введите Captcha и повторите попытку.";
                string title = "Окно ошибки";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    Captcha F2 = new Captcha();
                    F2.Show();
                    this.Hide();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label3.ForeColor = Color.Black;
            }
            else
            {
                label3.ForeColor = Color.Aqua;
            }
        }      
    }
}
