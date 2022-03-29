using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class InstructorForm : Form
    {
        Instructor instructor;
        Online_Examination_SystemEntities DB;
        string crsName;
        int mcqNo;
        int tfNo;
        public InstructorForm(Instructor ins)
        {
            InitializeComponent();
            DB = new Online_Examination_SystemEntities();
            
            instructor = ins;

            label1.Text = "Hello ," + instructor.ins_Name ;
            var sub = from d in DB.Courses
                      select d.Crs_Name;
            foreach (var d in sub)
            {
                comboBoxsub.Items.Add(d);
            }

        }

        public InstructorForm()
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnStartExam_Click(object sender, EventArgs e)
        {
            R reports = new R(this);
            reports.Show();
            this.Hide();
        }

        private void ComboBoxsub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

            mcqNo = int.Parse(textBox1.Text);
            tfNo = int.Parse(textBox2.Text);
            if ((mcqNo + tfNo) == 10 && comboBoxsub.Text!="")
            {
                string ss = comboBoxsub.Text;
                var ge= DB.GenerateExam(ss, mcqNo, tfNo);
                MessageBoxD dd = new MessageBoxD(" Successfuly generated ");
                dd.Show();
            }
            else
            {
                MessageBoxD dd = new MessageBoxD("Number of questions must be 10");
                dd.Show();
            }
            }
            catch
            {
                MessageBoxD dd = new MessageBoxD(" missing field");
                dd.Show();
            }
        }
    }

}
