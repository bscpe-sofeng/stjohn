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
    //    private void LoadTable1()
    //    {
    //        DataTable dt1 = new DataTable();
     //       dt1.Columns.Add("StudentNumber");
    //        dt1.Columns.Add("LastName");
    //        dt1.Columns.Add("FirstName");
    //        dt1.Columns.Add("MiddleName");
    //        dt1.Columns.Add("");
    //        dt1.Columns.Add("Password");
    //        dt1.Columns.Add("Status");

    //        admin4.Disconnect();
    //        dataGridView1.DataSource = dt1;
    //    }

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

        }

        private void button1_Click(object sender, EventArgs e)
        {



            this.Hide();
            Form8 Form8 = new Form8();
            Form8.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

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
    }
}
