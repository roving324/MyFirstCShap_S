using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CHAP04_MiddleExam
{
    public partial class Chap22_Algorithm_Test06 : Form
    {
        public Chap22_Algorithm_Test06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            Dictionary<int, int> MyDic = new Dictionary<int, int>();
            string sTitle = lblTitle.Text;
            sTitle = sTitle.Trim();
            sTitle = sTitle.Remove(0, 1);
            sTitle = sTitle.Remove(sTitle.Length - 1, 1);
            string[] sValues = sTitle.Split(",");

            int[] iValues = new int[sValues.Length];
            int i = 0;

            foreach (string iValue in sValues)
            {
                iValues[i] = Convert.ToInt32(iValue);
                i++;
            }
            i = 0;
            for(int j = 0; j < iValues.Length; j++)
            {
                for(int k = j+1; k < iValues.Length; k++)
                {
                    if (iValues[j] == iValues[k] && !(MyDic.ContainsKey(iValues[j])))
                    {
                        list.Add(iValues[j]);
                        MyDic.Add(iValues[j], 0);
                        i++;
                    }
                }
            }
            list.Sort();
            MessageBox.Show($"중복되는 수 중 첫번째 : {list[0]} 이고 세번째 : {list[2]}입니다.");
        } 
    }
}
