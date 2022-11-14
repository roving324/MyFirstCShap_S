using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCShap
{
    public partial class Chap08_Test : Form
    {
        string sTitleOri;
        public Chap08_Test()
        {
            InitializeComponent();
            sTitleOri = lblTitle.Text;
        }

        private void btnNameChange_Click(object sender, EventArgs e)
        {
            lblTitle.Text = lblTitle.Text.Replace("OOO", "황준영");
        }

        private void btnswFound_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(lblTitle.Text.IndexOf("S/W")));
        }

        private void btnKDT_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;
            string sString = "-KDT-";

            lblTitle.Text = sTitle.Insert(0, sString);
            lblTitle.Text = lblTitle.Text.Insert(lblTitle.Text.Length, sString);

            // 보간법
            // lblTitle.Text = $"{sString}{lblTitle.Text}{sString}";
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;
            string sFind = "SMARTFACTORY";
            string sResult = sTitle.Substring(sTitle.IndexOf(sFind), sFind.Length);

            lblTitle.Text = sTitle.Replace(sResult, sResult.ToLower());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblTitle.Text = lblTitle.Text.Replace(" ", "");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            lblTitle.Text = sTitleOri;
        }
    }
}
