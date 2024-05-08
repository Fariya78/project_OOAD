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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 asd = new Form3();
            asd.Show();
        }
        SqlConnection hot = new SqlConnection(@"Data Source=DESKTOP-7IRF0GL\MUNEEBSQLSERVER;Initial Catalog=Air_ticket_system;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string payment_method = "";

            if (checkBox1.Checked)
            {

                payment_method = "Easy paisa";


            }
            else if (checkBox2.Checked)
            {
                payment_method = "Master Card Credit";
            }
            else if (checkBox3.Checked)
            {
                payment_method = "Visa Card";

            }

            SqlCommand htl = new SqlCommand(@"insert into Hotel_Detail ([Passport ID],Name,[Hotel Name],[Number of Passenger],[Room Selection With Price],[Payment Method]) values('" + textBox1.Text+ "','" + textBox2.Text + "','" +comboBox1.SelectedItem+ "','" + comboBox2.SelectedItem + "','" +comboBox3.SelectedItem+ "','" +payment_method+ "')",hot);
            hot.Open();
            htl.ExecuteNonQuery();
            hot.Close();
            MessageBox.Show("YOUR ROOM HAS BEEN RESERVED...!!","DATA SAVE");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

      
    }
}
