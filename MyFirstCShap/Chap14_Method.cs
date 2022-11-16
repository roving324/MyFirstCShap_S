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
    public partial class Chap14_Method : Form
    {
        // 메서드 (함수) 와 리턴(반환하는 결과) 값
        // 데이터를 주는 값 : 인수, 아규먼트라고 부른다.
        // 데이터를 받는 값 : 인자, 매개변수, 파라매터라고 부른다.
        // Return : 메서드에서 처리한 어떠한 결과를 메서드를 호출한 부분으로 넘겨주는 기능.
        // ref, Out, In : 매개변수, 한전자.

        public Chap14_Method()
        {
            InitializeComponent();
        }

        #region < 기본 메서드 호출 >

        private void btnMethodCall_Click(object sender, EventArgs e)
        {
            string a = "sada";
            ShowMessage(a);
        }
        private void ShowMessage(string asd)
        {
            MessageBox.Show(asd);
            txtTitle.Text = "안녕하세요";
            lblTitle.Text = "안녕하세요";
        }
        #endregion
    }
}
