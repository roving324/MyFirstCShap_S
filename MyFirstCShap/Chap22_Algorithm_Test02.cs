using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFirstCShap
{
    public partial class Chap22_Algorithm_Test02 : Form
    {
        public Chap22_Algorithm_Test02()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // int 배열에 등록.
            int[] iValues = { 1, 4, 8, 8, 8, 8, 16 };

            // 찾은 쌍을 누적시켜서 등록한 변수.
            string sValu = string.Empty;

            // 찾을 값의 Index를 저장할 변수.
            int iIndex = 0;

            // int i : 배열의 주소로 사용할 Int변수.
            for(int i = 0; i < iValues.Length; i++)
            {
                // 16 에서 현재 배열의 값을 차감했을 때 값 찾기.
                int iFindValue = 16 - iValues[i];

                // 찾는 값이 없을 경우 -1 반환, 찾는 값이 있을 경우 해당 주소값 반환.
                iIndex = Array.IndexOf(iValues, iFindValue);

                if(iIndex == -1 || i == iIndex)
                {
                    // 찾을 값이 배열에 없을 경우 다음 위치의 배열 값으로 계속 반복.
                    // 또는 자기자신을 찾았을 경우
                    continue;
                }

                sValu += $"{iValues[i]},{iFindValue}\r\n";
            }
            MessageBox.Show(sValu);
        }
    }
}
