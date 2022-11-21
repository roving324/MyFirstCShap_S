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
    public partial class Chap15_Test : Form
    {
        //int ibtnClickCount = 0;
        public Chap15_Test()
        {
            InitializeComponent();
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            string txtBCC = txtBtnClickCount.Text;
            int iIn;

            txtBtnClickCount.Text = !(txtBCC == "") ? Convert.ToString(Convert.ToInt32(txtBCC) + 1) : "1";

            //++ibtnClickCount;
            //txtBtnClickCount.Text = ibtnClickCount.ToString();

            if (!int.TryParse(txtInoutValue.Text, out iIn))
            {
                MessageBox.Show("숫자가 아닙니다.");
                return;
            }

            if(1 <= iIn && iIn <= 100)
            {
                if(iIn % 2 == 0 && iIn % 5 == 0)
                {
                    MessageBox.Show("2,5 공배수 입니다.");
                }
                else
                {
                    MessageBox.Show("2,5 공배수가 아닙니다.");
                }

                if(iIn % 8 == 0)
                {
                    txtMultiE.Text = Convert.ToString(iIn * 8);
                }
                else
                {
                    txtMultiE.Text = "";
                }

                //FindE(iIn);
            }
            else
            {
                MessageBox.Show("1 부터 100 사이의 값이 아닙니다.");
            }
        }

        /*
        void FindE(int iValue)
        {
            if (iValue % 8 == 0)
            {
                txtMultiE.Text = Convert.ToString(iValue * 8);
            }
            else
            {
                txtMultiE.Text = "";
            }
        }
        */
    }
}
