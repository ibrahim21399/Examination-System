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
    public partial class Login : Form
    {
        Online_Examination_SystemEntities DB;
        public Login()
        {
            InitializeComponent();
            DB = new Online_Examination_SystemEntities();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.MidnightBlue;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (radioButtonStu.Checked == true)
            {
                   try
                 {
                var std = (from d in DB.Students
                           where ((d.Std_Username == textBoxusrName.Text) && d.Std_Password == textBoxPassword.Text)
                           select d).First();
                if (std != null)
                {
                    StudentForm f2 = new StudentForm(std);
                    f2.Show();
                    this.Hide();
                }
                }catch
                {
                    
                    MessageBoxD ms = new MessageBoxD("You entered a Wrong username or password");
                    ms.Show();
                }
            }
            else if (radioButtonIns.Checked == true)
            {
                try
                {
                    var ins = (from d in DB.Instructors
                               where ((d.ins_Username == textBoxusrName.Text) && d.ins_password == textBoxPassword.Text)
                               select d).First();
                    if (ins != null)
                    {
                        InstructorForm f3 = new InstructorForm(ins);
                        f3.Show();
                        this.Hide();
                    }
                }
                catch
                {
                    MessageBoxD ms = new MessageBoxD("\tYou entered a Wrong username or password");
                    ms.Show();
                }
            }
            else
            {
                MessageBoxD ms = new MessageBoxD("You might entered a wrong password \n wrong username or missing field");
                ms.Show();
               
            }
        }
    }
}
