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
    public partial class Chap23_Application_Test : Form
    {
        Dictionary<string, int> MyDic = new Dictionary<string, int>();
        int iSubAppCount    = 0;
        int iSubMellonCount = 0;
        int iSubiW_MCount   = 0;

        int iTotalPrice     = 0;
        int iSubAppPrice    = 0;
        int iSubMellonPrice = 0;
        int iSubW_MPrice    = 0;

        public Chap23_Application_Test()
        {
            InitializeComponent();
            MyDic.Add("사과", 0);
            MyDic.Add("참외", 0);
            MyDic.Add("수박", 0);
        }

        void CheckFruitM_P(string sFruitName, Label Temlbl)
        {
            int iFruitCount = Convert.ToInt32(Temlbl.Text);
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
                    iSubAppPrice    += 2000;
                    ++iSubAppCount;
                    break;
                case "참외":
                    iSubMellonPrice += 2500;
                    ++iSubMellonCount;
                    break;
                case "수박":
                    iSubW_MPrice    += 18000;
                    ++iSubiW_MCount;
                    break;
            }
            iTotalPrice = iSubAppPrice + iSubMellonPrice + iSubW_MPrice;
            Temlbl.Text = Convert.ToString(iFruitCount);
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("사과", lblAppCount);
        }

        private void btnMellon_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("참외", lblMelonCount);
        }

        private void btnW_M_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("수박", lblW_MCount);
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제 금액은 {iTotalPrice}원 입니다.");
        }

        private void btnOrderCancle_Click(object sender, EventArgs e)
        {
            if (iTotalPrice == 0)
            {
                MessageBox.Show("취소 할 주문 내역이 없습니다.");
                return;
            }

            lblAppCount.Text   = $"{Convert.ToInt32(lblAppCount.Text) + iSubAppCount}";
            lblMelonCount.Text = $"{Convert.ToInt32(lblMelonCount.Text) + iSubMellonCount}";
            lblW_MCount.Text   = $"{Convert.ToInt32(lblW_MCount.Text) + iSubiW_MCount}";
            intEarly();
        }

        private void btnCommitsale_Click(object sender, EventArgs e)
        {
            int iCash    = Convert.ToInt32(lblCustCash.Text);
            int iManCash = Convert.ToInt32(lblManCash.Text);

            int iCustTotalCash = iCash - iTotalPrice;

            if (iCustTotalCash <= 0)
            {
                MessageBox.Show("결제할 돈이 부족합니다.");
                return;
            }
            if (iTotalPrice == 0)
            {
                MessageBox.Show("주문 내역이 없습니다.");
                return;
            }
            txtTradehistory.Text += $"--------------판매 내역--------------\r\n";
            if (iSubAppCount > 0)    txtTradehistory.Text += $"사과 판매 개수 : {iSubAppCount}, 판매내역 : {iSubAppPrice}\r\n";
            if (iSubMellonCount > 0) txtTradehistory.Text += $"참외 판매 개수 : {iSubMellonCount}, 판매내역 : {iSubMellonPrice}\r\n";
            if (iSubiW_MCount > 0)   txtTradehistory.Text += $"수박 판매 개수 : {iSubiW_MCount}, 판매내역 : {iSubW_MPrice}\r\n";

            MyDic["사과"] += iSubAppCount * 2000;
            MyDic["참외"] += iSubMellonCount *2500;
            MyDic["수박"] += iSubiW_MCount * 18000;

            lblCustCash.Text = Convert.ToString(iCustTotalCash);
            lblManCash.Text  = Convert.ToString(iManCash + iTotalPrice);

            MessageBox.Show($"{iTotalPrice}원 결제되었습니다.");
            intEarly();
        }

        private void btnInvOrder_Click(object sender, EventArgs e)
        {
            int iHostCash = Convert.ToInt32(lblManCash.Text);

            int.TryParse(txtAppInvoiceCnt.Text   , out int iInAppCount);
            int.TryParse(txtMellonInvoiceCnt.Text, out int iInMellonCount);
            int.TryParse(txtW_MInvoiceCnt.Text   , out int iInWMCount);

            int iResultPrice = iInAppCount * 1200 + iInMellonCount * 1500 + iInWMCount * 10800;
            int iResultCash  = iHostCash - iResultPrice;

            if (iInAppCount == 0 && iInMellonCount == 0 && iInWMCount == 0)
            {
                MessageBox.Show("발주할 개수를 입력해야합니다.");
                return;
            }
            if (iResultCash <= 0)
            {
                MessageBox.Show("가게 예산이 부족합니다.");
                return;
            }

            txtTradehistory.Text += "--------------발주 내역--------------\r\n";
            if (iInAppCount > 0)    txtTradehistory.Text += $"사과 발주 수량 : {iInAppCount}, 발주금액 : {iInAppCount * 1200}\r\n";
            if (iInMellonCount > 0) txtTradehistory.Text += $"참외 발주 수량 : {iInMellonCount}, 발주금액 : {iInMellonCount * 1500}\r\n";
            if (iInWMCount > 0)     txtTradehistory.Text += $"수박 발주 수량 : {iInWMCount}, 발주금액 : {iInWMCount * 10800} \r\n";

            lblAppCount.Text   = $"{Convert.ToInt32(lblAppCount.Text) + iInAppCount}";
            lblMelonCount.Text = $"{Convert.ToInt32(lblMelonCount.Text) + iInMellonCount}";
            lblW_MCount.Text   = $"{Convert.ToInt32(lblW_MCount.Text) + iInWMCount}";
            lblManCash.Text    = $"{iResultCash}";

            MyDic["사과"] -= iInAppCount *1200;
            MyDic["참외"] -= iInMellonCount *1500;
            MyDic["수박"] -= iInWMCount * 10800;

            txtEarly();

            MessageBox.Show($"총 {iResultPrice}원 발주가 완료되었습니다.");
        }

        private void btnInvClear_Click(object sender, EventArgs e)
        {
            txtEarly();
        }

        private void btnMarginUnit_Click(object sender, EventArgs e)
        {
            string sFruitName = string.Empty;
            if     (rdoApple.Checked)  sFruitName = "사과";
            else if(rdoMellon.Checked) sFruitName = "참외";
            else if(rdoW_M.Checked)    sFruitName = "수박";
            MessageBox.Show($"{sFruitName} 마진은 {MyDic[sFruitName]}원 입니다.");
        }

        private void btnMarginTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 마진은 {MyDic["사과 마진"] + MyDic["참외 마진"] + MyDic["수박 마진"]}원 입니다.");
        }

        void intEarly()
        {
            iSubAppCount    = 0;
            iSubMellonCount = 0;
            iSubiW_MCount   = 0;
            iTotalPrice     = 0;
            iSubAppPrice    = 0;
            iSubMellonPrice = 0;
            iSubW_MPrice    = 0;
        }
        void txtEarly()
        {
            foreach(Control Obj in groupBox6.Controls) if(Obj is TextBox) Obj.Text = string.Empty;
        }
    }
}
