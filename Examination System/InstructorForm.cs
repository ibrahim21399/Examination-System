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
    public partial class InstructorForm : Form
    {
        Instructor instructor;
        public InstructorForm(Instructor ins)
        {
            InitializeComponent();
            instructor = ins;

            label1.Text = "Hello ," + instructor.ins_Name + "  ,your id is  " + instructor.ins_Id + " and you dept_id is  " + instructor.Dept_Id;
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
            R reports = new R();
            reports.Show();
            this.Hide();
                        
        }
    }

}
