using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCShap
{
    public partial class Chap17_Loop01_ForTest05 : Form
    {
        public Chap17_Loop01_ForTest05()
        {
            InitializeComponent();
        }

        private void btnTwoMulSum_Click(object sender, EventArgs e)
        {
            SumNumberMultiple(2);
        }

        private void btnFiveMulSum_Click(object sender, EventArgs e)
        {
            SumNumberMultiple(5);
        }

        private void btnTenMulSum_Click(object sender, EventArgs e)
        {
            SumNumberMultiple(10);
        }

        void SumNumberMultiple(int iValue)
        {
            // 입력한 값이 숫자로 변경할 수 있는 문자인지 확인.
            bool bStartFlag = false; // 시작 값이 숫자로 바뀌었는지 확인 여부.
            bool bEndFlag = false; // 마지막 값이 숫자로 바뀌었는지 확인 여부.

            int iStartValue = 0;
            int iEndValue = 0;

            bStartFlag = int.TryParse(txtStart.Text, out iStartValue);
            bEndFlag = int.TryParse(txtEnd.Text, out iEndValue);

            if (!bStartFlag || !bEndFlag)
            {
                MessageBox.Show("숫자로 변경할 수 없는 값을 입력하였습니다.");
                return;
            }

            // 2. 음수 값을 입력했는지 확인.
            if (iStartValue < 0 || iEndValue < 0)
            {
                MessageBox.Show("음수 값은 입력할 수 없습니다.");
                return;
            }

            // 3. 시작하는 값이 종료 값보다 큰지 확인.
            if (iStartValue > iEndValue)
            {
                MessageBox.Show("시작하는 값이 종료 값보다 큽니다.");
                return;
            }

            // 4. 검출과정이 끝났으니 정상적으로 처리하는 로직.
            int iResult = 0;
            for (int i = iStartValue; i <= iEndValue; i++)
            {
                if (i % iValue == 0)
                {
                    iResult += i;
                }
            }
            MessageBox.Show($"{iValue}의 배수 합은 : {iResult}입니다.");
        }

    }
}
