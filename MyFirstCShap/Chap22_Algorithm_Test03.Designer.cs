namespace MyFirstCShap
{
    partial class Chap22_Algorithm_Test03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchDic = new System.Windows.Forms.Button();
            this.btnSearchLast = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래의 문자열 중 중복되지 않는 문자를 찾고, 왼쪽에서 가장 첫 번째 문자를 메세지박스로 나타내세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(271, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ABCLD/EML/BZAMDC/";
            // 
            // btnSearchDic
            // 
            this.btnSearchDic.Location = new System.Drawing.Point(224, 135);
            this.btnSearchDic.Name = "btnSearchDic";
            this.btnSearchDic.Size = new System.Drawing.Size(251, 33);
            this.btnSearchDic.TabIndex = 2;
            this.btnSearchDic.Text = "찾기(Dictoinary, Foreach)";
            this.btnSearchDic.UseVisualStyleBackColor = true;
            this.btnSearchDic.Click += new System.EventHandler(this.btnSearchDic_Click);
            // 
            // btnSearchLast
            // 
            this.btnSearchLast.Location = new System.Drawing.Point(224, 174);
            this.btnSearchLast.Name = "btnSearchLast";
            this.btnSearchLast.Size = new System.Drawing.Size(251, 33);
            this.btnSearchLast.TabIndex = 2;
            this.btnSearchLast.Text = "찾기(LastIndexOf())";
            this.btnSearchLast.UseVisualStyleBackColor = true;
            this.btnSearchLast.Click += new System.EventHandler(this.btnSearchLast_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(224, 213);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(251, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "찾기";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Chap22_Algorithm_Test03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 336);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSearchLast);
            this.Controls.Add(this.btnSearchDic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap22_Algorithm_Test03";
            this.Text = "중보고되지 않는 문자열 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSearchDic;
        private Button btnSearchLast;
        private Button btnSearch;
    }
}