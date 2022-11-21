﻿using System;
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
    public partial class Chap16_Switch_Test3 : Form
    {
        private int iTotalPrice = 0;
        // 메서드로 간추리기 방법
        // .반복적으로 수행하는 로직을 매서드로 만들어 간추리기 함.
        public Chap16_Switch_Test3()
        {
            InitializeComponent();
        }

        void CheckFruitM_P(string sFruitName, int iFruitCount, Label Temlbl)
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
            CheckFruitM_P("사과",Convert.ToInt32(lblAppCount.Text), lblAppCount);
        }

        private void btnMellon_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("참외", Convert.ToInt32(lblMelonCount.Text), lblMelonCount);
        }

        private void btnW_M_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("수박", Convert.ToInt32(lblW_MCount.Text), lblW_MCount);
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제 금액은 {iTotalPrice}원 입니다.");
        }
    }
}
