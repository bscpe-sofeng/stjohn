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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            //name
            this.label13.Text = Form5.user1;
            //total amount
            this.label22.Text = Form5.user2;
            //AMTpay
            this.label32.Text = Form5.user3;
            //school year
            this.label11.Text = Form5.user6;
            //date
            this.label6.Text = Form5.user7;
            //change
            this.label33.Text = Form5.user5;
            //AMTtoPAY
            this.label26.Text = Form5.user4;
            this.label29.Text = Form5.user4;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
