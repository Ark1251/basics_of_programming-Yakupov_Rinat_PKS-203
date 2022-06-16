using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAPTCHA
{
    public partial class FormToOpen : Form
    {
        public FormToOpen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Authorization F1 = new Authorization();
                F1.Show();
                this.Close();
            }
            else
            {
                Authorization F1 = new Authorization();
                F1.Show();
            }
        }
    }
}
