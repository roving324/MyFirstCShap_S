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
    // 1. 프로퍼티
    // 클래스 내부 변수(필드멤버)의 값을 읽거나 쓸때 사용하는 방법.
    // Public 으로 선언한 필드 멤버 일 경우 데이터의 변질을 야기 할 수 있으므로
    // 사용하는 기능.

    // 캡슐화
    // 정보 은닉을 위해 클래스에서 선언된 변수가 외부에서 접근을 할 수 없도록
    // Private 형식으로 선언하여 변질을 막는 객체지향 프로그래밍 언어에서
    // 지향하는 중요한 방식.

    public partial class Chap26_Property : Form
    {
        // 6. BookStore 클래스 객체 선언
        BookStore B_S = new BookStore();
        public Chap26_Property()
        {
            InitializeComponent();
        }

        private void btnBookIn_Click(object sender, EventArgs e)
        {
            // 서적 입고
            // 7. 서점에 책이 입고 되는 내역 로직 생성.
            int iINBookCount = Convert.ToInt32(txtBookCount.Text); // 책의 입고 수량
            B_S.BookCount += iINBookCount; // BookStore 클래스의 BookCount 필드멤버에 입고수량 등록
            txtBookCount.Text = string.Empty; // 입고 수량 텍스트 박스 초기화
            lblBookStock.Text = B_S.BookCount.ToString(); // 재고 수량 증가 내용 표시
            MessageBox.Show($"{iINBookCount} 권의 책이 입고 되었습니다.");
        }

        private void btnBookSale_Click(object sender, EventArgs e)
        {
            // 8. 서적 판매 현황 및 데이터 표현
            //--B_S.BookCount;
            //lblBookStock.Text = B_S.BookCount.ToString();

            // 9. 책의 재고수량은 - 가 될 수 없다.
            // 내가 만든 코딩에는 iBookCount 가 - 가 될수 없나는 것을 인지하고 코딩하지만
            // 다른 사람이 iBookCount에 접근(BookCount 대리자를 통해서) 할 때에는
            // - 재고로 만들 가능성이 있다. 즉 데이터 변질의 우려.
            //--B_S.BookCount;
            //if (B_S.BookCount < 0)
            //{
            //    B_S.BookCount = 0;
            //    MessageBox.Show("서적의 수량은 0 이 될 수 없습니다.");
            //}
            //lblBookStock.Text = B_S.BookCount.ToString();

            // 11. - 재고로 변할 수 없는 성격의 iBookCount 대리자 BookCount2 으로 처리.
            --B_S.BookCount2;
            lblBookStock.Text = Convert.ToString(B_S.BookCount);
        }
    }

    // 2. 서점 이라는 클래스 생성.
    class BookStore
    {
        private int iBookCount; // 3. 외부에서 접근하지 못하도록 선언한 책 재고 변수
        public int BookCount   // 4. 외부에서 접근 가능한 재고 변수.
        {
            get
            {
                // iBookCount 의 내용을 호출할 때 return
                return iBookCount;
            }
            set
            {
                // iBookCount에 어떠한 데이터를 등록 할 때
                iBookCount = value; // Value : 외부에서 BookCount 에 값을 대입한 값.
            }
        }
        // 5. 정보 은닉성을 유지하기 위해 iBookCount 를 Private 형식으로 선언
        // 하였지만. Get, Set 기능을 보니 Public 기능과 별 차이 없어 보인다.

        // 10.
        // 데이터의 변질을 막기위한 지역 변수 iBookCount 의 대리자 BookCount2 프로퍼티 생성.
        public int BookCount2
        {
            get
            {
                return iBookCount;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("카운트는 0 이하가 될수 없습니다.");
                }
                else if (value == 0)
                {
                    MessageBox.Show("서적이 매진 되었습니다.");
                    iBookCount = value;
                }
                else
                {
                    iBookCount = value; // - 가 아니고 0 이 아닐 때는 대입
                }
            }
        }

        // 12. Property 의 간략한 표현
        // Public 변수로 지정 하는 것과 퍼퍼먼스와 차이가 거의 없다.
        public int BookCount3
        {
            get; set;
        }

        //증감연산자 메소드 문자자르기나누기 클래스2문제 배열문제 분기문 ref와out Tryparse string변수 Que Dictionarry
    }
}
