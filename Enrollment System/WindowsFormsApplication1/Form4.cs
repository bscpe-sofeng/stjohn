using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        Class1 admin4 = new Class1();
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your Lastname!");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter your Firstname!");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please enter your Username!");
                textBox3.Focus();
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please enter your Password!");
                textBox4.Focus();
                return;
            }
               else if (textBox4.Text != textBox5.Text)
               {
                   MessageBox.Show("You have re-entered a wrong password!");
                   textBox4.Clear();
                   textBox5.Clear();
                   textBox4.Focus();
                   return;
               }
               else
               {

                   //ADD
                   admin4.Connect();
                   admin4.admin2 = new MySqlCommand("Insert into adminsaccount(LastName, FirstName, UserName, Password, Status) value (@LastName, @FirstName, @UserName, @Password, @Status)", admin4.adminn);
                   admin4.admin2.Parameters.Add(new MySqlParameter("LastName", textBox1.Text));
                   admin4.admin2.Parameters.Add(new MySqlParameter("FirstName", textBox2.Text));
                   admin4.admin2.Parameters.Add(new MySqlParameter("UserName", textBox3.Text));
                   admin4.admin2.Parameters.Add(new MySqlParameter("Password", textBox4.Text));
                   admin4.admin2.Parameters.Add(new MySqlParameter("Status", label7.Text));
               
                   admin4.admin2.ExecuteNonQuery();
                   admin4.Disconnect();

                   textBox1.Text = string.Empty;
                   textBox2.Text = string.Empty;
                   textBox3.Text = string.Empty;
                   textBox4.Text = string.Empty;
                   textBox5.Text = string.Empty;




                   MessageBox.Show("You are successfully registerd!");

                   this.Hide();
                   Form3 Form3 = new Form3();
                   Form3.ShowDialog();

               }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }
    }
}
