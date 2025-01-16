using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kraev
{
    public partial class auth : Form
    {

        private static string currentcapcha = String.Empty;

     


        private bool passchar = false;
        public auth()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Логин";
            textBox1.ForeColor = Color.FromArgb(000000);
            textBox2.Text = "Пароль";
            textBox2.ForeColor = Color.FromArgb(000000);

            currentcapcha = Capcha.GenerateCaptcha();
            Bitmap capchaImg = Capcha.DrawCaptcha(currentcapcha);
            PB.Image = capchaImg;

        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Логин")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Логин";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Пароль")
            {
                textBox2.Text = "";
            }
            if (passchar) { textBox2.PasswordChar = '*'; }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Пароль";
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            passchar = !passchar;
            if (passchar) { textBox2.PasswordChar = '*'; }
            else { textBox2.PasswordChar = '\0'; }
        }

        private void confirmCapchaButton_Click(object sender, EventArgs e)
        {
            if (currentcapcha == capchaTextBox.Text)
            {
                MessageBox.Show("Капча введена верно");
            }
            else
            {
                MessageBox.Show("Капча введена не правильно, система заблокиравана на 10 секунд");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user" && textBox2.Text == "user") { Main m = new Main(); m.ShowDialog(); }
        }
    }
}
