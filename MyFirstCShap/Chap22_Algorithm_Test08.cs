using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap22_Algorithm_Test08 : Form
    {
        public Chap22_Algorithm_Test08()
        {
            InitializeComponent(); 
        }
 
        private void btnDesc_Click(object sender, EventArgs e)
        {
            string[] sValue = lblTitle.Text.Split(',');
            string sResultShow = string.Empty;
            int[] iValue = new int[sValue.Length];
            int iSub = 0;
            for (int k = 0; k < sValue.Length; k++)
            {
                iValue[k] = Convert.ToInt32(sValue[k]);
            }
            for(int i = 0; i < iValue.Length; i++)
            {
                for (int j = i+1; j < iValue.Length; j++)
                {
                    if(iValue[i] < iValue[j])
                    {
                        iSub = iValue[i];
                        iValue[i] = iValue[j];
                        iValue[j] = iSub;
                    }
                }
                if (i < iValue.Length - 1) sResultShow += iValue[i] + ", ";
                else sResultShow += iValue[i];
            }
            txtDesc.Text = sResultShow;
        }

        private void btnDesc2_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;

            // 타이틀의 내용 배열로 만들기
            sTitle = sTitle.Replace(" ", "");

            string[] sValues = sTitle.Split(',');

            // 정수형 배열 깡통 만들기
            int[] iValues = new int[sValues.Length];

            int iForeschCount = 0;
            foreach(string Word in sValues)
            {
                iValues[iForeschCount] = Convert.ToInt32(Word);
                ++iForeschCount;
            }

            int iTemp = 0; // 바꿀 데이터 임시 저장 변수.
            for (int i = 0; i < iValues.Length; i++)
            {
                for(int j = i + 1; j < iValues.Length; j++)
                {
                    if (iValues[i] < iValues[j])
                    {
                        iTemp = iValues[i];
                        iValues[i] = iValues[j];
                        iValues[j] = iTemp;
                    }
                }
            }

            foreach(int iValue in iValues)
            {
                txtDesc.Text += Convert.ToString(iValue) + ",";
            }
        }
    } 

}
