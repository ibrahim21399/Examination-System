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
    public partial class ex : Form
    {
        public ex()
        {
            InitializeComponent();
        }
        QControl[] QuestionList = new QControl[10];


        public void listQuestions()
        {
            for (int i = 0; i < QuestionList.Length; i++)
            {
                QuestionList[i] = new QControl();
                QuestionList[i].QuesNum = (i + 1);
                //comlete data from database
           
            }
        }
        
        int count = 0;
        private void BtnNext_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            listQuestions();
            if (count<9)
            {
                count++;
            }
            panel1.Controls.Add(QuestionList[count]);

        }
        private void Btnprev_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            listQuestions();
            if (count > 0)
            {
                count--;
            }
            panel1.Controls.Add(QuestionList[count]);
            
        }

        private void Ex_Load(object sender, EventArgs e)
        {
            listQuestions();
            panel1.Controls.Add(QuestionList[0]);
        }
    }
}
