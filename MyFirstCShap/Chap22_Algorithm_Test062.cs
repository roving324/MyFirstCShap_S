using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CHAP04_MiddleExam
{
    public partial class Chap22_Algorithm_Test062 : Form
    {
        public Chap22_Algorithm_Test062()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;
            sTitle = sTitle.Replace("{", "");
            sTitle = sTitle.Trim();
            sTitle = sTitle.Replace("}", "");
            Dictionary<int, int> MyDic = new Dictionary<int, int>();
            ArrayList list = new ArrayList();

            string[] sValues = sTitle.Split(',');
            string sResult = string.Empty;

            int[] iValues = new int[sValues.Length];

            for (int i = 0; i < sValues.Length; i++)
            {
                iValues[i] = Convert.ToInt32(sValues[i]);
                if (MyDic.ContainsKey(iValues[i])) MyDic[iValues[i]] += 1;
                else
                {
                    MyDic.Add(iValues[i], 1);
                    continue;
                }
                if (MyDic[iValues[i]] == 2) list.Add(iValues[i]);
            }
            list.Sort();
            MessageBox.Show($"{list[0]},{list[2]}");
        }
    }
}
