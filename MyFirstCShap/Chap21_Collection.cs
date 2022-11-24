using System;
using System.Collections;
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
    public partial class Chap21_Collection : Form
    {
        public Chap21_Collection()
        {
            InitializeComponent();
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            // Array List
            // 데이터 형식에 상관없이 다중 데이터를 관리할 수 있는 데이터 타입.
            // 데이터 형식에 구애없이 데이터가 누적되므로
            // 데이터를 확인할 때에는 반드시 데이터 형변환이 이루어져야한다.

            // 1. 별도의 데이터 공간을 지정하지 않아도 데이터를 등록할 수 있다.
            ArrayList arrList = new ArrayList();

            // 기본적인 데이터 등록 방법.
            for (int i = 0; i <= 10; i++)
            {
                arrList.Add(i); // 데이터를 등록. Add
            }

            // 2. 데이터타입에 상관없이 데이터를 등록할 수 있다.
            arrList.Add("안녕하세요");

            //arrList.Sort(); // 리스트에 있는 내용을 정렬
            // * 데이터 타입이 혼용되어 있을 경우 정렬을 할 수 없다.

            arrList.Remove(2); // 2번 인덱스에 있는 데이터와 메모리 삭제 후 다시 정렬.

            arrList.Insert(2, 40); // 2번 인덱스에 40 데이터 추가.

            // ArrayList에 기존 컬렉션의 데이터를 추가하는 방법.
            int[] iValues = { 1, 2, 3, 4 };
            ArrayList List2 = new ArrayList(iValues);
            ArrayList List3 = new ArrayList(new int[] { 1, 2, 3 });
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            // Queue
            // 선입 선출 방식의 자료 구조
            // 데이터나 작업을 차례대로 입력된 순서에 따라 하나씩 처리.

            // Queue의 선언
            Queue<int> Que = new Queue<int>();

            // Queue에 데이터 등록
            // 대입하는 방식으로 등록하는 것이 아닌 데이터 등록 메서드가 별도로 등록

            Que.Enqueue(10);
            Que.Enqueue(20);
            Que.Enqueue(30);
            Que.Enqueue(40);

            // Queue에 데이터 출력 방식.
            // 중간 값을 뽑아서 보여줄수는 없고 처음부터 보여줄 수 있다.
            while(Que.Count > 0)
            {
                MessageBox.Show(Convert.ToString(Que.Dequeue()));
            }
            MessageBox.Show($"Que 에 남은 데이터 수는 {Que.Count}개 입니다.");

            // Queue
            // 배열(자료형 구조) 타입을 이용하여 데이터 등록.
            // 데이터를 사용하면 사라진다.

            // 1. 배열로 담기
            int[] iValues = {1,2,3,4};
            Queue Que2 = new Queue(iValues);
            Queue Que3 = new Queue(new int[] {1,2,3,4});

            // 2. ArrayList로 담기.
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Insert(2, 30);

            // * Dequeue 무조건 순차적으로 뽑아낸다.
            Queue Que4 = new Queue(list);
            MessageBox.Show("Que4 의 첫번째 데이터 : " + Convert.ToString(Que4.Dequeue())); // 1
            MessageBox.Show("Que4 의 두번째 데이터 : " + Convert.ToString(Que4.Dequeue())); // 2
            MessageBox.Show("Que4 의 세번째 데이터 : " + Convert.ToString(Que4.Dequeue())); // 30

            // 데이터를 순차적으로 담아서 처리(선입선출) 후 메모리에서 데이터를 삭제하므로
            // 메모리 관리에 용이한 자료형 구조가 이나.
            // 데이터가 휘발성으로 삭제 되므로 필요한 곳에 따라 잘 사용할 것.


        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            // Stack
            // 선입후출 (후입선출) 방식.
            // 데이터나 작업을 차례대로 입력된 순서에 따라 하나씩 처리.
            // Queue와 동일하게 데이터가 휘발성이다.

            // Stack 과 Queue 는
            // 데이터가 등록되고 호출 시 메모리에서 삭제 되므로
            // 메모리 관리에 용이한 자료형 구조

            // Stack의 선언
            Stack<int> Stack = new Stack<int>();

            // Stack에 데이터 등록 방법.
            Stack.Push(40);
            Stack.Push(10); 
            Stack.Push(20);
            Stack.Push(30);

            // Stack 데이터 추출.
            while(Stack.Count > 0)
            {
                MessageBox.Show(Convert.ToString(Stack.Pop()));
            }

            // 그외의 데이터 등록 방법 (컬렉션 자료형 구조)
            // 1. 배열
            Stack Stack2 = new Stack(new int[] {1,2});
            
            ArrayList list = new ArrayList();
            list.Add(20);
            list.Add(30);
            list.Add(40);

            Stack Stack3 = new Stack(list);
            MessageBox.Show(Convert.ToString(Stack3.Pop())); // 40
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            // Dictionary
            // 데이터가 담기는 주소를 Key로 설정하여 데이터를 등록하는 자료형 구조.

            // 1. Dictionary 의 생성.
            Dictionary<string, int> MyDic = new Dictionary<string, int>();

            // 2. Dic 데이터 등록
            MyDic.Add("십", 10);
            MyDic.Add("이십", 20);
            MyDic.Add("삼십", 30);
            MyDic["사십"] = 40;

            // 3. Dic 데이터 확인
            MessageBox.Show(Convert.ToString(MyDic["사십"]));

            // 4. Dic의 복사.
            // 참조를 전달하는 방식으로 데이터를 공유
            Dictionary<string, int> MyDic2 = MyDic;
            MyDic2["십"] = 100;
            MessageBox.Show($"MyDic 의 \"십\" 의 데이터는 : { MyDic["십"]} 입니다."); // 100 => Dic은 참조형데이터이다.

            // 값을 그대로 복사.
            Dictionary<string, int> MyDic3 = new Dictionary<string, int>(MyDic);
            MyDic3["이십"] = 200;
            MessageBox.Show($"MyDic 의 \"이십\" 의 데이터는 : {MyDic["이십"]} 입니다."); // 20

            // 5. Key의 사용여부 확인
            if (MyDic.ContainsKey("사십"))
            {
                MessageBox.Show("key 로 사용되고 있습니다.");
            }
            else
            {
                MessageBox.Show("Key 로 사용되고 있지 않습니다.");
            }

            // 6. Value 의 사용 유무 확인.
            if (MyDic.ContainsValue(10))
            {
                MessageBox.Show("값이 등록되어 있습니다.");
            }
            else
            {
                MessageBox.Show("값이 등록되어 있지 않습니다.");

            }

            // 7. Key 로 데이터 삭제.
            MyDic.Remove("이십");
            if (!MyDic.ContainsKey("이십"))
            {
                MessageBox.Show("이십은 포함되어 있지 않습니다.");
            }
            else
            {
                MessageBox.Show("이십은 포함되어 있습니다.");
            }
        }

        private void btnHashTable_Click(object sender, EventArgs e)
        {
            // HashTable
            // Dictionary 와 유사한 기능을 가지지만.
            // Key 와 Value 의 데이터 유형을 따로 정해주지 않아도 된다. (object 형식)
            // Value 의 내용이 데이터 타입이 지정되지 않으므로
            // 호출 시에는 반드시 형 변환 과정이 필요하다.

            // 1. HashTable 의 생성.
            Hashtable HT = new Hashtable();
            HT[1] = "ONE";
            HT[2] = "TWO";
            HT["삼"] = 3;
            HT[1.23] = 222;
            HT[true] = 333;

            // 2. HashTable 의 데이터 호출. (표현)
            MessageBox.Show(Convert.ToString(HT[1]));
            MessageBox.Show(Convert.ToString(HT["삼"]));
            MessageBox.Show(Convert.ToString(HT["십"]));

            // HashTable 에 데이터 등록 방법 (초기화)
            // 3-1. 딕셔너리 초기자로 최화 방식.
            Hashtable HT2 = new Hashtable()
            {
                ["하나"] = 1,
                ["둘"] = 2,
                [2] = "TWO",
                [1.3] = 1.3
            };

            // 3-2. 컬렉션 초기자로 초기화 하는 방식.
            Hashtable HT3 = new Hashtable()
            {
                {"하나", 1 },
                {"둘", 2 },
                {1.3, 1.7 }
            };

            // 4. HashTable 의 복사.
            // 4-1 값 형식으로 복사
            Hashtable HT4 = new Hashtable(HT);
            HT4["삼"] = 100;
            MessageBox.Show(Convert.ToString(HT["삼"])); // 3

            // 4-2 참조 형식으로 복사.
            Hashtable HT5 = HT;
            HT5["삼"] = 100;
            MessageBox.Show(Convert.ToString(HT["삼"])); // 100

            // 5. 키와 값 추가.
            HT.Add("육", 102);

            // 6. 키와 값 삭제
            HT.Remove("육");

            // 7. 키의 존재 유무.
            MessageBox.Show(Convert.ToString(HT.ContainsKey("육")));

            // 8. 값의 존재 유무.
            MessageBox.Show(Convert.ToString(HT.ContainsValue(3)));

            // 9. 데이터의 삭제
            HT.Clear();

            // Array, ArrayList 와 Dictionary , Hash 테이브르이 장단점.

            // 주소값으로 데이터를 찾아가는 방식 : Array, ArrayList
            //  . 검색, 수정, 삭제의 기능이 복잡한 로직으로 처리되어 수행 속도가 다소 느리다.
            //  . 메모리 공간을 효율적으로 사용할 수 있다.

            // 키 값을 바탕으로 주소를 찾아가서 데이터를 찾는 방식 : Dictoinary, HashTable
            //  . 지정한 키를 통해 값을 찾아내어 수정, 삭제, 조회의 기능을 빠르게 수행할 수 있다.
            //  . 불필요한 메모리사 상주 해있을 가능성이 큰 자료형 구조.
        }
    }
}
