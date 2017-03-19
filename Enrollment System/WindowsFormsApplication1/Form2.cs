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
        internal static string deparment;
        public static string Last;
        public static string First;
        public static string Middle;

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
                admin4.admin2 = new MySqlCommand("Insert into " + deparment + "(LastName, FirstName, MiddleName, Address, Age, AverageGrade, Birthday, Gender, PlaceofBirth, Nationality, Citizenship, Religion, FatherName, Occupation1, MotherName, Occupation2, GuardianName, ContactNumber) value(@LastName, @FirstName, @MiddleName, @Address, @Age, @AverageGrade, @Birthday, @Gender, @PlaceofBirth, @Nationality, @Citizenship, @Religion, @FatherName, @Occupation1, @MotherName, @Occupation2, @GuardianName, @ContactNumber)", admin4.adminn);
                admin4.admin2.Parameters.Add(new MySqlParameter("LastName", textBox1.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("FirstName", textBox2.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("MiddleName", textBox3.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Address", textBox4.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Age", textBox5.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("AverageGrade", textBox10.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Birthday", comboBox1.Text + " " + comboBox2.Text + ", " + comboBox3.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Gender", comboBox4.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("PlaceofBirth", textBox6.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Nationality", textBox7.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Citizenship", textBox8.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Religion", textBox9.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("FatherName", textBox13.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Occupation1", textBox15.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("MotherName", textBox14.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Occupation2", textBox16.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("GuardianName", textBox17.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("ContactNumber", textBox18.Text));
                admin4.admin2.ExecuteNonQuery();
                long lastID = admin4.admin2.LastInsertedId;
                admin4.Disconnect();


                //name
                Last = textBox1.Text;
                First = textBox2.Text;
                Middle = textBox3.Text;


                this.Hide();
                Form9.StudentID = lastID;
                Form9 Form10 = new Form9();
                Form10.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
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

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

    }
}