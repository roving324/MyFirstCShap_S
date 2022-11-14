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
    public partial class Chap07_StringSplit : Form
    {
        public Chap07_StringSplit()
        {
            InitializeComponent();
            lblTitle.Text = "ABCDEFG/HIJKLMN/OPQRSTU";
        }

        private void btnInterPolation_Click(object sender, EventArgs e)
        {
            // 문자열을 보간.
            // 보간 : 비거나 누락된 부분을 채우는 기능
            // 문자열 "" 안에 {} 로 표현될 변수를 등록.
            // {} 안에 들어가는 모든 데이터 타입은
            // 문자열로 형변환 (암시적) 되어 표현된다.

            string sValue; // 문자열 보간 데이터가 담길 변수

            // 문자열 데이터의 보간.      *전체(드래그) 주석 Ctrl + k +c
            // 문자열의 합으로 표현
            //sValue = "라벨의 타이틀은 " + lblTitle.Text + " 입니다.";
            //MessageBox.Show(sValue);

            // 문자열 보간법으로 표현
            //sValue = $"라벨의 타이틀은 {lblTitle.Text} 입니다.";
            //MessageBox.Show(sValue);

            int num = 2;
            sValue = $" 1 + 1 은 {num} 입니다. 그리고 2 + 2 는 {4} 입니다.";
            MessageBox.Show(sValue);
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            // 문자열, 배열 등의 길이(개수) 구하기.
            MessageBox.Show($" 타이틀 문자열의 개수는 {lblTitle.Text.Length}개 입니다.");

            // 마지막 Index 는 Lengh -1의 값을 가진다. ***
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            // Split 지정된 문자를 기준으로 문자열을 자르고
            // 자른 값을 반환한다.

            // 1. 문자열을 분할 할 대상 문자열을 변수에 담는다.
            string sSplitValue = txtSplit.Text;

            // 2. 지정한 문자를 기준으로 나눈 문자열을 Split 배열에 담는다.
            // 배열 : 같은 타입의 변수를 여러개 모아놓은 데이터 타입.
            string[] Arry_Split = lblTitle.Text.Split(sSplitValue);

            // 배열에 몇개의 방이 생성 되었는지 확인.
            MessageBox.Show(Arry_Split.Length.ToString());

            // 배열의 첫번째 주소에 있는 문자의 개수 확인
            MessageBox.Show(Arry_Split[0].Length.ToString());

            // 3. 배열에 담긴 문자를 표현
            MessageBox.Show(Arry_Split[0]);
            MessageBox.Show(Arry_Split[1]);
            MessageBox.Show(Arry_Split[2]);
            //MessageBox.Show(Arry_Split[3]);
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            // Substring : 사용자가 지정한 위치 및 개수만큼 문자를 잘라서 표현.

            // 1. 문자열 자르기 대상
            string sTitle = lblTitle.Text;

            // 2. 문자열을 자를 위치
            int iIndex = Convert.ToInt32(txtIndex.Text);

            // 3. 문자열을 자를 개수
            int iStringCount = Convert.ToInt32(txtCount.Text);

            string sValue; // 문자열을 잘라와서 담을 변수
            sValue = sTitle.Substring(iIndex, iStringCount);
            
            MessageBox.Show(sValue);
        }
    }
}
