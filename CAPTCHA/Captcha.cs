using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CAPTCHA
{
    public partial class Captcha : Form
    {
        Random rnd = new Random();
        
        public Captcha()
        {
            InitializeComponent();           
        }       
        private void Captcha_Load(object sender, EventArgs e)
        {
            CaptchaNumbers.Parent = CaptchaBackground;
            CaptchaNumbers.BackColor = Color.Transparent;
            int Pictures = rnd.Next(1, 6);
            int Numbers = rnd.Next(000000, 999999);
            CaptchaNumbers.Text =Numbers.ToString();
            
            switch(Pictures ) 
            {
                case 1:
                    CaptchaBackground.Image = Image.FromFile("CaptchaPictures/1.jpg");
                    CaptchaNumbers.ForeColor = Color.DarkGray;
                    break;
                case 2:
                    CaptchaBackground.Image = Image.FromFile("CaptchaPictures/2.jpg");
                    CaptchaNumbers.ForeColor = Color.White;
                    break;
                case 3:
                    CaptchaBackground.Image = Image.FromFile("CaptchaPictures/3.jpg");
                    CaptchaNumbers.ForeColor = Color.SkyBlue;
                    break;
                case 4:
                    CaptchaBackground.Image = Image.FromFile("CaptchaPictures/4.jpg");
                    CaptchaNumbers.ForeColor = Color.Red;
                    break;
                case 5:
                    CaptchaBackground.Image = Image.FromFile("CaptchaPictures/5.jpg");
                    CaptchaNumbers.ForeColor = Color.Yellow;
                    break;
                case 6:
                    CaptchaBackground.Image = Image.FromFile("CaptchaPictures/6.jpg");
                    CaptchaNumbers.ForeColor = Color.Blue;
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == CaptchaNumbers.Text)
            {
                Authorization F1 = new Authorization();
                F1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильно введена Captcha. Повторите попытку");
                int Pictures = rnd.Next(1, 6);
                int Numbers = rnd.Next(000000, 999999);
                CaptchaNumbers.Text = Numbers.ToString();
                switch (Pictures)
                {
                    case 1:
                        CaptchaBackground.Image = Image.FromFile("CaptchaPictures/1.jpg");
                        CaptchaNumbers.ForeColor = Color.DarkGray;
                        break;
                    case 2:
                        CaptchaBackground.Image = Image.FromFile("CaptchaPictures/2.jpg");
                        CaptchaNumbers.ForeColor = Color.White;
                        break;
                    case 3:
                        CaptchaBackground.Image = Image.FromFile("CaptchaPictures/3.jpg");
                        CaptchaNumbers.ForeColor = Color.SkyBlue;
                        break;
                    case 4:
                        CaptchaBackground.Image = Image.FromFile("CaptchaPictures/4.jpg");
                        CaptchaNumbers.ForeColor = Color.Red;
                        break;
                    case 5:
                        CaptchaBackground.Image = Image.FromFile("CaptchaPictures/5.jpg");
                        CaptchaNumbers.ForeColor = Color.Yellow;
                        break;
                    case 6:
                        CaptchaBackground.Image = Image.FromFile("CaptchaPictures/6.jpg");
                        CaptchaNumbers.ForeColor = Color.Blue;
                        break;
                }
            }
        }
    }
}
