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
            //total amount
            this.label22.Text = Form9.use8;
            //AMTpay
            this.label32.Text = Form9.use3;
            //school year
            this.label11.Text = Form9.use4;
            //date
            this.label6.Text = Form9.use5;
            //change
            this.label33.Text = Form9.use6;
            //AMTtoPAY
            this.label26.Text = Form9.use7;
            this.label29.Text = Form9.use7;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }
    }
}
