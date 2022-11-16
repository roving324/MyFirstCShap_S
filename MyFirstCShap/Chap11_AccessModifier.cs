using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCShap
{
    // 접근 제한자를 사용하는 이유.
    // - 객체지향 프로그램이 지켜야할 내용 중 **캡슐화를 지키는 것이 목적.
    //   . Public 상태로 로직이 구현될 경우 클래스 객체의 사용자에 따라
    //     데이터의 변형을 일으키거나 정상적인 동작을 저해할 우려가 있고
    //     중요한 코드의 보안을 유지할 수 없으므로
    //     내부에서만 중요하게 처리되는 내용은 외부에 공개하지 않도록 함.
    
    partial class Chap11_AccessModifier
    {
        // 접근 제한자.
        // Public    : 모든 클래스에서 접근 할 수 있다.
        // private   : 해당 클래스 내에서만 접근 할 수 있다. 
        //             접근 제한자 부분에 기능을 설정하지 않았을 때는
        //             기본으로 Private로 설정되어 있다.

        // internal  : 동일한 NameSpace 에서만 접근 할 수 있다. 
        // Protected : 파생 클래스(partial) 에서 접근이 가능

        protected string sValue = "안녕하세요";
        public string sPublic = "public string";
        private string sPrivate = "private string";
    }

    // Partial Class (분할 클래스, 파생 클래스)
    // . 클래스는 동일한 NameSpace에서 같은 이름으로 작성할 수 없다.
    // . 여러명이 같은 클래스를 동시에 개발하거나
    //   단위 별로 코딩을 나우어 개발 해야할 경우
    //   같은 기능을 수행할 클래스를 임을 표현하는 기능(키워드).
    partial class Chap11_AccessModifier
    {
        public Chap11_AccessModifier()
        {
            sValue = "반갑습니다.";
            sPublic = "데이터 변형가능";
            sPrivate = "데이터 변형가능";
        }

    }

    // 클래스를 생성 할 경우 프로젝트에 cs 파일로 추가 하는 방법 이 있고.
    // 코드 내에 클래스를 생성 하는 방법이 있다. 
    // 여러 개발자가 하나의 응용프로그램을 개발 할 경우.
    // 공통적으로 관리하는 Class 는 프로젝트에 추가(cs 파일을 생성)하여 보여주는 방식이 좋다. 
    // 코딩 화면에서 개인적으로 사용할 클래스 의 경우
    // NameSpace 묶음단위 안에 별도로 생성 할 수 있다. 
    class NewClass
    {
        // 코드 내에 클래스를 별도로 생성하는경우.
        Chap11_AccessModifier CHAP11 = new Chap11_AccessModifier();
        
        public NewClass()
        {
            CHAP11.sPublic = "외부에서 데이터 변형가능";
        }
    }
}
