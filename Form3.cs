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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 def = new Form4();
            def.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 efg = new Form5();
            efg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 hij = new Form6();
            hij.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 klm = new Form7();
            klm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 kjl = new Form2();
            kjl.Show();
        }
    }
}
