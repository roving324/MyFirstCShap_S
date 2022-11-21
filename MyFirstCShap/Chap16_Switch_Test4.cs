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
    public partial class Chap16_Switch_Test4 : Form
    {
        int iTotalPrice = 0;
        public Chap16_Switch_Test4()
        {
            InitializeComponent();
        }

        void Total_Fruit(GroupBox GFruit, Label Templbl)
        {
            int iFruitCount = Convert.ToInt32(Templbl.Text);
            if (iFruitCount == 0)
            {
                MessageBox.Show($"{GFruit.Text}의 재고수량은 0개 입니다. 주문을 할 수 없습니다.");
                return;
            }
            --iFruitCount;
            Templbl.Text = Convert.ToString(iFruitCount);
            switch (GFruit.Text)
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
            Total_Fruit(groupBox1, lblAppCount);
        }

        private void btnMellon_Click(object sender, EventArgs e)
        {
            Total_Fruit(groupBox2, lblMelonCount);
        }

        private void btnW_M_Click(object sender, EventArgs e)
        {
            Total_Fruit(groupBox3, lblW_MCount);
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제 금액은 {iTotalPrice}원 입니다.");
        }
    }
}
