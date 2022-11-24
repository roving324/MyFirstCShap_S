using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCShap
{
    public partial class Chap22_Algorithm_Test03 : Form
    {
        public Chap22_Algorithm_Test03()
        {
            InitializeComponent();
        }

        private void btnSearchDic_Click(object sender, EventArgs e)
        {
            // 중복 되지 않는 문자열 찾기
            string sTitle = label2.Text;
            Dictionary<char, int> MyDic = new Dictionary<char, int>();

            foreach (char cWord in sTitle)
            {
                if (MyDic.ContainsKey(cWord))
                {
                    MyDic[cWord] += 1;
                }
                else
                {
                    MyDic.Add(cWord, 1);
                    // MyDic["A"] = 1
                    // MyDic["B"] = 1
                    // MyDic["C"] = 1
                    // MyDic["D"] = 1
                    // MyDic["/"] = 1
                    // MyDic["E"] = 1
                    // MyDic["M"] = 1
                    // MyDic["L"] = 1
                }
            }
            foreach (char cKey in MyDic.Keys)
            {
                if (MyDic[cKey] == 1)
                {
                    MessageBox.Show($"중복되지 않는 왼쪽의 첫 문자는 {cKey} 입니다.");
                    break;
                }
            }
        }

        private void btnSearchLast_Click(object sender, EventArgs e)
        {
            /*
            // 중복되지 않는 문자열 찾기
            string sTitle = label2.Text;

            string sNowString  = string.Empty;

            for(int i = 0; i < sTitle.Length; i++)
            {

                if (i == sTitle.LastIndexOf(sNowString))
                {
                    MessageBox.Show($"중복되지 않는 왼쪽의 첫 문자는 {sNowString} 입니다.");
                    break;
                }
            }
            */
            string sTitle = label2.Text;

            string sValue = "";

            for (int i = 0; i < sTitle.Length; i++)
            {
                sValue = sTitle.Substring(i, 1);
                if (sTitle.IndexOf(sValue) == sTitle.LastIndexOf(sValue))
                {
                    MessageBox.Show($"중복되지 않는 첫 문자는 {sValue} 입니다.");
                    break;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*
            string sTitle = label2.Text;
            string sBaseWord = string.Empty;
            for (int i = 0; i < sTitle.Length; i++)
            {
                sBaseWord = sTitle.Substring(i, 1);

                bool bFindFlag = true;
                // int j 기준 문자로 부터 비교대상 문자의 위치
                for (int j = i + 1; j < sTitle.Length; j++)
                {
                    // 기준 문자 이후부터 한글자씩 추출.
                    string sValueWord = sTitle.Substring(j, 1);
                    
                    // 기준 문자의 추출한 문자를 비겨
                    if(sBaseWord == sValueWord)
                    {
                        // 중복 문자를 찾았을 때 bFindFlag = false 를 대입
                        bFindFlag = false;
                        break;
                    }
                    // 중복 문자를 찾지못했을 때 bFindFlag = true 를 대입
                    bFindFlag = true;
                }

                // 중복 문자를 찾지 못했으므로
                if (bFindFlag)
                {
                    // For 반복문 종료.
                    break;
                }
            }
            // 기준 문자로 잡은 sBaseWord를 표현.
            MessageBox.Show($"중복되지 않는 첫 문자는 {sBaseWord} 입니다.");
            */
            
            string[] sVT = new string[label2.Text.Length];
            for (int k = 0; k < label2.Text.Length; k++)
            {
                sVT[k] = label2.Text.Substring(k, 1);
            }
            string sValue = "?";
            bool bFlag = true;

            for (int i = 0; i < label2.Text.Length; i++)
            {
                for (int j = i+1; j < label2.Text.Length; j++)
                {
                    if (sVT[i] == sVT[j])
                    {
                        bFlag = false;
                        break;
                    }
                    bFlag = true;
                }
                if(bFlag)
                {
                    sValue = sVT[i];
                    break;
                }
            }
            MessageBox.Show($"중복되지 않는 첫 문자는 {sValue} 입니다.");
            
        }
    }
}
