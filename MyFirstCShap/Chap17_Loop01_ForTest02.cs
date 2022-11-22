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
    public partial class Chap17_Loop01_ForTest02 : Form
    {
        public Chap17_Loop01_ForTest02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1부터 100까지 수 중 짝수의 총합과 홀수의 총합 구하는 로직.
            int iOdd = 0; // 홀수 값을 더해서 표현할 변수.
            int iEven = 0; // 짝수 값을 더해서 표현할 변수.
            int i = 0;

            for(i = 0; i <= 100; i++)
            {
                if (i % 2 == 0) // 만약에 i에 들어온 값을 2로 나누어 나머지가 0 이라면 (짝수)
                {
                    iEven += i;
                }
                else
                {
                    iOdd += i;
                }
            }
            MessageBox.Show($"총 반복 횟수는 : {i}입니다.");
            MessageBox.Show($"짝수의 합은 : {iEven}입니다.");
            MessageBox.Show($"홀수의 합은 : {iOdd}입니다.");
        }
    }
}
