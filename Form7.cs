using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AIR_TICKET_BOOKING
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 aaa = new Class1();
            aaa.delete_round_trip(Convert.ToInt32(textBox2.Text));
            MessageBox.Show("YOUR RECORD HAS BEEN DELETED","DELETE");
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7IRF0GL\MUNEEBSQLSERVER;Initial Catalog=Air_ticket_system;Integrated Security=True");
            string ppp = "select * from Round_trip";
            SqlDataAdapter sear = new SqlDataAdapter(ppp,conn);
            conn.Open();
            DataTable ooo = new DataTable();
            sear.Fill(ooo);
            dataGridView1.DataSource = ooo;
            textBox1.Clear();
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 lmn = new Form3();
            lmn.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 asd = new Class1();
            asd.delete_one_way(Convert.ToInt32(textBox4.Text));
            MessageBox.Show("YOUR RECORD HAS BEEN DELETE","DELETE");
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connn = new SqlConnection(@"Data Source=DESKTOP-7IRF0GL\MUNEEBSQLSERVER;Initial Catalog=Air_ticket_system;Integrated Security=True");
            string ddd = "select * from one_way";
            SqlDataAdapter src = new SqlDataAdapter(ddd,connn);
            connn.Open();
            DataTable eee =new DataTable();
            src.Fill(eee);
            dataGridView2.DataSource = eee;
            textBox3.Clear();
            connn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sda = new SqlConnection(@"Data Source=DESKTOP-7IRF0GL\MUNEEBSQLSERVER;Initial Catalog=Air_ticket_system;Integrated Security=True");
            string mno = "select * from Hotel_Detail";
            SqlDataAdapter sreh = new SqlDataAdapter(mno,sda);
            sda.Open();
            DataTable bnm = new DataTable();
            sreh.Fill(bnm);
            dataGridView3.DataSource = bnm;
            textBox5.Clear();
            sda.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Class1 fgh = new Class1();
            fgh.delete_hotel_detail(Convert.ToInt32(textBox6.Text));
            MessageBox.Show("YOUR RECORD HAS BEEN DELETE", "DELETE");
            textBox4.Clear();
        }
    }
}