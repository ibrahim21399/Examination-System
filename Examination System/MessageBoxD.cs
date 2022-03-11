using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class MessageBoxD : Form
    {
       
        public MessageBoxD( string msg)
        {
            InitializeComponent();
            label2.Text = msg;


        }
        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
