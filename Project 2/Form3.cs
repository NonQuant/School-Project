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
    public partial class Form3 : Form
    {
        public Form3()
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
            string all = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_@#$%!";
            string small = "abcdefghijklmnopqrstuvwxyz", big = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string nums = "1234567890", symbols = "_@#$%!";
            string a = "";
            char elem;
            int elem_num;
            Random random = new Random(DateTime.Now.Second);

            elem_num = random.Next(0, big.Length);
            elem = big[elem_num];
            a = a + elem;

            elem_num = random.Next(0, small.Length);
            elem = small[elem_num];
            a = a + elem;

            elem_num = random.Next(0, symbols.Length);
            elem = symbols[elem_num];
            a = a + elem;

            elem_num = random.Next(0, nums.Length);
            elem = nums[elem_num];
            a = a + elem;

            for (int i = 0; i < 6; i++)
            {
                elem_num = random.Next(0, all.Length);
                elem = all[elem_num];
                a = a + elem;
            }
            textBox1.Text = a;
            textBox1.Visible = true;
            label1.Visible = true;
        }
    }
}
