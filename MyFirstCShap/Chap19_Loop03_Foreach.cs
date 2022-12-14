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
            char sValue = Convert.ToChar(txtstringForeach.Text); // 입력한 문자열 받는 변수.
            bool bFlag = false;
            // 문자열에서 한글자씩 추출하여 변수에 담는다.
            foreach (char chValue in sTitle)
            {
                // 입력한 문자가 타이틀 문자열 중에 포함되어있는 문자인지 확인.
                // 만약에 있다면 "?? 문자열은 포함되어 있습니다." 메세지 표현하라.
                if (chValue == sValue)
                {
                    MessageBox.Show($"{Convert.ToString(chValue)} 문자열은 포함되어 있습니다.");
                    bFlag = true;
                    //return;
                }
            }
            if(!bFlag)
            {
                MessageBox.Show($"{Convert.ToString(sValue)} 문자열은 포함되어있지 않습니다.");
            }
        }

        private void btnArrayForeach_Click(object sender, EventArgs e)
        {
            // 배열의 내용을 추출하는 방법.

            // 1. 배열 생성.
            int[] iValues = new int[] { 11, 12, 13, 14 };

            int iCount = 0;
            foreach (int Elem in iValues)
            {
                MessageBox.Show($"{iCount} 주소에는 값 {Elem}가 있습니다.");
                ++iCount;
            }
        }

        private void btnObjForeach_Click(object sender, EventArgs e)
        {
            // 그룹박스에 포함되어있는 컨트롤을 하나씩 뽑아서 로직을 구현.
            // 도구상자에 사용되는 도구 클래스는 (Control, Component)라고 부른다.
            foreach(Control MyControl in grbTextBoxInit.Controls)
            {
                // is : 데이터 값의 비교가 아닌 클래스 속성의 참 거짓 여부를 판단.
                if(MyControl is TextBox)
                {
                    MyControl.Text = "안녕하세요";
                }
            }
        }
    }
}
