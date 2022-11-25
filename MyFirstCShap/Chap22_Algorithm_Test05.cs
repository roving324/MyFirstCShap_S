using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstCSharp
{
    public partial class Chap22_Algorithm_Test05 : Form
    {
        // 난수 생성 클래스 객체 생성 
        Random Ran = new Random();
        int iNumber = 0;
        ArrayList aValues = new ArrayList();

        public Chap22_Algorithm_Test05()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            // 난수 생성 버튼 클릭

            // 1. 생성 된 난수를 int 변수에 담기
            int iValue = Ran.Next(0, 100);

            switch (iNumber)
            {
                case 0:
                    aValues.Remove(txtRan1.Text);
                    txtRan1.Text = Convert.ToString(iValue);
                    aValues.Insert(0,Convert.ToString(iValue));
                    iNumber++;
                    break;
                case 1:
                    aValues.Remove(txtRan2.Text);
                    txtRan2.Text = Convert.ToString(iValue);
                    aValues.Insert(0, Convert.ToString(iValue));
                    iNumber++;
                    break;
                case 2:
                    aValues.Remove(txtRan3.Text);
                    txtRan3.Text = Convert.ToString(iValue);
                    aValues.Insert(0, Convert.ToString(iValue));
                    iNumber = 0;
                    break;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 결과 버튼 클릭 
            if(txtRan1.Text == "" || txtRan2.Text == "" || txtRan3.Text == "")
            {
                MessageBox.Show("난수가 3개가 만들어져 있지 않습니다.");
                return;
            }

            int[] iValues = new int[aValues.Count];
            for (int i = 0; i < aValues.Count; i++)
            {
                iValues[i] = Convert.ToInt32(aValues[i]);
            }
            Array.Sort(iValues);

            if (iValues[0] + iValues[1] + iValues[2] < 100)
            {
                MessageBox.Show($"{iValues[0]} * {iValues[2]} = {iValues[0] * iValues[2]}");
                return;
            }
            if (iValues[0] + iValues[1] + iValues[2] >= 200)
            {
                MessageBox.Show("세 수의 합이 200이 넘습니다.");
                return;
            }
            MessageBox.Show($"{iValues[0]} + {iValues[2]} = {iValues[0] + iValues[2]}");
        }
    }
}
