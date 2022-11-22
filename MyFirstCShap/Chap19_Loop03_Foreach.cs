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
    public partial class Chap19_Loop03_Foreach : Form
    {
        // foreach
        // 조건의 끝을 지정해주는 반복문(For, While) 과는 달리
        // 인자로 들어오는 Object 의 내부 인덱스 끝까지 알아서 순환을 해주는 반복문.
        // 종료 조건이 따로 없어도 반드시 종료가 되는 반복문.

        public Chap19_Loop03_Foreach()
        {
            InitializeComponent();
        }

        private void btnstringForeach_Click(object sender, EventArgs e)
        {
            // 라벨에 적혀있는 문자열의 문자를 하나씩 추출한다.
            string sTitle = label1.Text; // 라벨의 Text를 변수에 담기.

            // 1. textbox 에 입력한 문자가 한글자 인지 확인.
            if(txtstringForeach.Text.Length > 1)
            {
                MessageBox.Show("한글자 이상은 처리할 수 없습니다.");
                return;
            }
            char a = Convert.ToChar(label1.Text.Remove(0, sTitle.Length - 1));
            char sValue = Convert.ToChar(txtstringForeach.Text); // 입력한 문자열 받는 변수.
            
            // 문자열에서 한글자씩 추출하여 변수에 담는다.
            foreach (char chValue in sTitle)
            {
                // 입력한 문자가 타이틀 문자열 중에 포함되어있는 문자인지 확인.
                // 만약에 있다면 "?? 문자열은 포함되어 있습니다." 메세지 표현하라.
                if (chValue == sValue)
                {
                    MessageBox.Show($"{Convert.ToString(chValue)} 문자열은 포함되어 있습니다.");
                    //return;
                }
                else if(a == chValue && chValue != sValue)
                {
                    MessageBox.Show($"{Convert.ToString(sValue)} 문자열은 포함되어있지 않습니다.");
                }
            }
            //MessageBox.Show($"{Convert.ToString(sValue)} 문자열은 포함되어있지 않습니다.");
        }
    }
}
