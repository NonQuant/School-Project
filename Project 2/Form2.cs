using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private bool finder(char elem, string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == elem)
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string small = "abcdefghijklmnopqrstuvwxyz", big = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                         num = "1234567890", symbols = "_@#$%!";
            bool c1 = false, c2 = false, c3 = false, c4 = false;
            string password = textBox1.Text;
            if (password == "")
            {
                MessageBox.Show("Пожалуйста, введите пароль");
                return;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (finder(password[i], big))
                {
                    c1 = true;
                }
                if (finder(password[i], small))
                {
                    c2 = true;
                }
                if (finder(password[i], symbols))
                {
                    c3 = true;
                }
                if (finder(password[i], num))
                {
                    c4 = true;
                }
            }
            label2.BackColor = Color.LightCoral;
            label2.ForeColor = Color.Black;
            if (!c1){
                label2.Text = "В вашем пароле нет заглавной буквы!";
            }

            else if (!c2){
                label2.Text = "В вашем пароле нет строчной буквы!";
            }

            else if (!c4){
                label2.Text = "В вашем пароле нет цифры!";
            }

            else if (!c3){
                label2.Text = "В вашем пароле нет другого символа!";
            }

            else if (password.Length < 10)
            {
                label2.Text = "Ваш пароль слишком короткий!(должно быть 10 символов)";
            }
            else
            {
                label2.Text = "Ваш пароль надежный!";
                label2.BackColor = Color.LimeGreen;
            }
            label2.Visible = true;

        }
    }
}
