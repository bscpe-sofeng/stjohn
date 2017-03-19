using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;

namespace WindowsFormsApplication1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2.deparment = "seniorhigh";
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.deparment = "elementary";
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.deparment = "juniorhigh";
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }
    }
}
