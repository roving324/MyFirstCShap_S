using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCShap
{
    public partial class Chap20_Array_Test : Form
    {
        public Chap20_Array_Test()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int[,] iValues = new int[4,5] { {1,2,3,4,5},{6,7,8,9,10},{11,12,13,14,15},{16,17,18,19,20} };
            int[,] iNewValues = new int[iValues.GetLength(0), iValues.GetLength(1)];
            int iColum = iValues.GetLength(0) - 1;

            for (int i = 0; i < iValues.GetLength(0); i++)
            {
                for (int k = 0; k < iValues.GetLength(1); k++)
                {
                    txtResult.Text += (i != 0 && k == 0) ? "\r\n" : "";
                    txtResult.Text += (k == 0) ? $"{i + 1}행:" : "";
                    iNewValues[i, k] = iValues[iColum, k];
                    txtResult.Text += $" {iNewValues[i, k]} ";
                }
                --iColum;
            }
        }
    }
}
