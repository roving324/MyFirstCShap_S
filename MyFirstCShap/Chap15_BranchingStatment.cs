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
    public partial class Chap15_BranchingStatment : Form
    {
        // 분기문
        // 프로그램 흐름의 조건에 따라 여러갈래로 나누는 흐름제어.
        // 비교연산자로는 ==, !=, <=, >=, <, >, &&, ||

        public Chap15_BranchingStatment()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            // 텍스트박스에 입력한 값이 없을 경우;
            // "아무 값도 없습니다." 메세지 표현
            // 입력 값이 있을 경우 해당 값을 메세지로 표현

            // 1. 텍스트 박스에 입력한 값 변수에 대입.
            string sTxtValue = txtInput.Text;

            // 기본적인 분기문 원형.
            if (sTxtValue == "")
            {
                MessageBox.Show("아무 값도 없습니다.");
            }
            else
            {
                MessageBox.Show(sTxtValue);
            }
        }

        private void btnInIF_Click(object sender, EventArgs e)
        {
            /* 만약에 입력한 값이 1일 때는 "분기문 1 실행" 메세지
               2 일때는 "분기문 2 실행" 메세지
               3 일때는 "분기문 3 실행" 메세지
               값이 없을경우에는 "아무값도 없습니다" 메세지
               1,2,3 이 모두 아닐 경우는 "적절한 분기문이 없습니다." 메세지
            */

            string sTxtValue = txtInput.Text;
            // 분기문 안에 사용되는 분기문
            if (sTxtValue == "")
            {
                MessageBox.Show("아무 값도 없습니다.");
            }
            else
            {
                if (sTxtValue == "1")
                {
                    MessageBox.Show("분기문 1 실행");
                }
                if (sTxtValue == "2")
                {
                    MessageBox.Show("분기문 2 실행");
                }
                if (sTxtValue == "3")
                {
                    MessageBox.Show("분기문 3 실행");
                }
                else
                {
                    MessageBox.Show("적절한 분기문이 없습니다.");
                }

                // 마지막의 else는 3번 분기문의 예외일 경우 결과로직.
                // 1 을 입력했을 샹우
                // 1번 분기문 입니다. 라는 메세지를 표현하는 IF문 적용
                // 3번이 아니기 때문에 Else 구문 적용
            }
        }

        private void btnElseIF_Click(object sender, EventArgs e)
        {
            // else if
            // if 문과 다음 if 문을 하나의 흐름으로 만들어준다.
            string sTxtValue = txtInput.Text;

            if (sTxtValue == "")
            {
                MessageBox.Show("아무 값도 없습니다.");
            }
            else if (sTxtValue == "1")
            {
                MessageBox.Show("1번 분기문 실행");
            }
            else if (sTxtValue == "2")
            {
                MessageBox.Show("2번 분기문 실행");
            }
            else if (sTxtValue == "3")
            {
                MessageBox.Show("3번 분기문 실행");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }
        }

        private void btnAndIF_Click(object sender, EventArgs e)
        {
            // AND IF 문 ( && 로 표기하며 '그리고'의 역할 )
            string sTxtValue = txtInput.Text;

            if (sTxtValue == "1" && sTxtValue == "2" && sTxtValue == "3")
            {
                MessageBox.Show($"{sTxtValue} 번 분기문 실행");
            }
            else if (sTxtValue == "")
            {
                MessageBox.Show("아무것도 없습니다.");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }
            // && 연산자는 왼쪽과 오른쪽에 모두 참 일 경우에만 True로 간주한다.
        }

        private void btnOrIF_Click(object sender, EventArgs e)
        {
            // Or If 문
            string sTxtValue = txtInput.Text;
            if(sTxtValue == "1" || sTxtValue == "2" || sTxtValue == "2")
            {
                MessageBox.Show($"{sTxtValue} 번 분기문 실행");
            }
            else if (sTxtValue == "")
            {
                MessageBox.Show("아무 값도 없습니다.");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }

            // || (세로줄, 버티컬바) 연산자는 왼쪽과 오른쪽이 어느 하나라도 참일 경우 True
        }

        private void btnBoolIf_Click(object sender, EventArgs e)
        {
            // Bool 데이터 변수에 데이터가 담긴 내용으로 비교하는 로직.
            string sTxtValue = txtInput.Text;
            bool bFlag = false;

            // 첫번째 분기 흐름
            if (sTxtValue == "1" || sTxtValue == "2" || sTxtValue == "3")
            {
                bFlag = true;
            }
            else if(sTxtValue == "")
            {
                MessageBox.Show("아무 값도 없습니다.");
                //return; // 방법1
            }
            else  // 방법2
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }

            // 두번째 분기 흐름.
            if (bFlag == true)
            {
                MessageBox.Show($"{sTxtValue} 번 분기문 실행");
            }
            //else if(sTxtValue != "") // 방법3
            //{
            //    MessageBox.Show("적절한 분기문이 없습니다.");
            //}
        }

        private void btnP_MFlag_Click(object sender, EventArgs e)
        {
            int iTxtValue = 0;
            bool bFlag = false;
            bFlag = int_.TryParse(txtInput.Text, out iTxtValue);
            if (!bFlag)
            {
                MessageBox.Show("음수 양수 판단을 할 수 없습니다.");
                return;
            }

            // 음수 양수 로직 처리
            if(iTxtValue < 0)
            {
                MessageBox.Show("음수 입니다.");
            }
            else if (iTxtValue > 0)
            {
                MessageBox.Show("양수 입니다.");
            }
            else
            {
                MessageBox.Show("0 값을 입력하였습니다.");
            }
        }

        private void btnH_JTest_Click(object sender, EventArgs e)
        {
            int iTxtValue = 0;
            bool bFlag = false;
            bFlag = int_.TryParse(txtInput.Text, out iTxtValue);
            if (!bFlag)
            {
                MessageBox.Show("홀수 짝수를 판단을 할 수 없습니다.");
                return;
            }

            // 홀수 짝수 로직 처리
            if (iTxtValue%2 == 0)
            {
                MessageBox.Show("짝수 입니다.");
            }
            else
            {
                MessageBox.Show("홀수 입니다.");
            }
        }

        private void btnTernaryOperator_Click(object sender, EventArgs e)
        {
            // 삼항 연산자.
            // 피연산자의 개수가 3개인 조건부 연산자.
            // if - else 구문을 한줄로 간단하게 표현 할 수 있기 때문에
            // 인라인 if (In-Line If)문 이라고도 한다.

            int iTxtValue = 0;
            bool bFlag = false;
            bFlag = int_.TryParse(txtInput.Text, out iTxtValue);
            if (!bFlag)
            {
                MessageBox.Show("홀수 짝수를 판단을 할 수 없습니다.");
                return;
            }

            string sResult = string.Empty; // string sResult = "";

            sResult = (iTxtValue % 2 == 0) ? "짝수입니다." : "홀수입니다.";
            MessageBox.Show((iTxtValue % 2 == 0) ? "짝수입니다." : "홀수입니다.");
            MessageBox.Show(Convert.ToString((iTxtValue % 2 == 0) ? 2 : 1));
        }
    }
}
