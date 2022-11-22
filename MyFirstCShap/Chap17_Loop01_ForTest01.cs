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
    public partial class Chap17_Loop01_ForTest01 : Form
    {
        public Chap17_Loop01_ForTest01()
        {
            InitializeComponent();
        }

        private void btnOdEvSum_Click(object sender, EventArgs e)
        {
            int iEv = 0;
            int iOd = 0;
            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    iEv += i;
                }
                else
                {
                    iOd += i;
                }
            }
            MessageBox.Show($"짝수의 합 : {iEv}");
            MessageBox.Show($"홀수의 합 : {iOd}");
        }
    }
}
