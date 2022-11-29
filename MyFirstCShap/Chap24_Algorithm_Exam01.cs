using System; 
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap24_Algorithm_Exam01 : Form
    {
        public Chap24_Algorithm_Exam01()
        {
            InitializeComponent();
        }

        private void btnMakeRandomAndSum_Click(object sender, EventArgs e)
        {
            // 랜덤 난수 생성 및 없는 수 합치기.
            Random ran = new Random();
            int[] iValues = new int[20];
            int iResults = 0;
            for (int i = 0; i < 20; i++)
            {
                int iResult = ran.Next(0, 20);
                txtResult.Text += Convert.ToString(iResult) + " ";
                
                iValues[i] = iResult;
            }
            Array.Sort(iValues);
            string sValues = "";
            int iFind = -1;
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (i == iValues[j])
                    {
                        break;
                    }
                    if (iFind == i)
                    {
                        break;
                    }
                    iFind = i;
                    sValues += i.ToString() + " ";
                    iResults += i;
                }
            }
            MessageBox.Show($"난수 중 {sValues} 가 없으며 총 합은 {iResults} 입니다.");
        } 
    }
}
