using System;
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
    public partial class Chap17_Loop01_FOR : Form
    {
        // 반복문
        // 특정한 조건을 만족 할 때 까지 반복하여 동일한 로직을 실행하는 문법.
        public Chap17_Loop01_FOR()
        {
            InitializeComponent();
        }

        private void btnFOR_01_Click(object sender, EventArgs e)
        {
            // 1부터 100까지 합하는 로직.

            // 1. 누적 값이 저장 될 변수 생성.
            int iSumValue = 0;

            // 2. 1부터 100까지 더하는 반복문(For)
            // for (int i = 1; i <= 100; i++)
            // int i = 0 : 반복문이 시작 될 초기 값
            // i <= 100 : 참일 경우 로작울 수행할 경우
            // i++     다음 조건을 비교할 증가 로직.
            //int i = 0;

            // 1부터 100까지 합.
            for (int i = 1; i <= 100; i++)
            {
                // 20부터 30까지의 수는 더하지 말라.
                if(i >= 20 && i<= 30)
                {
                    continue; // i++로 바로 이동.
                }

                iSumValue += i;

                if(iSumValue > 1000)
                {
                    break;
                }
            }

            // 100부터 1까지 합.
            /*
            for(int i = 100; i > 0; i--)
            {
                iSumValue += i; // 5050
            }
            */

            MessageBox.Show(Convert.ToString(iSumValue));
        }

        private void btnArraySum_Click(object sender, EventArgs e)
        {
            // 배열의 데이터 수 만큼 For문 반복 후 값 더하기.

            // 1. 임이의 배열 값 등록.
            int[] iValues = new int[] { 10, 20, 30, 50};

            // For문을 통하여 iValues 배열에 있는 모든 값을 더하기
            int iSumValue = 0; // 더한 값이 누적되어 등록될 변수
            for (int i = 0; i < iValues.Length; i++)
            {
                iSumValue += iValues[i];
            }

            MessageBox.Show(Convert.ToString(iSumValue));
        }
    }
}
