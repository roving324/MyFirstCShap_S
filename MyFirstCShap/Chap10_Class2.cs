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
    public partial class Chap10_Class2 : Form
    {
        // 클래스가 객체화 될 때
        // 필드 멤버 -> 생성자 멤버 클래스가 객체화 되다.
        // Chap10_Class 클래스를 필드멤버로 객체화
        // 필드멤버 > 생성자 =? 메서드 순서로 호출
        // partial은 파생으로 같은 이름을 쓸수있다.(부속, 디자이너.cs)
        Chap10_Class Chap10 = new Chap10_Class();
        public Chap10_Class2()
        {
            InitializeComponent();
            Chap10.sArm = "로봇팔";
        }
        private void btnClassInstance_Click(object sender, EventArgs e)
        {
            // 클래스의 객체화(인스턴스화)
            // 클래스 => (객체 = 인스턴스)
            //Chap10_Class Chap10 = new Chap10_Class();
            //Chap10.sArm = "왼팔";
            MessageBox.Show(Chap10.sArm);  // 왼팔

            // Chap10_2라는 이름으로 Chap10_Class를 객체화
            //Chap10_Class Chap10_2 = new Chap10_Class();
            //Chap10_2.sArm = "오른팔";
            //MessageBox.Show(Chap10_2.sArm); // 오른팔
        }

        private void btnClassInstance2_Click(object sender, EventArgs e)
        {
            //Chap10_Class chap10 = new Chap10_Class();
            MessageBox.Show(Chap10.sArm); // 팔
        }

        private void btnMerhodCall_Click(object sender, EventArgs e)
        {
            // 다른 클래스의 메서드 호출.
            Chap10.Method1();
        }
    }
}
