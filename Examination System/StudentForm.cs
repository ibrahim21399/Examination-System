﻿using System;
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
        Online_Examination_SystemEntities Tables;

        public StudentForm(Student s)
        {
            InitializeComponent();
            Tables = new Online_Examination_SystemEntities();
            stu = s;
            label1.Text ="Hello ," + stu.Std_Full_Name + "  ,your id is  " + stu.Std_Id + " and you dept_id is  " + stu.Dept_Id;
            comboBoxsub.Visible = false;

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
    }
}