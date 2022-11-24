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
    public partial class Chap22_Algorithm_Test01 : Form
    {
        public Chap22_Algorithm_Test01()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 1. 배열에 값 넣기.
            string[] Arry_Split = label2.Text.Split(",");
            int iCount = Arry_Split.Length;
            int[] iValues = new int[iCount];
            string sValue = "";

            for (int i = 0; i < iCount; i++)
            {
                iValues[i] = Convert.ToInt32(Arry_Split[i]);
            }

            // 2. 2개의 정수 합이 16인 값을 찾는 로직.
            int j = 0;
            Queue<string> Que = new Queue<string>();

            for (int k = 1; k < iCount; k++)
            {
                if (iValues[j] + iValues[k] == 16)
                {
                    Que.Enqueue($"{iValues[j]} , {iValues[k]}");
                }
                if (j == iCount - 2)
                {
                    break;
                }
                if (k == iCount - 1)
                {
                    j++;
                    k = j;
                }
            }

            // 3. 결과 메세지박스로 표현.
            while (Que.Count > 0)
            {
                sValue += $" {Que.Dequeue()}\r\n";
            }
            MessageBox.Show(sValue);
        }
    }
}
