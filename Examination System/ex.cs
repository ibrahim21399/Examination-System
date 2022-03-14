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
    public partial class ex : Form
    {
        string quesdesc;
        string qtype;
        int qid;
        string subName;
        int crsId;
        int exam_id;
        public ex(string s ,int Ci)
        {
            InitializeComponent();
            subName = s;
            crsId = Ci;
            MessageBox.Show(s);

        }
        Online_Examination_SystemEntities ef = new Online_Examination_SystemEntities();
        QControl[] QuestionList = new QControl[10];


        public void listQuestions()
        {
            
            exam_id =  (int)((ef.randomExam(crsId)).First()) ;
            for (int i = 0; i < QuestionList.Length; i++)
            {

                var Ques =ef.getQue(exam_id, i + 1); // to get question 
                
                foreach (var u in Ques)
                {
                    quesdesc = u.Q_desc;
                    qtype = u.Q_type;
                    qid = u.Q_Id; 
                }
                QuestionList[i] = new QControl();
                QuestionList[i].QuesNum = (i + 1);
                if (quesdesc.Contains("/ "))
                {
                    string[] d = quesdesc.Split(new[] { "/ " }, StringSplitOptions.None);
                    string first = d[0];
                    string secnd = d[1];
                    string Q = $"{first} \n {secnd}";
                    QuestionList[i].QuesDesc = Q;
                }
                else
                {
                    QuestionList[i].QuesDesc = quesdesc;
                }
                if (qtype=="T/F")
                {
                    QuestionList[i].chkFlag(true);
                    QuestionList[i].c1 = "(a) True" ;
                    QuestionList[i].c2 = "(b) False" ;
                }
                else  // mcq
                {
                    QuestionList[i].c1 = "(a) "+(ef.getChoiceA(qid)).First();
                    QuestionList[i].c2 = "(b) "+(ef.getChoiceB(qid)).First();
                    QuestionList[i].c3 = "(c) "+(ef.getChoiceC(qid)).First();
                    QuestionList[i].c4 = "(d) "+(ef.getChoiceD(qid)).First();

                    QuestionList[i].chkFlag(false);
                }
                
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
                if(count==8)
                {
                    btnNext.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                    btnprev.Enabled = true;
                }
                count++;
            }
            else if(count >=8)
            {
                btnNext.Enabled = false;
                btnprev.Enabled = true;

            }
            panel1.Controls.Add(QuestionList[count]);

        }
        private void Btnprev_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            listQuestions();
            if (count > 0)
            {
                if (count ==1)
                {
                    btnprev.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                    btnprev.Enabled = true;
                }
                count--;
            }
            else if (count<=1)
            {
                btnprev.Enabled = false;
                btnNext.Enabled = true;
            }
            panel1.Controls.Add(QuestionList[count]);
        }

        private void Ex_Load(object sender, EventArgs e)
        {
            listQuestions();
            panel1.Controls.Add(QuestionList[0]);
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
