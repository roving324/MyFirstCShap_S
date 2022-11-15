using MyFirstCShap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MyFirstCSharp
{
    public partial class Chap10_Class2 : Form
    {
        //  클래스가 객체화 될때 
        //  필드 멤버 -> 생성자 멤버 순으로 클래스가 객체화 된다. 

        // ************필드**********
        // Chap10_Class 클래스를 필드멤버로 객체화. 
        Chap10_Class CHAP10 = new Chap10_Class();

        public Chap10_Class2()
        {
            // 화면 디자인을 표현. 
            InitializeComponent();
            CHAP10.sArm = "로봇팔";
        }

        private void btnClassInstance_Click(object sender, EventArgs e)
        {
            //// 클래스의 객체화(인스턴스 화)
            //// 클래스 => (객체 = 인스턴스)
            //Chap10_Class Chap10 = new Chap10_Class();
            //Chap10.sArm = "왼팔";
            //MessageBox.Show(Chap10.sArm);

            //// Chap10_2 라는 이름으로 Chap10_Class 를 객체화
            //Chap10_Class Chap10_2 = new Chap10_Class();
            //Chap10_2.sArm = "오른팔";
            //MessageBox.Show(Chap10_2.sArm);

            MessageBox.Show(CHAP10.sArm);
        }


        private void btnClassInstance2_Click(object sender, EventArgs e)
        {
            //Chap10_Class Chap10 = new Chap10_Class();
            //MessageBox.Show(Chap10.sArm); // 팔.

            MessageBox.Show(CHAP10.sArm);
        }

        private void btnMethodCall_Click(object sender, EventArgs e)
        {
            // 다른 클래스의 메서드 호출.
            CHAP10.Method1();
        }
    }
}
