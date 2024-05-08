using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIR_TICKET_BOOKING
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 DAL = new Class1();
            bool check = DAL.login(textBox1.Text,textBox2.Text);
            if (check==true) 
            {
                progressBar1.Show();
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 5000000;
                for (int i=0;i<= 5000000;i++)
                {
                    progressBar1.Value = i;
                }
                this.Hide();
                Form3 abc = new Form3();
                abc.Show();
            }
            else
            {
                MessageBox.Show("YOU INSERT INVALID USER NAME OR PASSWORD......!!!!!","ERROR");
                textBox1.Clear();
                textBox2.Clear();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fff = new Form1();
            fff.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
