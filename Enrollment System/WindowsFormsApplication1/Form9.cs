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
        internal static long StudentID;
        public static string use1;
        public static string use2;
        public static string use3;
        public static string use4;
        public static string use5;
        public static string use6;
        public static string use7;
        public static string use8;

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
                admin4.admin2 = new MySqlCommand("Insert into billing(StudentID, Name, Total, RemainingBalance, Monthly, TypeofPayment) value(@sn, @Name, @Total, @RemainingBalance, @Monthly, @TypeofPayment)", admin4.adminn);
                admin4.admin2.Parameters.Add(new MySqlParameter("sn", StudentID));
                admin4.admin2.Parameters.Add(new MySqlParameter("Name", label4.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Total", button3.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("RemainingBalance", label13.Text));
                admin4.admin2.Parameters.Add(new MySqlParameter("Monthly", textBox3.Text));
                string payment = "";

                if (radioButton1.Checked)
                {
                    payment = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    payment = radioButton2.Text;
                }
                admin4.admin2.Parameters.Add(new MySqlParameter("TypeofPayment", payment));
   
                
                admin4.admin2.ExecuteNonQuery();
                admin4.Disconnect();
            
            }


            //Name
            use1 = label4.Text;
            //remaining balance
            use2 = label13.Text;
            //AMTpay
            use3 = textBox1.Text;
            //AMTtoPAY
            use7 = textBox4.Text;
            //schoo year
            use4 = label16.Text;
            //date
            use5 = dateTimePicker1.Text;
            //change
            use6 = button4.Text;
            //total amount
            use8 = button3.Text;


            this.Hide();
            Form8 Form8 = new Form8();
            Form8.ShowDialog();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.label4.Text = Form2.Last +", "+ Form2.First +" " + Form2.Middle;
            
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int DP = Convert.ToInt32(textBox2.Text);
            int MP = Convert.ToInt32(textBox3.Text);

            int TA = (DP + (MP * 9));
            button3.Text = TA.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int TA = Convert.ToInt32(button3.Text);
            int pay = Convert.ToInt32(textBox1.Text);
            int cha = Convert.ToInt32(textBox4.Text);

            int change = (pay - cha);
            button4.Text = change.ToString();

            int bal = (TA - cha);
            label13.Text = bal.ToString();
        }
    }
}
