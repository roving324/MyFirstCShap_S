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
    public partial class Chap23_Application_Test3 : Form
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
        public Chap23_Application_Test3()
        {
            InitializeComponent();
        }

        // 과일 금액
        private int iAppPrice = 2000;
        private int iMelPrice = 2500;
        private int iWMPrice  = 18000;

        void CheckFruitM_P(string sFruitName,ref int iFruitCount, Label Temlbl)
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
            if(iTotalPrice <= 0)
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

        private void btnCommitsale_Click(object sender, EventArgs e)
        {
            // 주문 내역 결제 하기

            // 주문 내역이 있는지 확인.
            if (iTotalPrice == 0)
            {
                MessageBox.Show("결제 할 내역이 없습니다.");
                return;
            }

            // 고객 남아있는 금액이 주문 금액보다 적은지 확인.
            int iCustCash = Convert.ToInt32(lblCustCash.Text);
            int iManCash = Convert.ToInt32(lblManCash.Text);
            
            if(iCustCash < iTotalPrice)
            {
                MessageBox.Show("주문 금액이 잔액보다 많습니다. 결제를 할 수 없습니다. 그지야!");
                return;
            }

            // 결제 로직을 정상적으로 처리
            lblCustCash.Text= Convert.ToString(iCustCash - iTotalPrice);
            lblManCash.Text = Convert.ToString(iManCash + iTotalPrice);

            int iAppOrdCnt = iAppCnt - it_Appcnt; // 사과 주문 수량
            int iMelOrdCnt = iMelCnt - it_Melcnt;
            int iWMOrdCnt  = iWMCnt  - it_WMcnt;

            // 판매 내역 리스트 표시.
            txtSaleList.Text += "--------판매 내역---------";
            if (iAppOrdCnt > 0) txtSaleList.Text += $"사과 판매 개수 : {iAppOrdCnt} , 판매 금액 {iAppOrdCnt * iAppPrice} ";
            if (iMelOrdCnt > 0) txtSaleList.Text += $"참외 판매 개수 : {iMelOrdCnt} , 판매 금액 {iMelOrdCnt * iMelPrice} ";
            if (iWMOrdCnt  > 0) txtSaleList.Text += $"수박 판매 개수 : {iWMOrdCnt} , 판매 금액 {iWMOrdCnt * iWMPrice} ";

            // 과일의 재로 수량을 주문 수량 잔량으로 Update
            iAppCnt = it_Appcnt;
            iMelCnt = it_Melcnt;
            iWMCnt  = it_WMcnt;

            MessageBox.Show($"{iTotalPrice}원의 결제를 완료 하였습니다.");
            iTotalPrice = 0;
        }
    }
}
