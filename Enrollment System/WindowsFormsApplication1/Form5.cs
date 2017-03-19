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
    public partial class Form5 : Form
    {
        public static string user1;
        public static string user2;
        public static string user3;
        public static string user4;
        public static string user5;
        public static string user6;
        public static string user7;

        private void LoadTable1()
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("ID");
            dt1.Columns.Add("StudentNumber");
            dt1.Columns.Add("Name");
            dt1.Columns.Add("Section");
            dt1.Columns.Add("Total");
            dt1.Columns.Add("RemainingBalance");
            dt1.Columns.Add("Monthly");
            dt1.Columns.Add("TypeofPayment");
            dt1.Columns.Add("Department");


            admin4.Connect();
            admin4.admin2 = new MySqlCommand("Select * from billing where Name like'%" + textBox1.Text + "%'", admin4.adminn);
            admin4.admin1 = admin4.admin2.ExecuteReader();

            while (admin4.admin1.Read())
            {
                dt1.Rows.Add(new Object[]{
                admin4.admin1["ID"],
                admin4.admin1["StudentID"],
                admin4.admin1["Name"],
                admin4.admin1["Section"],
                admin4.admin1["Total"],
                admin4.admin1["RemainingBalance"],
                admin4.admin1["Monthly"],
                admin4.admin1["TypeofPayment"],
                admin4.admin1["Department"]
            });
            }

            admin4.Disconnect();
            dataGridView1.DataSource = dt1;

        }

        Class1 admin4 = new Class1();
        public Form5()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label15.Text = row.Cells["ID"].Value.ToString();
                label4.Text = row.Cells["StudentNumber"].Value.ToString();
                label5.Text = row.Cells["Name"].Value.ToString();
                label7.Text= row.Cells["RemainingBalance"].Value.ToString();
                label10.Text = row.Cells["Monthly"].Value.ToString();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            {


                //update
                admin4.Connect();
                admin4.admin2 = new MySqlCommand("update billing set StudentID=@StudentID, Name=@Name, RemainingBalance=@RemainingBalace, Monthly=@Monthly where ID=@ID", admin4.adminn);
                admin4.admin2.Parameters.Add(new MySqlParameter("ID", label15.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("StudentID", label4.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Name", label5.Text)); 
                admin4.admin2.Parameters.Add(new MySqlParameter("RemainingBalance", label20.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Monthly", label10.Text));


                admin4.admin2.ExecuteNonQuery();
                admin4.Disconnect();
                LoadTable1();
            }


            //Name
            user1 = label5.Text;
            //remaining balance
            user2 = label7.Text;
            //AMTpay
            user3 = textBox2.Text;
            //AMTtoPAY
            user4 = textBox3.Text;
            //change
            user5 = label18.Text;
            //School year
            user6 = label18.Text;
            //date
            user7 = dateTimePicker1.Text;
           


            this.Hide();
            Form8 Form8 = new Form8();
            Form8.ShowDialog();
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            LoadTable1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pay = Convert.ToInt32(textBox2.Text);
            int cha = Convert.ToInt32(textBox3.Text);

            int change = (pay - cha);
            button3.Text = change.ToString();

            int bal = Convert.ToInt32(label7.Text);
            int balance = (bal - cha);
            label20.Text = balance.ToString();
        }
    }
}
