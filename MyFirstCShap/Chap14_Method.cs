using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MyFirstCShap
{
    public partial class Chap14_Method : Form
    {
        // 메서드 (함수) 와 리턴(반환하는 결과) 값
        // 데이터를 주는 값 : 인수, 아규먼트라고 부른다.
        // 데이터를 받는 값 : 인자, 매개변수, 파라매터라고 부른다.
        // 아!수주 받자매 파
        // Return : 메서드에서 처리한 어떠한 결과를 메서드를 호출한 부분으로 넘겨주는 기능.
        //          메서드를 종료하라는 의미가 아니고
        //          여기까지만 하고 반환값을 호출한 곳으로 돌려준다.
        // ref, Out, In : 매개변수, 한전자.

        public Chap14_Method()
        {
            InitializeComponent();
        }

        #region < 기본 메서드 호출 >

        private void btnMethodCall_Click(object sender, EventArgs e)
        {
            ShowMessage("sada");
        }
        private void ShowMessage(string asd)
        {
            MessageBox.Show(asd);
            txtTitle.Text = "안녕하세요";
            lblTitle.Text = "안녕하세요";
        }
        #endregion

        #region < 인수와 인자 값을 통한 함수의 호출 >

        private void btnArg_Par_Click(object sender, EventArgs e)
        {
            // 인수 값을 전달하고 전달된 값을 인자로 처리하는 메서드 유형
            ShowMessage2("오늘도 화이팅"); //인수

            string sValue = "반갑습니다.";

            // sValue라는 변수의 값을 인수값으로 던져준다.
            ShowMessage2(sValue); // ShowMessage2 = sValue;
        }

        void ShowMessage2(string sMessage) //인자
        {
            MessageBox.Show(sMessage);
            txtTitle.Text = sMessage;
            lblTitle.Text = sMessage;
        }

        #endregion

        #region < 아무 값을 반환하지 않는 리턴 >

        private void btnVoidReturn_Click(object sender, EventArgs e)
        {
            ShowMessage3("버튼 3번째 입니다");
        }

        private void ShowMessage3(string sMessage)
        {
            MessageBox.Show(sMessage);
            txtTitle.Text = sMessage;
            return; // 함수(메서드)의 종료 구문처럼 보이지만 반환할 값이 없는 상태로
                    // 호출한 곳으로 결과값 보내주는 구문.
                    //  - 아무런 결과값을 가지지 않고 호출한 곳으로 돌아가라
            lblTitle.Text = sMessage;
        }
        #endregion

        #region < String 값을 반환하는 리턴 >

        private void btnStringReturn_Click(object sender, EventArgs e)
        {
            string sResult = ShowMessage4("안녕하세요");
            MessageBox.Show(sResult);
        }

        private string ShowMessage4(string sMessage)
        {
            MessageBox.Show(sMessage);
            return "성공";
        }

        #endregion

        #region < int 값을 반환하는 리턴 >
        private void btnIntReturn_Click(object sender, EventArgs e)
        {
            int iValue1 = 15;
            int iValue2 = 25;

            int iResult = IntSum(iValue2, iValue1);
            MessageBox.Show(Convert.ToString(iResult));
        }

        int IntSum(int iValue1, int iValue2)
        {
            // iValue = 25;
            // ******************************************
            // 인수와 인자의 변수 이름이 같다고 하더라도
            // 주고 받는 위치에 따라 값이 대입 된다.
            return iValue1 + iValue2;
        }

        #endregion

        #region < 인자가 기본값을 가지는 함수의 결과를 반환하는 리턴 메서드 (선택적 인수) >

        private void btnDefaultReturn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(IntSum2(10, 40)));
        }

        private int IntSum2(int iValue1, int iValue2, int iValue3 = 20)
        {
            // 인자 int iValue2에 20을 기본값으로 대입한 메서드인 경우
            // IntSum2를 호출하는 부분에는 iValue2에 들어갈 인수값을 등록하지 않아도된다.
            return iValue1 + iValue2;

            // 인자값에 기본값을 설정할 경우
            // 중간에 있는 인자에만 기본값을 설정할 수 없다.
            // 마지막 인자는 반드시 기본값 설정하는 인자여야만 한다.
        }

        #endregion

        #region < 클래스를 인수로 전달하는 경우, 간단한 게임>

        private void btnCatch1_Click(object sender, EventArgs e)
        {
            CatchGameMethod(btnCatch1, btnCatch2);
        }

        private void btnCatch2_Click(object sender, EventArgs e)
        {
            CatchGameMethod(btnCatch2, btnCatch1);
        }

        private void CatchGameMethod(Button Btn_Catch1, Button Btn_Catch2)
        {
            Btn_Catch1.Text = "";
            Btn_Catch2.Text = "나 잡아 봐라~~";
        }
        #endregion

        #region < 인수를 배열로 전달하는 경우 >
        private void btnArrayArg_Click(object sender, EventArgs e)
        {
            string[] ArrayString = { "안녕하세요", "반갑습니다.", "C#프로그래밍" };
            ShowMessage6(ArrayString);
        }

        private void ShowMessage6(string[] sArrayString)
        {
            MessageBox.Show(sArrayString[0]);
            txtTitle.Text = sArrayString[1];
            lblTitle.Text = sArrayString[2];
        }
        #endregion

        #region < 배열을 리턴하는 경우 >
        private void btnArrayReturn_Click(object sender, EventArgs e)
        {
            // 1. 배열 인자 생성.
            int[] iArray = { 10, 20 };

            // 2. 메소드 호출.
            iArray = IntSum3(iArray);

            MessageBox.Show($"[0] : {iArray[0]} , [1] : {iArray[1]}");
        }

        private int[] IntSum3(int[] iArray)
        {
            // 배열 인수를 일정한 값과 합하는 메서드
            int[] iSumInt = { 5, 10 };
            iSumInt[0] += iArray[0];
            iSumInt[1] += iArray[1];

            return iSumInt;
        }
        #endregion

        #region < 다른 클래스의 함수 호출 >
        private void btnClassMCall_Click(object sender, EventArgs e)
        {
            // New_Class를 객체화(인스턴스)
            New_Class newClass = new New_Class();
            MessageBox.Show(Convert.ToString(newClass.IntSum(40)));

            MessageBox.Show(Convert.ToString(New_Class.IntSum2(10, 20)));
        }
        #endregion

        #region < Ref 인자 반환(값 참조), Read/Write >
        private void btnRef_Click(object sender, EventArgs e)
        {
            // Ref
            // ref 인수값을 참조 형식으로 변형시켜 ref인자와 같은 데이터 주소(값)을
            // 바라볼 수 있도록 만들어주는 키워드
            // Ref 키워드의 인수를 사용하기 위해서는 반드시 값이 할당 되어있는 상태여야한다.

            int iA_Value = 13;
            // int iA_ValueRef: Ref로 사용할 인수는 반드시 초기화(데이터 타입)이 되어있어야한다.
            int iA_ValueRef = 20;

            MessageBox.Show($"인수 iA_Value 값은 : {iA_Value}");
            MessageBox.Show($"Ref 인수 iA_ValueRef 값은 : {iA_ValueRef}");

            RefMethod(iA_Value, ref iA_ValueRef);

            MessageBox.Show($"iA_Value 값은 : {iA_Value}");
            MessageBox.Show($"iA_ValueRef 값은 : {iA_ValueRef}");
        }

        private void RefMethod(int iP_Value, ref int iP_ValueRef)
        {
            MessageBox.Show($"Ref 인자 ip_ValueRef 의 값은 : {iP_ValueRef}");
            iP_ValueRef = iP_Value;
            iP_Value = 10;
            MessageBox.Show($"Ref 인자 ip_ValueRef 의 값은 : {iP_ValueRef}");
        }

        #endregion

        #region < Out 인자반환, 값을 할당하지 않은 Out 인자, Write >
        private void btnOut_Click(object sender, EventArgs e)
        {
            // Out 키워드는 인수값을 초기화 할 필요가 없다.
            // 인자변수는 메서드 내에서 반드시 초기화(데이터 값이 대입) 되어야 한다.
            int iA_Value = 1;
            int iA_ValueOut = 10;

            OutMethod(iA_Value, out iA_ValueOut);

            MessageBox.Show($"iA_Value 의 값은 : {iA_Value}");
            MessageBox.Show($"iA_ValueOut 의 값은 : {iA_ValueOut}");
        }

        private void OutMethod(int iP_Value, out int iP_ValueOut)
        {
            // 메서드 내에서 인자 iP_ValueOut에 값을 할당하지 않으면 오류가 발생한다.
            iP_ValueOut = iP_Value;
            iP_Value = 30;
            MessageBox.Show($"Out 인자 iP_ValueOut 의 값은 : {iP_ValueOut}");
        }

        #endregion

        #region < IN 형식의 인자 설정, ReadOnly >
        private void btnIn_Click(object sender, EventArgs e)
        {
            // IN 인자 타입
            // 읽기 전용 속성으로 변경, 수정을 할 수 없다.
            int iValue = 10;
            InMethod("인수 문자", in iValue);
        }

        private void InMethod(string sValue, in int iValue)
        {
            MessageBox.Show(Convert.ToString(iValue));

            // iValue 는 IN 타입이므로 수정 또는 변경을 할 수 없다.
            // iValue = 10;
        }

        #endregion

        #region < 메서드 OverLoding>
        private void btnOverLoding_Click(object sender, EventArgs e)
        {
            // OverLoding
            // 예를 들어 인자를 메세지 박스로 표현하는
            // 일을 해야하는 메서드가 있다고 할 때
            // 같은 메소드 이름으로 인자 데이터 변수
            // 및 개수를 다르게 하여 여러 상황에
            // 맞게 사용할 수 있게 만드는 기능.

            ShowMessageOL1("안녕하세요", "반갑습니다.");
            
            // 정수형으로 인수 인자 값을 처리하는 메서드를 만들기 위해서는
            // 메서드 이름이 다른 기능을 따로 구현해야한다.
            // 즉. 반환하는 결과는 같지만 상황에(인수, 인자값의 변화) 따라서
            // 여러가지 이름의 메서드를 만들어야한다.
            ShowMessageInt(10, 20);

            ShowMessageOL1(10, 20);
        }

        private void ShowMessageOL1(string sValue1, string sValue2)
        {
            MessageBox.Show(sValue1, sValue2);
        }

        private void ShowMessageInt(int iValue1, int iValue2)
        {
            MessageBox.Show(Convert.ToString(iValue1) + Convert.ToString(iValue2));
        }

        private void ShowMessageOL1(int iValue1, int iValue2)
        {
            MessageBox.Show($"{iValue1} + {iValue2}");
        }

        #endregion

        #region < Out 참조전달 방식을 이용한 TryParse 메소드 만들어보기 >
        private void btnTryParse_Click(object sender, EventArgs e)
        {
            string sValue = "안녕하세요"; //숫자로 변경 될 문자
            int iResult; // 변경된 숫자가 담기는 정수 변수
            bool bFlag;

            // TryParse의 기능 복기.
            //bFlag = int.TryParse(sValue, out iResult);
            //MessageBox.Show($"결과는 {bFlag}이고 값은 {iResult}입니다.");

            // TryParse 기능 구현 실습
            bFlag  = int_.TryParse(sValue, out iResult);
            MessageBox.Show($"결과는 {bFlag}이고 값은 {iResult}입니다.");
        }
        #endregion

        #region < 일반화 메소드 Generic Method >
        private void btnGenericMethod_Click(object sender, EventArgs e)
        {
            // 같은 기능을 하는 메서드가 인자의 데이터 타입만 바뀌는 경우.
            // 인자의 데이터 타입이 같은 메서드를 데이터 타입에 따라 오버로딩.
            // 할 경우에는
            // 메서드 일반화를 통하여 여러 데이터 타입의 인자를 처리하는
            // 메서드를 하나만 만들어서 관리 할 수 있다.

            StringSum("안녕하세요", "반갑습니다."); // 안녕하세여_반갑습니다.

            G_StringSum<string>("안녕하세요", "반갑습니다.");
            G_StringSum<int>(100, 200);
        }

        void StringSum(string sValue, string sValue2)
        {
            MessageBox.Show($"{sValue}_{sValue2}");
        }

        void StringSum(int iValue, int iValue2)
        {
            MessageBox.Show($"{iValue}_{iValue2}");
        }

        // 인수 인자 개수도 같은데 데이터 타입만 바뀔경우는
        // 메서드를 하나만 만들어서 구현 할 수 있다.
        // Generic Method
        void G_StringSum<T>(T gValue, T gValue2)
        {
            MessageBox.Show($"{gValue}_{gValue2}");
        }
        #endregion
    }

    class New_Class
    {
        // 수를 더하는 New_Class Method
        public int IntSum(int iValue1, int iValue2 = 20)
        { 
            return iValue1 + iValue2;
        }
        
        // 모든 클래스에서 사용할 수 있는
        // 메모리에 상주(정적) 머물러 있는
        // 정수 결과 반환 타입의
        // IntSum2라는 메서드를 만들고
        // 인자 값으로는 int 형 데이터타입을 두개 받는 메서드
        public static int IntSum2(int iValue1, int iValue2)
        {
            return iValue1 + iValue2;
        }
    }

    class int_
    {
        public static bool TryParse(string sValue, out int iResult)
        {
            try
            {
                iResult = int.Parse(sValue);
                return true;
            }
            catch
            {
                iResult = 0;
                return false;
            }
        }
    }
}
