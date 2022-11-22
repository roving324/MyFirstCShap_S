namespace MyFirstCShap
{
    partial class Chap17_Loop01_ForTest06
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTwoMulSum = new System.Windows.Forms.Button();
            this.btnFiveMulSum = new System.Windows.Forms.Button();
            this.btnTenMulSum = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "For 문을 한번만 코딩하여 범위안의 수 중 2,5,10의 배수 합을";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "버튼을 클릭 하였을 때 메세지로 표현하는 프로그램";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "입력받을 범위";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "-";
            // 
            // btnTwoMulSum
            // 
            this.btnTwoMulSum.Location = new System.Drawing.Point(12, 196);
            this.btnTwoMulSum.Name = "btnTwoMulSum";
            this.btnTwoMulSum.Size = new System.Drawing.Size(130, 38);
            this.btnTwoMulSum.TabIndex = 4;
            this.btnTwoMulSum.Text = "2의 배수 표현";
            this.btnTwoMulSum.UseVisualStyleBackColor = true;
            this.btnTwoMulSum.Click += new System.EventHandler(this.btnTwoMulSum_Click);
            // 
            // btnFiveMulSum
            // 
            this.btnFiveMulSum.Location = new System.Drawing.Point(148, 196);
            this.btnFiveMulSum.Name = "btnFiveMulSum";
            this.btnFiveMulSum.Size = new System.Drawing.Size(130, 38);
            this.btnFiveMulSum.TabIndex = 4;
            this.btnFiveMulSum.Text = "5의 배수 표현";
            this.btnFiveMulSum.UseVisualStyleBackColor = true;
            this.btnFiveMulSum.Click += new System.EventHandler(this.btnFiveMulSum_Click);
            // 
            // btnTenMulSum
            // 
            this.btnTenMulSum.Location = new System.Drawing.Point(284, 196);
            this.btnTenMulSum.Name = "btnTenMulSum";
            this.btnTenMulSum.Size = new System.Drawing.Size(130, 38);
            this.btnTenMulSum.TabIndex = 4;
            this.btnTenMulSum.Text = "10의 배수 표현";
            this.btnTenMulSum.UseVisualStyleBackColor = true;
            this.btnTenMulSum.Click += new System.EventHandler(this.btnTenMulSum_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(231, 142);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(64, 23);
            this.txtEnd.TabIndex = 5;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(143, 142);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(64, 23);
            this.txtStart.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = ". 텍스트 박스의 문자는 반드시 숫자만 입력되어야 함";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = ". 음수는 입력 받을 수 없음.";
            // 
            // Chap17_Loop01_ForTest05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 305);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.btnTenMulSum);
            this.Controls.Add(this.btnFiveMulSum);
            this.Controls.Add(this.btnTwoMulSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap17_Loop01_ForTest05";
            this.Text = "For 문 실습2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnTwoMulSum;
        private Button btnFiveMulSum;
        private Button btnTenMulSum;
        private TextBox txtEnd;
        private TextBox txtStart;
        private Label label5;
        private Label label6;
    }
}