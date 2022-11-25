using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstCSharp
{
    public partial class Chap22_Algorithm_Test051 : Form
    {
        // 난수 생성 클래스 객체 생성 
        Random Ran = new Random();
        int iClickCount = 0; // 마우스가 클릭 된 카운트.
        int[] iValues = new int[3]; // 난수가 들어올 배열

        public Chap22_Algorithm_Test051()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            // 난수 생성 버튼 클릭

            // 1. 생성 된 난수를 int 변수에 담기
            int iValue = Ran.Next(0, 100);

            if(iClickCount == 0) txtRan1.Text = Convert.ToString(iValue);
            else if (iClickCount == 1) txtRan2.Text = Convert.ToString(iValue);
            else if (iClickCount == 2) txtRan3.Text = Convert.ToString(iValue);

            // iClickCount 를 이용하여 배열하여 배열의 주소에 값을 대입.
            iValues[iClickCount] = iValue;
            ++iClickCount;

            // 3개의 텍스트박스에 모두 난수 데이터가 생성 되었을 경우
            // 다음 난수생성 클릭 시에는 첫번째 텍스터박스에 난수를 넣기 위하여
            // iClickCount = 0으로 초기화
            if (iClickCount == 3) iClickCount = 0;

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 결과 버튼 클릭 
            foreach(Control MyControl in this.Controls)
            {
                if (MyControl is TextBox && MyControl.Text == "")
                {
                    MessageBox.Show("난수가 모두 생성 되지 않았습니다.");
                    return;
                }
            }

            // 3 수의 합을 통한 로직 구현.
            Array.Sort(iValues); // 오름차순으로 정렬

            int iSumValue = 0; // 난수 3개를 모두 더할 변수.

            foreach(int iValue in iValues)
            {
                iSumValue += iValue;
            }

            if(iSumValue < 100) 
            {
                MessageBox.Show($" 세 수 중 최소값은 {iValues[0]} 이고 최대값은 {iValues[2]} 이며 곱은 {iValues[0] * iValues[2]} 입니다.");
            }
            else if(iSumValue >= 100 && iSumValue < 200)
            {
                MessageBox.Show($" 세 수 중 최소값은 {iValues[0]} 이고 최대값은 {iValues[2]} 이며 합은 {iValues[0] + iValues[2]} 입니다.");
            }
            else
            {
                MessageBox.Show("세 수의 합이 200 이상 입니다.");
            }
        }
    }
}
