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
    public partial class Chap09_Null : Form
    {
        /*
           - Null?
             . 데이터의 용량(메모리) 자체가 주어지지 않는 값.
             . 값이 존재 하지 않는다.
             . "" 아무것도 없는 값(데이터)가 존재한다.
             . ex) 모델하우스에서 건축되지 않은 아파트 호수를 계약환경을

           - 기본적으로 숫자형 변수에는 Null을 대입할 수 없다.
             . ?를 사용하여 Null을 임시로 대입할 수 있으나
               로직 구현시 오류가 날 수 있으니 주의
         */
        public Chap09_Null()
        {
            InitializeComponent();
        }

        private void btnHasValue_Click(object sender, EventArgs e)
        {
            // 숫자형 데이터 값이 Null 인지 판단하는 방법.

            // 1. 숫자형 데이터 타입에 Null을 허용하는 방법.
            // 데이터 타입 뒤에 ?를 삽입하여 임시적으로 Null을 허용
            // 할 수 있도록 변경가능.
            int? iValue = null;
            string? sValue = null;

            MessageBox.Show(Convert.ToString(iValue.HasValue)); // False

            iValue = 1;
            MessageBox.Show(Convert.ToString(iValue.HasValue)); // True

            // 문자형 데이터 타입 (sValue)는
            // 기본적으로 Null을 허용하는 데이터 타입이므로
            // HasValue 기능이 존재할 필요가 없다.
        }

        private void btnNullFlag_Click(object sender, EventArgs e)
        {
            // Null 병합 연산자 '??'
            // 데이터 타입의 유형이 Null 인지 판단하는 용법.

            int? iValue = null;

            // 1. iValue의 값이 Null인지 판단.

            // iValue의 값이 Null일 경우 0을 반환하여 표현.
            MessageBox.Show(Convert.ToString(iValue ?? 0));

            //iValue에 10이라는 수를 대입할 경우 10이 표현.
            iValue = 10;
            MessageBox.Show(Convert.ToString(iValue ?? 0));

            // 2. string 데이터타입에 Null 값 여부 판단.
            string sValue = null;
            MessageBox.Show(sValue ?? "입력한 값이 Null 입니다.");

            sValue = "안녕하세요";
            MessageBox.Show(sValue ?? "입력한 값이 Null 입니다.");
        }
    }
}
