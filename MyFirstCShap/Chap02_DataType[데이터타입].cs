using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// internal : 동일한 프로젝트 내에서만 호출이 가능한 클래스
namespace MyFirstCShap
{
    internal class Chap02_DataType
    {
        // 정수형 데이터 타입과 변수
        int ia = 11; // ia 라는 변수를 int 형으로 생성
        int ib = 10; // ib 라는 int 변수에 12를 대입
        //int ic = 1.0;
        //int id = "11";
        //int ie = int.MaxValue + 1;

        // 실수형 데이터 타입과 변수
        double da = 0.1;
        double dd = 1;
        //double dc = "11";

        // 문자형 데이터 타입과 변수
        string sa;
        string sb = "";
        string? sc = null;
        string sd = "반갑습니다.";
        string se = "안녕하세요.";
        string sf = "화이팅";

        // 논리형 데이터 타입과 변수
        bool ba = true;
        bool bb = !true; //false
        bool bc = false;
        bool bd = !false; //true

        // 코딩 이후 프로그램을 샐행 하는 도중에 에러 (런타임에러)
        // 코딩을 할 때 컴파일을 통하여 
        // 에러를 먼저 검출하고 실행 (컴파일 타입 에러)

        // 그 외의 데이터 타입
        char chA = 'A'; // 문자 하나. 빈 문자는 대입할 수 없다.
        uint uiA = 1; // 양수의 정수만 다루는 데이터 형식.
        string[] saA = new string[10]; // 문자열 배열.

        object oValue = "1";
        private void objTest()
        {
            oValue= "1";
            oValue= "1.0";
            oValue = false;

            // 실수 또는 문자 등 프로그래밍 중 대입되어
            // 사용되는 데이터 구조가 바뀌어 오류가 발생 할 수
            // 있으므로 Object 의 직접적인 사용은 금한다.
        }

    }
}
