using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace pmc20141226
{
    

    public partial class Form1 : Form
    {
        ushort handle=0;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "handle=" + handle;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Focas1.focas_ret ret = (Focas1.focas_ret)Focas1.cnc_allclibhndl3(textBox1.Text, 8193, 2, out handle); //取得library handle

            if (ret == Focas1.focas_ret.EW_OK)
            {
                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;
                MessageBox.Show("Connect Succuss");
            }
            else
            {
                MessageBox.Show(""+ret);
            }
            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "handle=" + handle;
        }

        
    }
}
