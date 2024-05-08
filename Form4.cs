using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AIR_TICKET_BOOKING
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection aaa = new SqlConnection(@"Data Source=DESKTOP-7IRF0GL\MUNEEBSQLSERVER;Initial Catalog=Air_ticket_system;Integrated Security=True");
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         
            string payment_method = "";
           
            if(checkBox1.Checked)
            {

                payment_method = "Easypaisa";
                
                
            }
            else if (checkBox2.Checked) 
            {
                payment_method = "Master Card";
            }
            else if(checkBox3.Checked)
            {
                payment_method = "Visa Card";
                
            }
            SqlCommand hhh = new SqlCommand(@"insert into Round_trip([Passport ID],Name,[Choose Departure],[Choose Arrival],[Number Passenger],[Selection of Class According to price],[Departure Date],[Arrival Date],[Payment Method]) values('" + textBox1.Text+ "','" + textBox2.Text + "','" + comboBox1.SelectedItem + "','" + comboBox2.SelectedItem + "','" +comboBox3.SelectedItem+"','" + comboBox4.SelectedItem + "','" +  textBox3.Text + "','" + textBox4.Text+ "','" + payment_method+ "')", aaa);
            aaa.Open();
            hhh.ExecuteNonQuery();
            aaa.Close();
            MessageBox.Show("YOUR SEAT HAS BEEN RESERVED.....!!", "DATA SAVE");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox4.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 bck = new Form3();
            bck.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
