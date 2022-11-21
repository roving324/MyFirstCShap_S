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
    public partial class Chap16_Switch_Test : Form
    {
        int iACount = 10;
        int iMCount = 10;
        int iW_MCount = 10;
        int iTotal = 0;
        public Chap16_Switch_Test()
        {
            InitializeComponent();
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            Count("사과", lblAppCount.Text);
        }

        private void btnMellon_Click(object sender, EventArgs e)
        {
            Count("참외", lblMellonCount.Text);
        }

        private void btnW_M_Click(object sender, EventArgs e)
        {
            Count("수박", lblW_MCount.Text);
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제 금액은 {iTotal}원입니다.");
        }

        void Count(string fruit, string sValue)
        {
            if (sValue == "0")
            {
                MessageBox.Show($"{fruit}의 남은 수량이 0개 입니다. 주문을 할 수 없습니다.");
                return;
            }
            switch (fruit)
            {
                case "사과":
                    --iACount;
                    lblAppCount.Text = iACount.ToString();
                    iTotal += 2000;
                    break;
                case "참외":
                    --iMCount;
                    lblMellonCount.Text = iMCount.ToString();
                    iTotal += 2500;
                    break;
                case "수박":
                    --iW_MCount;
                    lblW_MCount.Text = iW_MCount.ToString();
                    iTotal += 18000;
                    break;
            }
        }
    }

}
