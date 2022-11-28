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
    public partial class Chap23_Application_Test2 : Form
    {
        private int iTotalPrice = 0;

        // 현재 실재고 수량 변수.
        private int iAppCnt = 10;
        private int iMelCnt = 10;
        private int iWMCnt  = 10;

        // 고객이 주문을 하여 변동하는 재고.
        private int it_Appcnt = 10; // 고객이 주문을 클릭하여 남는 재고
        private int it_Melcnt = 10;
        private int it_WMcnt = 10;
        public Chap23_Application_Test2()
        {
            InitializeComponent();
        }

        void CheckFruitM_P(string sFruitName, ref int iFruitCount, Label Temlbl)
        {
            if (iFruitCount == 0)
            {
                MessageBox.Show($"{sFruitName}의 재고 수량이 0입니다. 주문 할 수 없습니다.");
                return;
            }
            --iFruitCount;
            Temlbl.Text = Convert.ToString(iFruitCount);
            switch (sFruitName)
            {
                case "사과":
                    iTotalPrice += 2000;
                    break;
                case "참외":
                    iTotalPrice += 2500;
                    break;
                case "수박":
                    iTotalPrice += 18000;
                    break;
            }
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("사과", ref it_Appcnt, lblAppCount);
        }

        private void btnMellon_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("참외", ref it_Melcnt, lblMelonCount);
        }

        private void btnW_M_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("수박", ref it_WMcnt, lblW_MCount);
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제 금액은 {iTotalPrice}원 입니다.");
        }

        private void btnOrderCancle_Click(object sender, EventArgs e)
        {
            // 1. 취소 내역이 없을 경우 취소 내역이 없다는 메세지 보여주기.
            if (iTotalPrice <= 0)
            {
                MessageBox.Show("취소 할 주문 내역이 없습니다.");
                return;
            }

            // 2. 주문 취소 로직 시작.
            // 주문을 하기 전 수량(실제고 수량)으로 원상복구.

            it_Appcnt = iAppCnt;
            it_Melcnt = iMelCnt;
            it_WMcnt = iWMCnt;

            lblAppCount.Text = Convert.ToString(iAppCnt);
            lblMelonCount.Text = Convert.ToString(iMelCnt);
            lblW_MCount.Text = Convert.ToString(iWMCnt);

            iTotalPrice= 0;
        }
    }
}
