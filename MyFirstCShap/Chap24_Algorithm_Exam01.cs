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
            txtResult.Text= string.Empty;
            // 랜덤 난수 생성 및 없는 수 합치기.
            Dictionary<int, int> Dic = new Dictionary<int, int>();
            Random ran = new Random();
            int[] iValues = new int[20];
            int iResults = 0;
            string sValues = string.Empty;

            for (int i = 0; i < 20; i++)
            {
                int iResult = ran.Next(0, 20);
                txtResult.Text += Convert.ToString(iResult) + " ";
                if (Dic.ContainsKey(iResult)) continue;
                else Dic.Add(iResult, 0);
            }
            
            for (int i = 0; i <= 20; i++)
            {
                if (!(Dic.ContainsKey(i)))
                {
                    Dic.Add(i, i);
                    sValues += Dic[i] + " ";
                    iResults += Dic[i];
                }
            }
            MessageBox.Show($"난수 중 {sValues} 가 없으며 총 합은 {iResults} 입니다.");
        }
    }
}
