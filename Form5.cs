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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection onwy = new SqlConnection(@"Data Source=DESKTOP-7IRF0GL\MUNEEBSQLSERVER;Initial Catalog=Air_ticket_system;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string pay_meth = "";
            if (checkBox1.Checked) 
            {
                pay_meth = "Easy paisa";
            }
            else if (checkBox2.Checked) 
            {
                pay_meth = "Master Card Credit";
            }
            else if (checkBox3.Checked)
            {
                pay_meth = "Visa Card";
            }
            SqlCommand cal = new SqlCommand(@"insert into one_way([Passport ID],Name,[Choose Departure],[Number Of Passenger],[Selection of Class According to Price],[Departure Date],[Payment Method]) values('"+textBox2.Text+ "','" + textBox1.Text + "','" + comboBox1.SelectedItem + "','" + comboBox2.SelectedItem + "','" + comboBox3.SelectedItem + "','" + textBox3.Text + "','" + pay_meth + "')",onwy);
            onwy.Open();
            cal.ExecuteNonQuery();
            onwy.Close();
            MessageBox.Show("YOUR SEAT HAS BEEN RESERVED","DATA SAVE");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 bvb = new Form3();
            bvb.Show();
        }

        
    }
}
