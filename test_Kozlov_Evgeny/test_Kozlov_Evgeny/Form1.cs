using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_Kozlov_Evgeny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                if(textBox2.Text == "admin")
                {
                    Form2 a = new Form2();
                    a.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
