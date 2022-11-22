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
    public partial class Chap17_Loop01_ForTest06 : Form
    {
        public Chap17_Loop01_ForTest06()
        {
            InitializeComponent();
        }

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

        void TotalSum(int NumberName)
        {
            bool bFSart = int.TryParse(txtStart.Text, out int iStart);
            bool bFEnd = int.TryParse(txtEnd.Text, out int iEnd);

            if (!bFSart || !bFEnd)
            {
                MessageBox.Show("범위 값에는 숫자를 입력해야합니다.");
            }

            if (iStart < 0 || iEnd < 0)
            {
                MessageBox.Show("범위 값에는 음수 값을 입력할 수 없습니다.");
            }

            if (iStart > iEnd)
            {
                MessageBox.Show("범위가 올바르지 않습니다.");
            }
            int iResult = 0;
            for (int i = iStart; i <= iEnd; i++)
            {
                if (i % NumberName == 0)
                {
                    iResult += i;
                }
            }
            MessageBox.Show($"{NumberName}의 배수 합은 : {iResult}입니다.");
        }
    }
}
