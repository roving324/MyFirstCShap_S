using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCShap
{
    public partial class Chap20_Array : Form
    {
        public Chap20_Array()
        {
            InitializeComponent();
        }

        private void btmArrayFunction_Click(object sender, EventArgs e)
        {
            // 배열
            // 같은 데이터 타입의 다중 데이터가 하나의 배열변수 이름으로 나열된 데이터 형식

            // 1. 배열을 초기화 하는 방법.
            int[] iValues1 = new int[5] { 10, 20, 30, 40, 50 }; // 데이터가 등록되는 방의 갯수를 지정.
            int[] iValues2 = new int[] { 10, 20, 30 }; // 등록되는 방의 갱수 미지정.
            int[] iValues3 = { 40, 10, 20, 42 };
            string[] sValues = "ABCD/EFG".Split('/');
            int[] iValues4 = new int[iValues1.Length];
            int[] iValues5 = new int[10];
            //int[] iValues6 = new int[];
            // * 배열을 선언할 때는 초기대입값이 주어지거나, 배열의 크기(방의 개수)가 반드시 명시 되어야한다.

            // 2. 배열에서 사용되는 주요 기능.

            // 2-1. 배열을 정렬한다.
            Array.Sort(iValues3);

            // 2-2. 특정 데이터의 index를 반환한다. 없을 경우 -1을 반환.
            int iResultIndex; // 배열 내에 데이터가 존재할 경우 주소값 담는 변수.
            iResultIndex = Array.IndexOf(iValues3, 20);

            // 2-3. 배열의 크기를 조절하는 기능.
            Array.Resize<int>(ref iValues3, 3);
            MessageBox.Show($"iValues3 배열의 개수는 : {iValues3.Length}입니다.");

            // 2-4. 배열을 초기화한다.
            // 배열에 등록되는 방의 갯수가 삭제되는 것이 아닌 각 주소값의 데이터만 초기화된다.
            Array.Clear(iValues3);

        }

        private void btnArrayCopy_Click(object sender, EventArgs e)
        {
            // 배열을 복사.
            int[] iValues1 = { 10, 20, 30, 40, 50 }; // 원본 배열.
            int[] iValues2 = iValues1;

            // int 데이터 타입은 값 형 복사 타입.
            int iValue = 10;
            int iValue2 = iValue;
            MessageBox.Show(Convert.ToString(iValue)); // 10
            iValue2 = 40;
            MessageBox.Show(Convert.ToString(iValue)); // 10

            // 참조형 복사 방식
            // 배열은 참조 형식의 데이터 타입.
            // 원본 배열이 연결되어있는 주소 값만 공유 (얕은 복사)
            MessageBox.Show(Convert.ToString(iValues1[0])); //10
            iValues2[0] = 40; // 배열은 참조형으로서 iValues1을 복사하는 것이 아닌 공유하는 형식이다.
            MessageBox.Show(Convert.ToString(iValues1[0])); // 40

            // 참조형 데이터 타입의 값으 그대로 복사하는 방식
            // 깊은 복사
            Array.Copy(iValues1, iValues2, iValues1.Length);
            int[] iValues3 = (int[])iValues1.Clone();
            iValues1[0] = 60;

        }

        private void btn2D_Click(object sender, EventArgs e)
        {
            // 2차원 배열의 표현과 예제.
            // 1. 배열의 생성.
            int[,] iValues = new int[2,4]; // [행의 수, 열의 수]
            iValues[0, 0] = 1;
            iValues[0, 1] = 2;
            iValues[0, 2] = 3;
            iValues[0, 3] = 4;
            iValues[1, 0] = 5;
            iValues[1, 1] = 6;
            iValues[1, 2] = 7;
            iValues[1, 3] = 8;

            // 2. 배열의 생성.
            int[,] iValues2 = new int[3, 4] { {1,2,3,4},{5,6,7,8},{9,10,11,12} };

            // 2차원 배열의 행의 수 구하는 기능.
            int iArrayRowCount = iValues2.GetLength(0);

            // 2차원 배열의 열의 수 구하는 기능.
            int iArratColumCount = iValues2.GetLength(1);
        }

        private void btn2DShow_Click(object sender, EventArgs e)
        {
            int[,] iValues = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            for (int i = 0; i < iValues.GetLength(0); i++)
            {
                for (int k = 0; k < iValues.GetLength(1); k++)
                {
                    txtShow.Text += $" {iValues[i, k]} ";
                }
                txtShow.Text += "\r\n";
            }
            int iCount = 0;
            foreach (int i in iValues)
            {
                txtShow.Text += $" {i} ";
                if (++iCount % iValues.GetLength(1) == 0)
                {
                    txtShow.Text += "\r\n";
                }
            }
        }
    }
}
