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
    public partial class Chap17_Loop01_ForTest04 : Form
    {
        public Chap17_Loop01_ForTest04()
        {
            InitializeComponent();
        }
        #region < 버튼 >
        private void btnTwoMulSum_Click(object sender, EventArgs e)
        {
            TotalSum(2);
        }

        private void btnFiveMulSum_Click(object sender, EventArgs e)
        {
            TotalSum(5);
        }

        private void btnTenMulSum_Click(object sender, EventArgs e)
        {
            TotalSum(10);
        }
        #endregion

        #region < 판단 및 결과 메소드 >
        void TotalSum(int iNumber)
        {
            int iResult = 0;
            bool bFS = int.TryParse(txtStart.Text, out int iTS);
            bool bFE = int.TryParse(txtEnd.Text, out int iTE);

            if (!bFS || !bFE)
            {
                MessageBox.Show("범위에는 숫자를 넣어야합니다.");
                return;
            }

            if (iTS > iTE)
            {
                MessageBox.Show("범위가 올바르지 않습니다.");
                return;
            }

            if (iTS < 0 || iTE < 0)
            {
                MessageBox.Show("범위 값에 음수 값은 입력할 수 없습니다.");
                return;
            }

           
            for (int i = iTS; i <= iTE; i++)
            {
                if (i % iNumber == 0)
                {
                    iResult += i;
                }

                //switch (iNumber)
                //{
                //    case 2:
                //        iResult += Sum(i, 2);
                //        break; 
                //    case 5:
                //        iResult += Sum(i, 5);
                //        break;
                //    case 10:
                //        iResult += Sum(i, 10);
                //        break;
                //}
            }
            MessageBox.Show($"{iNumber}의 배수의 합은 : {iResult}입니다.");
        }
        #endregion

        #region < 계산 메소드 >
        int Sum(int i, int iNumber)
        {
            int iResult = 0;
            if (i % iNumber == 0)
            {
               iResult += i;
            }
            return iResult;
        }
        #endregion
    }
}
