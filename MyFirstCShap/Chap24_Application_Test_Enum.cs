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
    public enum FruitName
    {
        사과, // 0 
        참외, // 1
        수박  // 2
    }
    public partial class Chap24_Application_Test_Enum : Form
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

        // 과일 금액
        private int iAppPrice = 2000;
        private int iMelPrice = 2500;
        private int iWMPrice = 18000;

        // 과일 마진 금액
        Dictionary<FruitName, int> dMargin = new Dictionary<FruitName, int>();

        // 과일 이름
        //const string sApple = "사과";
        //const string sMelon = "참외"; // 변경될 수 없는 값
        //const string sW_M = "수박";

        public Chap24_Application_Test_Enum()
        {
            InitializeComponent();
            dMargin.Add(FruitName.사과, 0);
            dMargin.Add(FruitName.참외, 0);
            dMargin.Add(FruitName.수박, 0);
        }

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
            txtSaleList.Text += "--------판매 내역---------\r\n";
            if (iAppOrdCnt > 0) txtSaleList.Text += $"사과 판매 개수 : {iAppOrdCnt} , 판매 금액 {iAppOrdCnt * iAppPrice}\r\n";
            if (iMelOrdCnt > 0) txtSaleList.Text += $"참외 판매 개수 : {iMelOrdCnt} , 판매 금액 {iMelOrdCnt * iMelPrice}\r\n";
            if (iWMOrdCnt  > 0) txtSaleList.Text += $"수박 판매 개수 : {iWMOrdCnt} , 판매 금액 {iWMOrdCnt * iWMPrice}\r\n";

            // 과일의 재고 수량을 주문 수량 잔량으로 Update
            iAppCnt = it_Appcnt;
            iMelCnt = it_Melcnt;
            iWMCnt  = it_WMcnt;

            MessageBox.Show($"{iTotalPrice}원의 결제를 완료 하였습니다.");
            iTotalPrice = 0;

            // 마진 처리하기
            dMargin[FruitName.사과] += iAppOrdCnt * iAppPrice; // 사과 판매 내역
            dMargin[FruitName.참외] += iMelOrdCnt * iMelPrice; // 참외 판매 내역
            dMargin[FruitName.수박] += iWMOrdCnt * iWMPrice;   // 수박 판매 내역
        }

        private void btnInvOrder_Click(object sender, EventArgs e)
        {
            // 관리자 과일 재고 및 입고 등록.

            // 과일의 발주 개수 파악
            int iAOrdCnt;
            int iMOrdCnt;
            int iWOrdCnt;

            // 텍스트박스에 입력한 문자가 숫자형식으로 바뀔수 있는 데이터 인지 확인
            int.TryParse(txtAppInvoiceCnt.Text, out iAOrdCnt);
            int.TryParse(txtMellonInvoiceCnt.Text, out iMOrdCnt);
            int.TryParse(txtW_MInvoiceCnt.Text, out iWOrdCnt);  // 자동완성 ctrl + j

            // 발주 금액
            int iAOrdPrice = Convert.ToInt32(iAOrdCnt * iAppPrice * 0.6);
            int iMOrdPrice = Convert.ToInt32(iMOrdCnt * iMelPrice * 0.6);
            int iWOrdPrice = Convert.ToInt32(iWOrdCnt * iWMPrice * 0.6);

            // 총 발주 금액
            int iTotalOrdPrice = iAOrdPrice + iMOrdPrice + iWOrdPrice;

            // 관리자의 가게 잔액보다 큰 발주를 내었는지 확인
            int iManCash = Convert.ToInt32(lblManCash.Text);

            if(iManCash < iTotalOrdPrice)
            {
                MessageBox.Show("가게 잔액보다 발주 금액이 많습니다.");
                return;
            }

            // 가게 잔액 차감
            lblManCash.Text = Convert.ToString(iManCash - iTotalOrdPrice);

            // 발주 내역 영수증 출력
            txtSaleList.Text += "--------------발주 내역-------------\r\n";
            if (iAOrdPrice > 0) txtSaleList.Text += $"사과 발주 수량 : {iAOrdCnt} 개, 발주금액 : {iAOrdPrice} 원\r\n";
            if (iMOrdPrice > 0) txtSaleList.Text += $"참외 발주 수량 : {iMOrdCnt} 개, 발주금액 : {iMOrdPrice} 원\r\n";
            if (iWOrdPrice > 0) txtSaleList.Text += $"수박 발주 수량 : {iWOrdCnt} 개, 발주금액 : {iWOrdPrice} 원\r\n";
            // 재고 증가.
            iAppCnt = it_Appcnt += iAOrdCnt;
            lblAppCount.Text = Convert.ToString(iAppCnt);
            iMelCnt = it_Melcnt += iMOrdCnt;
            lblMelonCount.Text = Convert.ToString(iMelCnt);
            iWMCnt = it_WMcnt += iWOrdPrice;
            lblW_MCount.Text = Convert.ToString(iWMCnt);

            // 마진 처리하기
            dMargin[FruitName.사과] -= iAOrdPrice; // 사과 발주 내역
            dMargin[FruitName.참외] -= iMOrdPrice; // 참외 발주 내역
            dMargin[FruitName.수박] -= iWOrdPrice; // 수박 발주 내역
        }

        private void btnMarginUnit_Click(object sender, EventArgs e)
        {
            // 개별 마진 보기
            string sFruitName = string.Empty;
            if     (rdoApple.Checked)  sFruitName = "사과";
            else if(rdoMellon.Checked) sFruitName = "참외";
            else if(rdoW_M.Checked)    sFruitName = "수박";
            //MessageBox.Show($"{sFruitName}의 마진은 {dMargin[sFruitName]} 입니다.");
        }

        private void btnMarginTotal_Click(object sender, EventArgs e)
        {
            // 판매 / 발주 총 마진 금액 산출 및 표현
            int iTotalMargin = 0; // 총 마진 누적 변수
            foreach(int iFruitMargin in dMargin.Values)
            {
                iTotalMargin += iFruitMargin;
            }
            MessageBox.Show($"과일의 총 마진은 {iTotalMargin} 입니다.");
        }

        private void btnInvClear_Click(object sender, EventArgs e)
        {
            txtAppInvoiceCnt.Text = "";
            txtMellonInvoiceCnt.Text = "";
            txtW_MInvoiceCnt.Text = "";
        }
    }
}
