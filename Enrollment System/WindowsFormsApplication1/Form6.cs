﻿using System;
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
    public partial class Form6 : Form
    {
        Class1 admin4 = new Class1();

        private void LoadTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StudentNumber");
            dt.Columns.Add("LastName");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("MiddleName");
            dt.Columns.Add("Address");
            dt.Columns.Add("Age");
            dt.Columns.Add("AverageGrade");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Gender");
            dt.Columns.Add("PlaceofBirth");
            dt.Columns.Add("Nationality");
            dt.Columns.Add("Citizenship");
            dt.Columns.Add("Religion");
            dt.Columns.Add("FatherName");
            dt.Columns.Add("Occupation1");
            dt.Columns.Add("MotherName");
            dt.Columns.Add("Occupation2");
            dt.Columns.Add("GuardianName");
            dt.Columns.Add("ContactNumber");

            admin4.Connect();
            admin4.admin2 = new MySqlCommand("Select * from listofstudents where Lastname like'%" + textBox1.Text + "%'", admin4.adminn);
            admin4.admin1 = admin4.admin2.ExecuteReader();

            while (admin4.admin1.Read())
            {
                dt.Rows.Add(new Object[]{
                admin4.admin1["StudentNumber"],
                admin4.admin1["LastName"],
                admin4.admin1["FirstName"],
                admin4.admin1["MiddleName"],
                admin4.admin1["Address"],
                admin4.admin1["Age"],
                admin4.admin1["AverageGrade"],
                admin4.admin1["Birthday"],
                admin4.admin1["Gender"],
                admin4.admin1["PlaceofBirth"],
                admin4.admin1["Nationality"],
                admin4.admin1["Citizenship"],
                admin4.admin1["Religion"],
                admin4.admin1["FatherName"],
                admin4.admin1["Occupation1"],
                admin4.admin1["MotherName"],
                admin4.admin1["Occupation2"],
                admin4.admin1["GuardianName"],
                admin4.admin1["ContactNumber"]
            });
            }
            admin4.Disconnect();
            dataGridView1.DataSource = dt;
        }

        private void LoadTable1()
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("IDNumber");
            dt1.Columns.Add("LastName");
            dt1.Columns.Add("FirstName");
            dt1.Columns.Add("UserName");
            dt1.Columns.Add("Password");
           

            admin4.Connect();
            admin4.admin2 = new MySqlCommand("Select * from adminsaccount where LastName like'%" + textBox20.Text + "%'", admin4.adminn);
            admin4.admin1 = admin4.admin2.ExecuteReader();

            while (admin4.admin1.Read())
            {
                dt1.Rows.Add(new Object[]{
                admin4.admin1["IDNumber"],
                admin4.admin1["LastName"],
                admin4.admin1["FirstName"],
                admin4.admin1["UserName"],
                admin4.admin1["Password"],
                
            });
            }

            admin4.Disconnect();
            dataGridView2.DataSource = dt1;

        }

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadTable1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                label31.Text = row.Cells["IDNumber"].Value.ToString();
                textBox19.Text = row.Cells["LastName"].Value.ToString();
                textBox20.Text = row.Cells["FirstName"].Value.ToString();
                textBox21.Text = row.Cells["UserName"].Value.ToString();
                textBox22.Text = row.Cells["Password"].Value.ToString();
                

            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DELETE
            admin4.Connect();
            admin4.admin2 = new MySqlCommand("delete from adminsaccount where IDNumber=@IDNumber", admin4.adminn);
            admin4.admin2.Parameters.Add(new MySqlParameter("IDNumber", label31.Text));
            admin4.admin2.ExecuteNonQuery();
            admin4.Disconnect();
            LoadTable1();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //UPDATE
            admin4.Connect();
            admin4.admin2 = new MySqlCommand("update adminsaccount set LastName=@LastName, FirstName=@FirstName, UserName=@UserName, Password=@Password where IDNumber=@IDNumber", admin4.adminn);
            admin4.admin2.Parameters.Add(new MySqlParameter("IDNumber", label31.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("LastName", textBox19.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("FirstName", textBox20.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("UserName", textBox21.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("Password", textBox22.Text));


            admin4.admin2.ExecuteNonQuery();
            admin4.Disconnect();
            LoadTable1();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //UPDATE
            admin4.Connect();
            admin4.admin2 = new MySqlCommand("update listofstudents set LastName=@LastName, FirstName=@FirstName, MiddleName=@MiddleName, Address=@Address, Age=@Age, Gender=@Gender, Birthday=@Birthday, PlaceofBirth=@PlaceofBirth, Nationality=@Nationality, Citizenship=@Citizenship, Religion=@Religion, FatherName=@FatherName, Occupation1=@Occupation1, MotherName=@MotherName, Occupation2=@Occupation2, GuardianName=@GuardianName, ContactNumber=@ContactNumber where StudentNumber=@StudentNumber", admin4.adminn);
            admin4.admin2.Parameters.Add(new MySqlParameter("StudentNumber", label22.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("LastName", textBox2.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("FirstName", textBox3.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("MiddleName", textBox4.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("Gender", textBox5.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("Age", textBox6.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("Birthday", textBox7.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("Citizenship", textBox8.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("Religion", textBox9.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("Nationality", textBox10.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("Address", textBox11.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("PlaceofBirth", textBox12.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("FatherName", textBox13.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("Occupation1", textBox14.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("MotherName", textBox15.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("Occupation2", textBox16.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("GuardianName", textBox17.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("ContactNumber", textBox18.Text));

            admin4.admin2.ExecuteNonQuery();
            admin4.Disconnect();
            LoadTable1();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label22.Text = row.Cells["StudentNumber"].Value.ToString();
                textBox2.Text = row.Cells["LastName"].Value.ToString();
                textBox3.Text = row.Cells["FirstName"].Value.ToString();
                textBox4.Text = row.Cells["MiddleName"].Value.ToString();
                textBox11.Text = row.Cells["Address"].Value.ToString();
                textBox6.Text = row.Cells["Age"].Value.ToString();
                textBox7.Text = row.Cells["Birthday"].Value.ToString();
                textBox5.Text = row.Cells["Gender"].Value.ToString();
                textBox12.Text = row.Cells["PlaceofBirth"].Value.ToString();
                textBox10.Text = row.Cells["Nationality"].Value.ToString();
                textBox8.Text = row.Cells["Citizenship"].Value.ToString();
                textBox9.Text = row.Cells["Religion"].Value.ToString();
                textBox13.Text = row.Cells["FatherName"].Value.ToString();
                textBox14.Text = row.Cells["Occupation1"].Value.ToString();
                textBox15.Text = row.Cells["MotherName"].Value.ToString();
                textBox16.Text = row.Cells["Occupation2"].Value.ToString();
                textBox17.Text = row.Cells["GuardianName"].Value.ToString();
                textBox18.Text = row.Cells["Contactnumber"].Value.ToString();

            }
        }
    }
}
