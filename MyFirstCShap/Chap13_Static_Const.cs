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
    /*
     Static 한정자
        - 프로그램 전체에서 유기적으로 관리해야하는 값이 발생할 경우
          객체의 생성 없이 클래스 내의 필드값을 직접적으로 관리할 수 있음.
          클래스에 머물러 있는 필드나 메서드라는 의미에서 정적필드, 정적메서드
          라고도 불림.
        - 최초 초기화(최초로 값이 대입 또는 호출, 메서드가 실행될 때)
          메모리에 등록되어 프로그램이 종료될 때까지 메모리에 상주한다.
          불필요하게 사용할 경우 메모리 효율을 떨어뜨릴 수 있으므로 사용상 고려가 필요.

    Const 상수(변하지 않는 값)
       - 최초 값 대입 후 추가로 값을 대입 시 오류가 발생하여
         여러 개발자가 동시에 작업을 할 경우 또는 코딩의 길이가
         길어져서 변수에 대한 정의가 모호해 질 경우
         데이터가 변질 될 수 있는 오류를 방지 할 수 있다.

    */

    // 객체지향은 최소한의 오픈이다.(Private이 기본이 이유(캡슐화))
    public partial class Chap13_Static_Const : Form
    {
        public Chap13_Static_Const()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            // 단일 필드 값 호출 후 변경
            MessageBox.Show(static_Class.sValue);
            static_Class.sValue = "반갑습니다.";
        }

        private void btnNice_Click(object sender, EventArgs e)
        {
            MessageBox.Show(static_Class.sValue);
            static_Class.sValue = "화이팅";
        }

        private void btnFighting_Click(object sender, EventArgs e)
        {
            MessageBox.Show(static_Class.sValue);
        }

        private void btnStaticOrInstance_Click(object sender, EventArgs e)
        {
            // 복수 필드의 Static 형식 또는 Instance 형식.

            // 1. Static 형이 아닌 일반 필드(인스턴스 필드)
            //    클래스를 객체화하여 호출하되 로직 종료시 소멸된다.

            // 클래스를 객체화하여 인스턴스 필드에 "반갑습니다." 값 입력
            staticOrInstance_Class SOI_C = new staticOrInstance_Class();
            SOI_C.sInstanceValue = "반갑습니다.";
            //SOI_C.sStatic_Value = "";

            // 정적 필드에 바로 "반갑습니다." 값 입력
            staticOrInstance_Class.sStatic_Value = "반갑습니다.";
        }

        private void btnStaticOrInstance_Call_Click(object sender, EventArgs e)
        {
            //staticOrInstance_Class에 있는 필드 값을 표현
            // 인스턴스 필드 값 표현.
            staticOrInstance_Class COI_C = new staticOrInstance_Class();
            MessageBox.Show(COI_C.sInstanceValue);

            // 정적 필드 값 표현
            MessageBox.Show(staticOrInstance_Class.sStatic_Value);
        }

        private void btnConst_Click(object sender, EventArgs e)
        {
            // 상수 바뀌지 않는 값 Const

            // 1. Const_Class 객체 생성
            Const_Class Const_C = new Const_Class();

            // 2. 객체를 만들어 접근을 할 수 없다.
            //    . Const(상수)는 Static 형식을 가지고 있다.

            // 3. 상수에 데이터를 대입시 오류가 발생
            // Const_Class.sConst_Value = "값을 바꿔보자"; // 상수값은 바뀔 수 없다.

            // 4. 확인
            MessageBox.Show(Const_Class.sConst_Value);
        }
    }

    class static_Class
    {
        // 단일 필드만 Static으로 한정하는 클래스.
        public static string sValue = "안녕하세요";
    }
    class staticOrInstance_Class
    {
        public string sInstanceValue = "안녕하세요"; //인스턴스 필드.
        public static string sStatic_Value = "안녕하세요"; // 정적 필드.
    }

    class Const_Class
    {
        // 상수 생성.
        public const string sConst_Value = "상수값";
    }

    // 클래스 자체를 Static 클래스로 지정할 경우.
    // 클래스 내의 모든 멤버(필드,생성자,메서드)는 Static
    // 형식으로 선언 되어야 한다.

    static class Static_Class3 // 정적 필드
    {
        //public string sValue = ""; // 인스턴스 필드
        public static string sValue1 = "";
        public const string sValue2 = "";
    }
}
