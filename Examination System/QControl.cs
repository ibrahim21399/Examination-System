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
    }
}
