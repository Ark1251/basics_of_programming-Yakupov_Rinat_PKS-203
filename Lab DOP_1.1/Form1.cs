using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_DOP_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath MyPath = new System.Drawing.Drawing2D.GraphicsPath();
            MyPath.AddEllipse(0, 0, this.Width, this.Height);
            Region MyRegion = new Region(MyPath);
            this.Region = MyRegion;
        }
    }
}
