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
    public partial class Chap04_Operator: Form
    {
        public Chap04_Operator()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e) // =
        {
            // 대입 연산자 오른쪽 있는 값(리터럴)을 왼쪽
            // 데이터 타입 변수에 대입한다.

            int iValue1; // 첫번째 데이터 담는 변수.
            iValue1= 10;

            int iValue2 = 20; // 두번째 데이터를 담는 변수.

            MessageBox.Show(Convert.ToString(iValue1 + iValue2));
        }

        private void btnSumEqual_Click(object sender, EventArgs e) // +=
        {
            // += : 리터럴 값을 왼쪽 변수에 있는 값과 합한 후 결과를
            //      다시 왼쪽 변수에 대입한다.

            int iValue1 = 10;
            iValue1 = iValue1 + 20;
            MessageBox.Show(Convert.ToString(iValue1)); // 30

            int ivValue2 = 10;
            ivValue2 += 20; // iValue2 = iValue2 + 20;
        }

        private void btnMinusEqual_Click(object sender, EventArgs e) // -=
        {
            // 리터럴 값은 왼쪽 변수에 차감하여 자기 자신에게(변수) 담는다.
            int ivValue1 = 10;
            ivValue1 -= 5;
            MessageBox.Show(Convert.ToString(ivValue1)); // 5
        }

        private void btnMulEqual_Click(object sender, EventArgs e) // *=
        {
            // 리터럴을 왼쪽 변수에 곱하여 변수에 담는다.
            int iValue1 = 10;
            iValue1 *= 10;
            MessageBox.Show(Convert.ToString(iValue1)); // 100
        }

        private void btnDivEqual_Click(object sender, EventArgs e) // /=
        {
            // 리터럴을 왼쪽 변수 값과 나누어 몫을 담는다.

            int ivValue1 = 10;
            int ivValue2;
            ivValue2 = ivValue1 / 3;
            MessageBox.Show(Convert.ToString(ivValue2));

            // 대상 값이 변질이 될 우려가 있으므로
            // 고려하여 사용하기를 권장.
            ivValue1 /= 3;
            MessageBox.Show(Convert.ToString(ivValue1));
        }

        private void btnRemEqual_Click(object sender, EventArgs e) // %=
        {
            // 리터럴을 변수의 값과 나누어 나머지 값을
            // 변수에 담는다.

            int ivValue1 = 10;
            ivValue1 %= 3;
            MessageBox.Show(Convert.ToString(ivValue1)); // 1
        }

        private void btnSS_Click(object sender, EventArgs e) // ++
        {
            // 전위 증가 연산자, 후위 증가 연산자.
            // 대상 변수에 1씩 더하는 값을 담는다.
            int iValue = 10;

            iValue++; // 후위 증가 연산자.
            MessageBox.Show(Convert.ToString(iValue)); // 11

            ++iValue; // 전위 증가 연산자.
            MessageBox.Show(Convert.ToString(iValue)); // 12

            MessageBox.Show(Convert.ToString(iValue++)); // 12
            MessageBox.Show(Convert.ToString(++iValue)); // 14

            // 후위 증가 연산자 : 코드가 실행된 후에 증가 (+1)
            // 전위 증가 연산자 : 코드가 실행될 때 증가 (+1)

            // 전위 증가 연산자를 사용하기를 권장.
        }

        private void btnMM_Click(object sender, EventArgs e) // --
        {
            // 전위 감소 연산자, 후위 감소 연산자
            int iValue = 10;
            MessageBox.Show(Convert.ToString(--iValue)); // 9
            MessageBox.Show(Convert.ToString(iValue--)); // 9
        }
    }
}
