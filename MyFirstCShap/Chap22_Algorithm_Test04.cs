using System;
using System.Collections;
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
    public partial class Chap22_Algorithm_Test04 : Form
    {
        public Chap22_Algorithm_Test04()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int[,] iValues = { { 1, 4, 5, 9, 10, 12, 16 },
                               { 2, 7, 11, 13, 14, 15, 18} };
            string sResult = string.Empty;
            Dictionary<char, int> MyDic = new Dictionary<char, int>();
            int iCount = 0;
            int iCount2 = 0;

            foreach (char Char in iValues)
            {
                iCount++;
                iResult = 20 - Char;  // 16 -> 4
                if (MyDic.ContainsKey(Convert.ToChar(iResult)))
                {
                    MyDic[Char] = 1;
                }
                else
                {
                    MyDic.Add(Char, 0);
                }

                MyDic.ContainsValue(1);
                for(int i = 0; i < iValues.GetLength(0); i++)
                {
                    for (int j = 0; j < iValues.GetLength(1); j++)
                    {
                        iCount2++;
                        if (iResult == iValues[i, j] && !(MyDic.ContainsKey(Convert.ToChar(iResult)) && MyDic.ContainsValue(1)) && !(iCount == iCount2))
                        {
                            sResult += $"{20-iResult},{iValues[i, j]}\r\n";
                        }
                    }
                }
                iCount2 = 0;
            }
            MessageBox.Show(sResult);
        }
    }
}