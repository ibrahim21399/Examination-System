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
        int stuId;
        string quesdesc;
        string qtype;
        int qid;
        string subName;
        int crsId;
        int exam_id;
        char[] ans;
        public ex(string s ,int Ci , int stuid)
        {
            InitializeComponent();
            subName = s;
            crsId = Ci;
            ans = new char[10];
            stuId = stuid;
        }
        Online_Examination_SystemEntities ef = new Online_Examination_SystemEntities();
        QControl[] QuestionList = new QControl[10];


        public void listQuestions()
        {
            exam_id =  (int)((ef.randomExam(crsId)).First()) ;
            //MessageBox.Show(exam_id.ToString());
            for (int i = 0; i < QuestionList.Length; i++)
            {
                var Ques =ef.getQue(exam_id, i + 1); // to get question info
                
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
                QuestionList[i].checkBtn = ans[i];

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
            //QuestionList[count+1].checkBtn= ans[count+1];
           

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
            //QuestionList[count - 1].checkBtn = ans[count - 1];
            //  ans[count] = QuestionList[count].GetAns();

        }

        private void Ex_Load(object sender, EventArgs e)
        {
            listQuestions();
            panel1.Controls.Add(QuestionList[0]);
            btnprev.Enabled = false;
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ans[count] = QuestionList[count].GetAns();
        }

        private void button2_Click(object sender, EventArgs e) // submit button
        {
            for (int i = 0; i < 10; i++)
            {
                var Ques = ef.getQue(exam_id, i + 1); // to get question info
                foreach (var u in Ques)
                {
                    quesdesc = u.Q_desc;
                    qtype = u.Q_type;
                    qid = u.Q_Id;
                }
                if (qtype== "T/F")
                {
                    if (ans[i] == 'A')
                    {
                        ans[i] = 'T';
                    }
                    else if (ans[i] == 'B')
                    {
                        ans[i] = 'F';
                    }
                }
            }
            
            ef.Exam_Answers(exam_id, stuId, ans[0].ToString(), ans[1].ToString(), ans[2].ToString(), ans[3].ToString(), ans[4].ToString(), ans[5].ToString(), ans[6].ToString(), ans[7].ToString(), ans[8].ToString(), ans[9].ToString());
            MessageBoxD ms = new MessageBoxD("Submit done :) ");
            ms.Show();

            ef.ExamCorrection1(exam_id,stuId);

            this.Close();
        }
    }
}
