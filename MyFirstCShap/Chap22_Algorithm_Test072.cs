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
    public partial class Chap22_Algorithm_Test072 : Form
    { 
        public Chap22_Algorithm_Test072()
        {
            InitializeComponent();
        }

        private void btnFindAndReplace_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;

            int iFindCount = 0; // ?를 찾은 횟수
            int iWordIndex = 0; // Foreach사 추출 한 문자의 index
            int iReusltIndex = 0; // 첫번째 ? index 와 3번째 ? index를 합칠 변수
            // Title 문자열에서 한글자씩 추출
            foreach (char cWord in sTitle)
            {
                if (cWord == '?')
                {
                    ++iFindCount;
                    if (iFindCount == 1 || iFindCount == 3) iReusltIndex += iWordIndex;
                    if (iFindCount == 3) break;
                }
                // 다음 추출한 문자열의 index
                ++iWordIndex;
            }
            string sValue = sTitle.Substring(iReusltIndex, 3);
            txtResult.Text = sTitle.Replace(sValue, "무궁화");
        }
    }
}
