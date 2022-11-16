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
    // 설비 가동/비가동 변경 클래스 활용 예제

    public partial class Chap12_ClassTest_Main : Form
    {
        public static string sRunStopStatus = "휴식중"; // 현재 상태를 나타내는 변수.

        public Chap12_ClassTest_Main()
        {
            InitializeComponent();
        }

        private void btnNowStatus_Click(object sender, EventArgs e)
        {
            // 설비의 현재 상태를 나타내는 메세지 표현.
            MessageBox.Show(sRunStopStatus);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // 작성한 Run 클래스를 객체화하여 실제로 사용할 수 있도록 하는 구문.
            Chap12_ClassTest_Run C_Run = new Chap12_ClassTest_Run();

            // Run 클래스가 WinForm 형식의 클래스인 경우 화면을 호출.
            C_Run.Show();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Chap12_ClassTest_Stop C_Stop = new Chap12_ClassTest_Stop();
            C_Stop.Show();
        }
    }
}
