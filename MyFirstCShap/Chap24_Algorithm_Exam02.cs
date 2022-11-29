using System; 
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap24_Algorithm_Exam02 : Form
    {
        public Chap24_Algorithm_Exam02()
        {
            InitializeComponent();
        }

        private void  btnOperate_Click(object sender, EventArgs e)
        {
            // 랜덤 난수 생성 클래스
            Random Ran = new Random();
            int iPrice = Ran.Next(100, 3000);
            int iCount = Ran.Next(1, 20);
            int iMyPrice = Ran.Next(10000, 500000);
            int iPriceCount = iPrice * iCount;
            int iResultPrice = iMyPrice - iPriceCount * iCount;

            if(iResultPrice < 0)
            MessageBox.Show($"{iMyPrice} 원이 있을 때 이용요금 {iPrice} 원 인 놀이기구를 {iCount} 번 타면 {-iResultPrice} 원이 모자릅니다.");
            else
            MessageBox.Show($"{iMyPrice} 원이 있을 때 이용요금 {iPrice} 원 인 놀이기구를 {iCount} 번 타면 {iResultPrice} 원이 남습니다.");
        }
    }
}
