using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class QControl : UserControl
    {
        
        public QControl()
        {
            InitializeComponent();
        }

        private int _QuesNum;
        private string _quesDesc;
        private string _C1;
        private string _C2;
        private string _C3;
        private string _C4;
        private char _Ans;
        private char _check;




        public char GetAns()
        {
            if (radioButton1.Checked == true)
            {
                _Ans = 'A';
            }
            else if (radioButton2.Checked== true)
            {
                _Ans = 'B';
            }
            else if (radioButton3.Checked == true)
            {
                _Ans = 'C';
            }
            else if (radioButton4.Checked == true)
            {
                _Ans = 'D';
            }
            return _Ans;
        }



        public void chkFlag(Boolean _flag)
        {
            if (_flag == true)
            {
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }
            else
            {
                radioButton3.Visible = true;
                radioButton4.Visible = true;
            }
        }
        public char checkBtn
        {
            get { return _check; }
            set { _check = value; 
                    if (_check =='A')
                    {
                        radioButton1.Checked = true; 
                    }else if (_check == 'B')
                    {
                        radioButton2.Checked = true; 
                    }
                    else if (_check == 'C')
                    {
                        radioButton3.Checked = true;
                    }
                    else if (_check == 'D')
                    {
                        radioButton4.Checked = true;
                    }
            }
                
        }

        public int QuesNum
        {
            get { return _QuesNum; }
            set { _QuesNum = value; QnumLabel.Text = value.ToString(); }
        }

        public string QuesDesc
        {
            get { return _quesDesc; }
            set { _quesDesc = value;QesdescLabel.Text = value; }
        }
        public string c1
        {
            get { return _C1; }
            set { _C1 = value; radioButton1.Text = value; }
        }
        public string c2
        {
            get { return _C2; }
            set { _C2 = value; radioButton2.Text = value; }
        }
        public string c3
        {
            get { return _C3; }
            set { _C3 = value; radioButton3.Text = value; }
        }
        public string c4
        {
            get { return _C4; }
            set { _C4 = value; radioButton4.Text = value; }
        }
        
        public char Ans
        {
            get { return _Ans; }
            set { _Ans = value; }
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }
    }
}
