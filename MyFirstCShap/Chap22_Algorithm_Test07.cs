using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap22_Algorithm_Test07 : Form
    { 
        public Chap22_Algorithm_Test07()
        {
            InitializeComponent();
        }

        private void btnFindAndReplace_Click(object sender, EventArgs e)
        {
            RSplit();
        }

        void Foreach()
        {
            int iCount = 0;
            int iRCount = 0;
            int iResult = 0;
            foreach (char Char in lblTitle.Text)
            {
                if (Char == '?')
                {
                    ++iRCount;
                    if (iRCount == 1 || iRCount == 3) iResult += iCount;
                    if (iRCount == 3) break;
                }
                ++iCount;
            }
            string sRValue = lblTitle.Text.Substring(iResult, 3);
            txtResult.Text = lblTitle.Text.Replace(sRValue, "무궁화");
        }

        void RSplit()
        {
            string[] sValues = lblTitle.Text.Split("?");
            int iValue = sValues[0].Length;
            int iValue2 = iValue + sValues[1].Length + sValues[2].Length + 2;
            int iResult = iValue + iValue2;
            string sValue = lblTitle.Text.Substring(iResult, 3);
            txtResult.Text = lblTitle.Text.Replace(sValue, "무궁화");
        }
    }
}
