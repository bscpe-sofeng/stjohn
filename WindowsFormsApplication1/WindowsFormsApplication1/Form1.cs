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
    public partial class Form1 : Form
    {
        Class1 admin4 = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin4.Connect();
            admin4.admin2 = new MySqlCommand("select * from admin where Username=@Username and pword=@pword", admin4.adminn);
            admin4.admin2.Parameters.Add(new MySqlParameter("Username", textBox3.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("pword", textBox2.Text));
            admin4.admin1 = admin4.admin2.ExecuteReader();

            if (admin4.admin1.Read())
            {
                new Form3().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");
            }

            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

    }
}
