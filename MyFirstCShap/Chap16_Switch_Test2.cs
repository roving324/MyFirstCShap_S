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
    public partial class Chap16_Switch_Test2 : Form
    {
        int iTotalPrice = 0; // 사과, 참외, 수박을 주문한 총 금액이 담기는 변수.
        public Chap16_Switch_Test2()
        {
            InitializeComponent();
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            int iAppCount = Convert.ToInt32(lblAppCount.Text); // 현재 사과의 재고 수량.
            /*
            if(iAppCount > 0 )
            {
                // 사과 주문 시 재고 차감.
                --iAppCount;
                lblAppCount.Text = Convert.ToString(iAppCount);
            }
            else
            {
                MessageBox.Show("사과의 재고 수량이 0입니다. 주문 할 수 없습니다.");
            }
            */

            if(iAppCount == 0)
            {
                MessageBox.Show("사과의 재고 수량이 0입니다. 주문 할 수 없습니다.");
                return;
            }

            // 재고 수량 차감
            --iAppCount;
            lblAppCount.Text = Convert.ToString(iAppCount);

            // 총 구매금액 증가
            iTotalPrice += 2000;
        }

        private void btnMellon_Click(object sender, EventArgs e)
        {
            int iMellonCount = Convert.ToInt32(lblMelonCount.Text);
            if (iMellonCount == 0)
            {
                MessageBox.Show("참외의 재고 수량이 0입니다. 주문 할 수 없습니다.");
                return;
            }

            --iMellonCount;
            lblAppCount.Text = Convert.ToString(iMellonCount);

            iTotalPrice += 2500;
        }

        private void btnW_M_Click(object sender, EventArgs e)
        {
            int iW_MCount = Convert.ToInt32(lblW_MCount.Text);
            if (iW_MCount == 0)
            {
                MessageBox.Show("수박의 재고 수량이 0입니다. 주문 할 수 없습니다.");
                return;
            }
            
            --iW_MCount;
            lblAppCount.Text = Convert.ToString(iW_MCount);

            iTotalPrice += 18000;
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제 금액은 {iTotalPrice}원 입니다.");
        }
    }
}
