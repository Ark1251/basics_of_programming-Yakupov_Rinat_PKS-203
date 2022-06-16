
namespace CAPTCHA
{
    partial class Captcha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CaptchaBackground = new System.Windows.Forms.PictureBox();
            this.CaptchaNumbers = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptchaBackground
            // 
            this.CaptchaBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CaptchaBackground.BackColor = System.Drawing.Color.White;
            this.CaptchaBackground.Location = new System.Drawing.Point(12, 12);
            this.CaptchaBackground.Name = "CaptchaBackground";
            this.CaptchaBackground.Size = new System.Drawing.Size(482, 115);
            this.CaptchaBackground.TabIndex = 0;
            this.CaptchaBackground.TabStop = false;
            // 
            // CaptchaNumbers
            // 
            this.CaptchaNumbers.BackColor = System.Drawing.Color.Transparent;
            this.CaptchaNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaptchaNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaptchaNumbers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptchaNumbers.ForeColor = System.Drawing.Color.Transparent;
            this.CaptchaNumbers.Location = new System.Drawing.Point(138, 34);
            this.CaptchaNumbers.Name = "CaptchaNumbers";
            this.CaptchaNumbers.Size = new System.Drawing.Size(211, 60);
            this.CaptchaNumbers.TabIndex = 1;
            this.CaptchaNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(172, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите Captcha";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(192, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Проверка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(507, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CaptchaNumbers);
            this.Controls.Add(this.CaptchaBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Captcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha";
            this.Load += new System.EventHandler(this.Captcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CaptchaBackground;
        private System.Windows.Forms.Label CaptchaNumbers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}