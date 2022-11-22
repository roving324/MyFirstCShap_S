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
    public partial class Chap18_Loop02_While : Form
    {
        public Chap18_Loop02_While()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // 1 부터 100 까지의 합 While 문으로 표현

            // 1. 조건 변수 생성.
            int iCount = 0; // While 문이 실행되는 조건변수
            int iResult = 0; // 1 부터 100까지의 합이 누적되는 변수.

            // 2. 조건으로 While 문 실행.
            while(iCount <= 100) // iCount 값이 1000 이하 일 때 까지 반복하라.
            {
                ++iCount;
                if(iCount >= 20 && iCount <= 30) 
                {
                    continue;
                }

                iResult += iCount;

                if(iResult > 1000)
                {
                    break;
                }
            }
            MessageBox.Show(Convert.ToString(iResult));
        }

        private void btnWhileNonExit_Click(object sender, EventArgs e)
        {
            // 무한 루프를 구현 해야하는 경우.
            // 서버의 채팅 내용을 나뉘어 프로그램에서 지속적으로 표현해야할 때
            // 불규칙적으로 들어오는 데이터를 항상 관리해야 하므로
            // 무한 루프를 이용하여 구현한다.

            // 무한 루프를 표현할 때는 일반적으로 True (Bool) 형태로 구현한다.

            // 1. 변수 생성.
            int iCount = 0;
            int iResult = 0;
            while (true)
            {
                ++iCount;
                if(iCount >= 30 && iCount <= 50)
                {
                    continue;
                }
                iResult += iCount;
                if (iResult > 1000)
                {
                    break;
                }
            }
            MessageBox.Show(Convert.ToString(iResult));
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            // do ~ While
            // 반복문을 실행을 하지만 무조건 최초 1회는 실행 될 수 있도록 해주는
            // 반복문

            int iCount = 1000;
            int iResult = 0;

            do
            {
                ++iCount;
                iResult += iCount;
            }
            while (iCount <= 100);
            MessageBox.Show(Convert.ToString(iResult)); // 1001
        }
    }
}
