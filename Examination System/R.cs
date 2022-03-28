using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;

namespace Examination_System
{
    public partial class R : Form
    {
        Online_Examination_SystemEntities db = new Online_Examination_SystemEntities();
        InstructorForm f;
        public R(InstructorForm f)
        {
            InitializeComponent();
            this.f = f;
            var examNO = from d in db.Exams select d.Exam_Id;
            foreach (var dd in examNO)
            {
                comboBox2.Items.Add(dd);
            }
            var cursId = from d in db.Courses select d.Crs_Id;
            foreach (var dd in cursId)
            {
                comboBox3.Items.Add(dd);
            }
            var stdId = from d in db.Students select d.Std_Id;
            foreach (var dd in stdId)
            {
                comboBox4.Items.Add(dd);
                comboBox5.Items.Add(dd);

            }
            var InsId = from d in db.Instructors select d.ins_Id;
            foreach (var dd in InsId)
            {
                comboBox6.Items.Add(dd);

            }
            var Dept = from d in db.Departments select d.Dept_Id;
            foreach (var dd in Dept)
            {
                comboBox7.Items.Add(dd);

            }
        }

        private void R_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnreport_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    reportViewer1.ServerReport.ReportPath = "/Examination System Reports/Report1";
                    IList<Microsoft.Reporting.WinForms.ReportParameter> parameters = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    parameters.Add(new Microsoft.Reporting.WinForms.ReportParameter("Dept_Id", comboBox7.Text));
                    reportViewer1.ServerReport.SetParameters(parameters);
                    reportViewer1.ShowParameterPrompts = false;
                    reportViewer1.ServerReport.Refresh();
                    reportViewer1.RefreshReport();
                    break;
                case 1:
                    reportViewer1.ServerReport.ReportPath = "/Examination System Reports/Report2";
                    IList<Microsoft.Reporting.WinForms.ReportParameter> p = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    p.Add(new Microsoft.Reporting.WinForms.ReportParameter("std_id", comboBox4.Text));
                    reportViewer1.ServerReport.SetParameters(p);
                    reportViewer1.ShowParameterPrompts = false;
                    reportViewer1.ServerReport.Refresh();
                    reportViewer1.RefreshReport();
                    break;
                case 2:
                    reportViewer1.ServerReport.ReportPath = "/Examination System Reports/Report3";
                    IList<Microsoft.Reporting.WinForms.ReportParameter> p1 = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    p1.Add(new Microsoft.Reporting.WinForms.ReportParameter("ins_id", comboBox6.Text));
                    reportViewer1.ServerReport.SetParameters(p1);
                    reportViewer1.ShowParameterPrompts = false;
                    reportViewer1.ServerReport.Refresh();
                    reportViewer1.RefreshReport();
                    break;
                case 3:
                    reportViewer1.ServerReport.ReportPath = "/Examination System Reports/Report4";
                    IList<Microsoft.Reporting.WinForms.ReportParameter> p2 = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    p2.Add(new Microsoft.Reporting.WinForms.ReportParameter("Crs_Id", comboBox3.Text));
                    reportViewer1.ServerReport.SetParameters(p2);
                    reportViewer1.ShowParameterPrompts = false;
                    reportViewer1.ServerReport.Refresh();
                    reportViewer1.RefreshReport();
                    break;
                case 4:
                    reportViewer1.ServerReport.ReportPath = "/Examination System Reports/Report5";
                    IList<Microsoft.Reporting.WinForms.ReportParameter> p3 = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    p3.Add(new Microsoft.Reporting.WinForms.ReportParameter("Examnum", comboBox2.Text));
                    reportViewer1.ServerReport.SetParameters(p3);
                    reportViewer1.ShowParameterPrompts = false;
                    reportViewer1.ServerReport.Refresh();
                    reportViewer1.RefreshReport();
                    break;
                case 5:
                    reportViewer1.ServerReport.ReportPath = "/Examination System Reports/Report6";
                    IList<Microsoft.Reporting.WinForms.ReportParameter> p4 = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    p4.Add(new Microsoft.Reporting.WinForms.ReportParameter("ExamNum", comboBox2.Text));
                    p4.Add(new Microsoft.Reporting.WinForms.ReportParameter("StdID", comboBox5.Text));
                    reportViewer1.ServerReport.SetParameters(p4);
                    reportViewer1.ShowParameterPrompts = false;
                    reportViewer1.ServerReport.Refresh();
                    reportViewer1.RefreshReport();
                    break;
                default:
                    MessageBoxD ms = new MessageBoxD("!! please choose Report or check data");
                    ms.Show();
                    break;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox1.Visible = false;
                    comboBox7.Visible = true;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    comboBox6.Visible = false; 
                    P1label.Visible = true;
                    P1label.Text = "Dept Id";
                    break;
                case 1:
                    textBox1.Visible = false;
                    comboBox4.Visible = true;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox7.Visible = false;
                    comboBox5.Visible = false;
                    comboBox6.Visible = false;
                    P1label.Visible = true;
                    P1label.Text = "Std Id";
                    break;
                case 2:
                    textBox1.Visible = false;
                    comboBox6.Visible = true;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    comboBox7.Visible = false;
                    P1label.Visible = true;
                    P1label.Text = "Ins Id";
                    break;
                case 3:
                    textBox1.Visible = false;
                    comboBox3.Visible = true;
                    comboBox2.Visible = false;
                    comboBox7.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    comboBox6.Visible = false;
                    P1label.Visible = true;
                    P1label.Text = "Crs Id";
                    break;
                case 4:
                    textBox1.Visible = false;
                    comboBox2.Visible = true;
                    comboBox7.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    comboBox6.Visible = false;
                    P1label.Visible = true;
                    P1label.Text = "Exam No.";
                    break;
                case 5:
                    textBox1.Visible = false;
                    P1label.Visible = true;
                    comboBox2.Visible = true;
                    comboBox7.Visible = false;
                    comboBox3.Visible = false;
                    comboBox5.Visible = true;
                    comboBox6.Visible = false;
                    P1label.Text = "Exam No.";
                    comboBox4.Visible = false;
                    P2label.Visible = true;
                    P2label.Text = "Std Id";
                    break;
                default:
                    MessageBoxD ms = new MessageBoxD("!! please choose Report or check data");
                    ms.Show();
                    break;
            }
        }
        
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            f.Show();
        }
    }
}
