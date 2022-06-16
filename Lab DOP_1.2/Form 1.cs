using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_DOP_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form2_Paint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;          
            Point[] pts2 = { new Point(0, Height / 2), new Point(Width / 2, 0), new Point(Width, Height / 2), new Point(Width / 2, Height) };
            gr.FillPolygon(Brushes.Green, pts2);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;//цвет фона  
            this.TransparencyKey = this.BackColor;//он же будет заменен на прозрачный цвет
        }
    }
}
