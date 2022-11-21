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
    public partial class Chap16_Switch : Form
    {
        public Chap16_Switch()
        {
            InitializeComponent();
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            // "사과" 입력 후 버튼 클릭할 때 메세지 : 사과의 결과값은 1입니다.
            // "참외" 입력 후 버튼 클릭할 때 메세지 : 참외의 결과값은 2입니다.
            // "수박" 입력 후 버튼 클릭할 때 메세지 : 수박의 결과값은 3입니다.

            // if 문의 활용
            string sValue = txtFruit.Text;
            int iResult = 0;
            if (sValue == "사과")
            {
                iResult = 1;
                stringFruit(sValue, iResult);
            }
            else if (sValue == "참외")
            {
                iResult = 2;
                stringFruit(sValue, iResult);
            }
            else if (sValue == "수박")
            {
                iResult = 3;
                stringFruit(sValue, iResult);
            }
            else
            {
                stringFruit(sValue, iResult);
            }
        }

        void stringFruit(string sValue, int iResult)
        {
            MessageBox.Show($"{sValue}의 결과값은 {iResult}입니다.");
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            // if 문으로 구현한 내용을 Switch로 구현.
            string sValue = txtFruit.Text;
            int iResult = 0;

            switch (sValue)
            {
                case "사과":
                    iResult = 1;
                    break;
                case "참외":
                    iResult = 2;
                    break;
                case "수박":
                    iResult = 3;
                    break;
                default: // 사과, 수박, 참외가 아닐 경우.
                    iResult = 0 ;
                    break;
            }
            stringFruit(sValue, iResult);
        }
    }
}
