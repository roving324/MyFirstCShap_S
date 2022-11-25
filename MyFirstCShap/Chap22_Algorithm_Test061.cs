using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CHAP04_MiddleExam
{
    public partial class Chap22_Algorithm_Test061 : Form
    {
        public Chap22_Algorithm_Test061()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;
            sTitle = sTitle.Replace("{", "");
            sTitle = sTitle.Replace(" ", "");
            sTitle = sTitle.Replace("}", "");

            // 1,2,3,4,5,10,11,12
            string[] sValues = sTitle.Split(',');

            // int 배열에 담기
            int[] iValues = new int[sValues.Length];

            for(int i = 0; i < sValues.Length; i++)
            {
                iValues[i] = Convert.ToInt32(sValues[i]);
            }

            // 정수 배열 정렬
            Array.Sort(iValues);

            // 중복 값을 찾은 횟수 Count
            int iFindCount = 0;

            // 찾은 값을 누적시킬 변수
            string sValue = string.Empty;

            // 찾은 이전 값을 저장시킬 변수
            int sFindValue = 0;

            for(int i = 0; i < iValues.Length; i++)
            {
                if(i + 1 == iValues.Length)
                {
                    break;
                }
                if (iValues[i] == iValues[i+1])
                {
                    if (sFindValue == iValues[i + 1]) continue;
                    // 중복 데이터.
                    ++iFindCount;
                    // 첫번째 중복값, 세번째 중복값
                    if(iFindCount == 2)  continue;
                    sValue += Convert.ToString(iValues[i]) + "";
                    if (iFindCount == 3) break;
                }
                sFindValue = iValues[i];
            }
            MessageBox.Show(sValue);
        }
    }
}
