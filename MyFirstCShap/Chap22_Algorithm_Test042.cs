using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCShap
{
    public partial class Chap22_Algorithm_Test042 : Form
    {
        public Chap22_Algorithm_Test042()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 2차원 배열의 합 중 20이 되는 쌍 찾기.
            int[,] iValues = { { 1, 4, 5, 9, 10, 12, 16 },
                               { 2, 7, 11, 13, 14, 15, 18} };

            // 찾은 값을 등록할 문자열 변수.
            string sFindValue = string.Empty;

            // 배열의 행의 수 구하기
            int iRowC = iValues.GetLength(0);

            //Q 배열의 열의 수 구하기
            int iColC = iValues.GetLength(1);

            // 찾은 값을 등록 할 변수.
            int iFindValue = 0;

            // 찾을 값을 누적시킬 리스트
            ArrayList list = new ArrayList();

            // Foreach 나 For 문을 종료시킬 Break 설정 여부를 판단하는 변수.
            bool bBreakFlag = true;

            // Foreach가 회전한 카운트
            int iForeachC = 0;

            // 행열 For 문이 회전한 카운트
            int uForC = 0;

            foreach (int iValue in iValues)
            {
                ++iForeachC; // 기준 데이터를 뽑아서 온 카운트 1증가

                iFindValue = 20 - iValue; // 20에서 추출한 수를 차감한 찾아야 할 수

                foreach (int iValue2 in iValues)
                {
                    if (iValue == iValue2)
                    {
                        sFindValue += $"{iValue},{iValue2}\r\n";
                    }
                }
            }
            MessageBox.Show(sFindValue);
        }    
    }
}