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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            //name
            this.label13.Text = Form9.use1;
            //balance
            this.label22.Text = Form9.use2;
            //pay
            this.label32.Text = Form9.use3;
            //school year
            this.label11.Text = Form9.use4;
            //date
            this.label6.Text = Form9.use5;
            //change
            this.label33.Text = Form9.use6;

            //label22.Text = label26.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }
    }
}
