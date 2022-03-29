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
    public partial class StudentForm : Form
    {
        Student stu;
        int topid;
        int stuId;
        Online_Examination_SystemEntities Tables;

        public StudentForm(Student s)
        {
            InitializeComponent();
            Tables = new Online_Examination_SystemEntities();
            stu = s;
            label1.Text ="Hello ," + stu.Std_Full_Name;
            comboBoxsub.Visible = false;
            stuId = stu.Std_Id;

            try
            {
                var top = from d in Tables.Topics
                          select d.Top_Name;
                foreach (var dd in top)
                {
                    comboBoxTopic.Items.Add(dd);
                }
            }
            catch
            {
                MessageBox.Show("you must select fileds !!");
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
                comboBoxsub.Items.Clear();
                comboBoxsub.Text = "";
                if (comboBoxTopic.Text != "")
                {
                    comboBoxsub.Visible = true;
                }
                else
                {
                    comboBoxsub.Visible = false;
                }
                topid = (from ds in Tables.Topics
                         where ds.Top_Name == comboBoxTopic.SelectedItem.ToString()
                         select ds.Top_Id).First();

                var sub = from d in Tables.Courses
                          where d.Top_Id == topid
                          select d.Crs_Name;

                foreach (var dd in sub)
                {
                    comboBoxsub.Items.Add(dd);
                }
        }

        private void BtnStartExam_Click(object sender, EventArgs e)
        {

            //check if there is an exam or not     **** take cake of it must handelled
            try
            {

            var subj = comboBoxsub.Text;
            int coursid = (from h in Tables.Courses where h.Crs_Name == subj select h.Crs_Id).First();
            var coursfound = from d in Tables.Courses where d.Crs_Id == coursid select d.Crs_Name;
            if (comboBoxTopic.Text != "" && subj != "")
            {

                if (coursfound != null)
                {
                    ex test = new ex(subj,coursid, stuId);
                    test.Show();
                    this.Hide();
                }
                else
                {
                    MessageBoxD ms = new MessageBoxD("!! Exam is not available NOW");
                    ms.Show();
                }

            }
            else
            {
                MessageBoxD ms = new MessageBoxD("!! please choose topic and course of exam");
                ms.Show();
            }
            }
            catch
            {
                MessageBox.Show("missing fields");
            }





        }
    }
}
