using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap22_Algorithm_Test071 : Form
    { 
        public Chap22_Algorithm_Test071()
        {
            InitializeComponent();
        }

        private void btnFindAndReplace_Click(object sender, EventArgs e)
        {
            // 첫번째 ? 위치와 세번째 ? 위치의 합에서 3글자를 "무궁화"
            string sTitle = lblTitle.Text;
            string sBaseWorld = string.Empty; // 기준 문자열을 담을 변수

            int iFindCount = 0; // ?를 찾은 횟수
            int iIndexResult = 0;
            // 동해물과 백두산이? 마르고 닳?도록 .....

            // 1. 문자열을 한글자씩 가지고 와서 ? 인지 비교.
            // int i = 문자열의 위치 주소를 나타내는 int
            for (int i = 0; i < sTitle.Length; i++)
            {
                // 기준 문자열
                sBaseWorld = sTitle.Substring(i, 1);

                // 지금 위치에서 한글자 추출한 문자가 ? 인지
                if(sBaseWorld == "?")
                {
                    ++iFindCount; // ?를 찾은 횟수

                    // 첫 번째 ?인지, 3번째 ?인지 비교
                    if (iFindCount == 1 || iFindCount == 3) iIndexResult += i;
                    if (iFindCount == 3) break; // 세번째 ? 를 찾았을 경우는 For 문 종료
                }
            }
           string sValue = sTitle.Substring(iIndexResult, 3);
            txtResult.Text = sTitle.Replace(sValue, "무궁화");

        }
    }
}
