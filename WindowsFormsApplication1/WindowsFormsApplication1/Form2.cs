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
    public partial class Form2 : Form
    {
        Class1 admin4 = new Class1();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "")
            {
                MessageBox.Show("Some of the textbox is EMPTY!");
            }
            else
            {
                //database Student Info
                admin4.Connect();
                admin4.admin2 = new MySqlCommand("Insert into studentinfo(Lastname, Firstname, Middlename, Address, Age, Birthday, Gender, Placeofbirth, Nationality, Citizenship, Religion, FatherName, Occupation1, MotherName, Occupation2, GuardianName, ConNo) value(@Lastname, @Firstname, @Middlename, @Address, @Age, @Birthday, @Gender, @Placeofbirth, @Nationality, @Citizenship, @Religion, @FatherName, @Occupation1, @MotherName, @Occupation2, @GuardianName, @ConNo)", admin4.adminn);
                admin4.admin2.Parameters.Add(new MySqlParameter("Lastname", textBox1.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Firstname", textBox2.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Middlename", textBox3.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Address", textBox4.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Age", textBox5.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Birthday", comboBox1.Text + " " + comboBox2.Text + ", " + comboBox3.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Gender", comboBox4.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Placeofbirth", textBox6.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Nationality", textBox7.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Citizenship", textBox8.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Religion", textBox9.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("FatherName", textBox13.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Occupation1", textBox15.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("MotherName", textBox14.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Occupation2", textBox16.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("GuardianName", textBox17.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("ConNo", textBox18.Text));
                admin4.admin2.ExecuteNonQuery();
                admin4.Disconnect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}