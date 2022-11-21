namespace MyFirstCShap
{
    partial class Chap15_Test
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
            this.btnFlag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInoutValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMultiE = new System.Windows.Forms.TextBox();
            this.txtBtnClickCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFlag
            // 
            this.btnFlag.Location = new System.Drawing.Point(362, 38);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(134, 23);
            this.btnFlag.TabIndex = 0;
            this.btnFlag.Text = "2,5 공배수 여부 판단";
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "입력 받을 값";
            // 
            // txtInoutValue
            // 
            this.txtInoutValue.Location = new System.Drawing.Point(168, 38);
            this.txtInoutValue.Name = "txtInoutValue";
            this.txtInoutValue.Size = new System.Drawing.Size(176, 23);
            this.txtInoutValue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "8의 배수일 경우 값과의 곱";
            // 
            // txtMultiE
            // 
            this.txtMultiE.Location = new System.Drawing.Point(168, 90);
            this.txtMultiE.Name = "txtMultiE";
            this.txtMultiE.Size = new System.Drawing.Size(176, 23);
            this.txtMultiE.TabIndex = 2;
            // 
            // txtBtnClickCount
            // 
            this.txtBtnClickCount.Location = new System.Drawing.Point(168, 141);
            this.txtBtnClickCount.Name = "txtBtnClickCount";
            this.txtBtnClickCount.Size = new System.Drawing.Size(176, 23);
            this.txtBtnClickCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "버튼을 클릭한 총 횟수";
            // 
            // Chap15_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 226);
            this.Controls.Add(this.txtBtnClickCount);
            this.Controls.Add(this.txtMultiE);
            this.Controls.Add(this.txtInoutValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFlag);
            this.Name = "Chap15_Test";
            this.Text = "분기문 테스트_공배수 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFlag;
        private Label label1;
        private TextBox txtInoutValue;
        private Label label2;
        private TextBox txtMultiE;
        private TextBox txtBtnClickCount;
        private Label label3;
    }
}