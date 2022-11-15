using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCShap
{
    internal partial class Chap11_AccessModifier
    {
        // 접근 제한자.
        // Public    : 모든 클래스에서 접근 할 수 있다.
        // private   : 해당 클래스 내에서만 접근 할 수 있다. 

        // internal  : 동일한 NameSpace 에서만 접근 할 수 있다. 
        // Protected : 파생 클래스(partial) 에서 접근이 가능

        protected string sValue = "안녕하세요";
    }

    partial class Chap11_AccessModifier
    {
        public Chap11_AccessModifier()
        {
            sValue = "반갑습니다.";
        }

    }



    // 클래스를 생성 할 경우 프로젝트에 cs 파일로 추가 하는 방법 이 있고.
    // 코드 내에 클래스를 생성 하는 방법이 있다. 
    // 여러 개발자가 하나의 응용프로그램을 개발 할 경우.
    // 공통적으로 관리하는 Class 는 프로젝트에 추가(cs 파일을 생성)하여 보여주는 방식이 좋다. 
    // 코딩 화면에서 개인적으로 사용할 클래스 의 경우
    // NameSpace 묶음단위 안에 별도로 생성 할 수 있다. 
    internal class NewClass
    {
        // 코드 내에 클래스를 별도로 생성하는경우.
    }


}
