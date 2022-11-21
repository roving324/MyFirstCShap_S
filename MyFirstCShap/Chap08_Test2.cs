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
using System.Windows.Forms;

namespace MyFirstCShap
{
    public partial class Chap08_Test2 : Form
    {
        string sTitle;
        public Chap08_Test2()
        {
            InitializeComponent();
            sTitle = lblTitle.Text;
        }
        
        private void btnNameChange_Click(object sender, EventArgs e)
        {
            // 한줄로 표현하는 로직을 구현 해 보세요.
            lblTitle.Text = lblTitle.Text.Replace("OOO", "황준영");
        }

        private void btnswFound_Click(object sender, EventArgs e)
        {
            // S/W 위치 찾기
            int iIndex = lblTitle.Text.IndexOf("S/W");
            MessageBox.Show(iIndex.ToString());

            // 한줄로 표현 해 보세요.
            MessageBox.Show(Convert.ToString(lblTitle.Text.IndexOf("S/W")));
        }

        private void btnKDT_Click(object sender, EventArgs e)
        {
            lblTitle.Text = $"-KDT-{lblTitle.Text}-KDT-";
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            // SMARTFACTORY 만 소문자로 변경

            // 1. 처리할 문자열 (타이틀)
            string sTitle = lblTitle.Text;

            // 2. 변경해야 할 문자 ? 
            string sValue = "SMARTFACTORY";

            // 3. SMARTFACTORY 문구가 있는 위치(주소) 찾기.
            int iIndex = sTitle.IndexOf(sValue);

            // 4. 라벨 타이틀 에서 SMARTFACTORY 문구를 삭제.
            string sResult = sTitle.Remove(iIndex, sValue.Length);

            // 5. 대문자를 소문자로 변경.
            sValue = sValue.ToLower();

            // 6. 소문자 삽입 후 Text 표현. 
            lblTitle.Text = sResult.Insert(iIndex, sValue);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 모든 공백 없애기.
            lblTitle.Text = lblTitle.Text.Replace(" ", "");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // 문자열 되돌리기.
            lblTitle.Text = sTitle;
        }
        
    }
}
