using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFirstCShap
{
    public partial class Chap06_StringFind : Form
    {
        string sStrTitle;
        public Chap06_StringFind()
        {
            InitializeComponent();
            sStrTitle = lblTitle.Text;
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // Index Of - 문자열 내에서 찾고자 하는 지정된 문자
            //            또는 문자열의 위치 Index 찾기

            // 1. 타이틀 내용 변수에 담기
            string sTitle = lblTitle.Text;

            // 2. 사용자가 지정한 문자열 변수에 담기
            string sValue = txtIndexOf.Text;

            // 3. 사용자가 지정한 문자 위치 찾기.
            int iIndex; // 사용자 지정 문자 위치 변수
            iIndex = sTitle.IndexOf(sValue);

            MessageBox.Show(Convert.ToString(iIndex));
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            // 1. 타이틀 변수 생성 및 데이터 담기.
            string sTitle = lblTitle.Text;

            // 2. 사용자가 지정한 문자.
            string sValue = txtLastIndexOf.Text;

            // 3. 인덱스 찾아서 변수에 담기
            int iIndex = sTitle.LastIndexOf(sValue);

            MessageBox.Show(Convert.ToString(iIndex));

        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            // StartWith : 해당 문자열로 시작하는지 판단.
            //             성공 : True , 실패 : False

            // 1. 타이틀 내용 변수에 담기.
            string sTitle = lblTitle.Text;

            // 2. 사용자가 지정한 문자 변수에 담기.
            string sValue = txtStartWith.Text;

            // 3. 판단 결과 반환하기
            bool bFlag = sTitle.StartsWith(sValue);
            
            MessageBox.Show(Convert.ToString(bFlag));
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            // EndWith : 문자열이 지정한 문자로 끝나는지 판단한다.

            // 1. 타이틀 내용 변수에 담기.
            string sTitle = lblTitle.Text;

            // 2. 사용자가 지정한 문자 변수에 담기.
            string sValue = txtEndWith.Text;

            // 3. 판단 결과 반환하기
            bool bFlag = sTitle.EndsWith(sValue);

            MessageBox.Show(Convert.ToString(bFlag));
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            // Contains() : 지정한 문자열을 포함하고
            //              있는지 결과를 반환한다.

            // 1. 타이틀 라벨에 있는 문자열을 문자 변수에 등록
            string sTitle = lblTitle.Text;

            // 2. 사용자 지정한 문자.
            string sValue = txtContains.Text;

            // 3. 문자열을 포함하고 있는지 판단.
            // 3-1. 변수(참/거짓)를 만들고 결과값을 담는 유형
            bool bContains;
            bContains = sTitle.Contains(sValue);
            // bContains 결과값에 따른 후속 로직을 작성할 수 있다.
            bContains = !bContains;

            // 3-2. 변수를 만들면서 결과값을 담는 방법
            bool bContains2 = sTitle.Contains(sValue);
            // bContains2 결과값에 따른 후속 로직을 작성할 수 있다.
            bContains2 = !bContains2;

            // 3-3 변수에 담지 않고 결과값을 표현
            MessageBox.Show(Convert.ToString(sTitle.Contains(sValue)));
            // 후속 로직을 작성하는데 번거롭다.
            bool bContains3 = sTitle.Contains(sValue);

            // 결과값 표현
            MessageBox.Show(Convert.ToString(bContains));
            MessageBox.Show(Convert.ToString(bContains2));
        }

        private void btnChang_Click(object sender, EventArgs e)
        {
            // Replace : 문자열 변환하기.

            // 1. 문자열 변환할 대상이 있는 문자열
            string sTitle = lblTitle.Text;

            // 2. 변환을 해야할 문자열.
            string sObj = txtReplace1.Text;

            // 3. 변환시킬 문자열.
            string sValue = txtReplace2.Text;

            // 라벨에 변경된 내용 표시하기.
            lblTitle.Text = sTitle.Replace(sObj, sValue);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // 라벨 타이틀의 문구를 원본데이터로 변경한다.

            // 원본 데이터를 복구 하기 위하야 응용해야 하는 개념은?
            // 함수(메서드)가 관리하는 변수이냐/
            // 클래스가 관리하는 변수이냐에 따라 달라짐
            // 클래스가 관리하는 변수러 지정할 경우
            // 클래스가 종료 될 때까지 남아있으므로
            // 클래스의 하위 속성인 메서드에서 공용으로 사용할 수 있다.

            string sTitle = lblTitle.Text;
            lblTitle.Text = sTitle.Replace(sTitle, sStrTitle);
        }
    }
}
