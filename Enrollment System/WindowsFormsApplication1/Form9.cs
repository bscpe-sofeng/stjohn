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
    public partial class Form9 : Form
    {
        public static string use1;
        public static string use2;
        public static string use3;
        public static string use4;
        public static string use5;
        public static string use6;

        Class1 admin4 = new Class1();
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            {
                //database billing
                admin4.Connect();
                admin4.admin2 = new MySqlCommand("Insert into billing( StudentNumber, Name, Total, RemainingBalance, Monthly, TypeofPayment) value(@StudentNumber, @Name, @Total, @RemainingBalance, @Monthly, @TypeofPayment)", admin4.adminn);
                admin4.admin2.Parameters.Add(new MySqlParameter("StudentNumber", label3.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Name", label4.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Total", label10.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("RemainingBalance", label13.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Monthly", label9.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("TypeofPayment", radioButton1.Text));
                admin4.admin2.ExecuteNonQuery();
                admin4.Disconnect();
            }


            //Name
            use1 = label4.Text;
            //balance
            use2 = label10.Text;
            //Pay
            use3 = textBox1.Text;
            //schoo year
            use4 = label16.Text;
            //date
            use5 = dateTimePicker1.Text;
            //change
            use6 = label19.Text;


            this.Hide();
            Form8 Form8 = new Form8();
            Form8.ShowDialog();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
