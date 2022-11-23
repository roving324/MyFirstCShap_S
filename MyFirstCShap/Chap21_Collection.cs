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
    }
}
