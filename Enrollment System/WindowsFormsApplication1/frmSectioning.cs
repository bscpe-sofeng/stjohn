using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmSectioning : Form
    {
        Class1 r = new Class1();

        public frmSectioning()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                LEVEL.Items.Clear();
                for (int ctr = 1; ctr <= 6; ctr++)
                {
                    LEVEL.Items.Add("GRADE " + ctr);
                }

                LoadSections(radioButton1.Text);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                LEVEL.Items.Clear();
                for (int ctr = 7; ctr <= 10; ctr++)
                {
                    LEVEL.Items.Add("GRADE " + ctr);
                }

                LoadSections(radioButton2.Text);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                LEVEL.Items.Clear();
                for (int ctr = 11; ctr <= 12; ctr++)
                {
                    LEVEL.Items.Add("GRADE " + ctr);
                }
                LoadSections(radioButton3.Text);
            }
        }

        private void LoadSections(string dept)
        {
            r.Connect();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM sections WHERE department = @department", r.adminn);
            r.admin2 = da.SelectCommand;
            r.admin2.Parameters.Add(new MySqlParameter("department", dept));
            DataTable dt = new DataTable();
            da.Fill(dt);
            r.Disconnect();
            dataGridView2.DataSource = dt;
        }

        private void LoadClasses(string dept)
        {
            r.Connect();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM sections WHERE department = @department", r.adminn);
            r.admin2 = da.SelectCommand;
            r.admin2.Parameters.Add(new MySqlParameter("department", dept));
            DataTable dt = new DataTable();
            da.Fill(dt);
            r.Disconnect();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Please select department");
            }
            else if (LEVEL.SelectedIndex < 0)
            {
                MessageBox.Show("Please select level");
            }
            else if (SectionName.Text.Equals(""))
            {
                MessageBox.Show("Please enter section name");
            }
            else
            {
                r.Connect();
                r.admin2 = new MySqlCommand("SELECT * FROM sections WHERE department = @dept AND level = @lvl AND SectionName = @sn", r.adminn);
                r.admin2.Parameters.Add(new MySqlParameter("dept", SelectedDepartment()));
                r.admin2.Parameters.Add(new MySqlParameter("lvl", LEVEL.SelectedItem));
                r.admin2.Parameters.Add(new MySqlParameter("sn", SectionName.Text));
                r.admin1 = r.admin2.ExecuteReader();
                if(r.admin1.Read()){
                    r.Disconnect();
                    MessageBox.Show("Section under the same department already exists.");
                    return;
                }
                r.Disconnect();

                r.Connect();
                r.admin2 = new MySqlCommand("INSERT INTO sections VALUES (NULL, @sn, @sid, @lvl, @dept)", r.adminn);
                r.admin2.Parameters.Add(new MySqlParameter("dept", SelectedDepartment()));
                r.admin2.Parameters.Add(new MySqlParameter("lvl", LEVEL.SelectedItem));
                r.admin2.Parameters.Add(new MySqlParameter("sn", SectionName.Text));
                r.admin2.Parameters.Add(new MySqlParameter("sid", Priority.Value));
                r.admin2.ExecuteNonQuery();
                r.Disconnect();

                LoadSections(SelectedDepartment());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this section?") == DialogResult.Yes)
                {
               
                    
                    r.Connect();
                    r.admin2 = new MySqlCommand("DELETE FROM sections WHERE ID = @id", r.adminn);
                    r.admin2.Parameters.Add(new MySqlParameter("id", dataGridView2.SelectedRows[0].Cells["id"].Value));
                    r.admin2.ExecuteNonQuery();
                    r.Disconnect();

                    LoadSections(SelectedDepartment());
                }
            }
        }

        private string SelectedDepartment()
        {
            string dept = "";
            if (radioButton1.Checked)
            {
                dept = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                dept = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                dept = radioButton3.Text;
            }
            return dept;
        }

        private void frmSectioning_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
