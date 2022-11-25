namespace MyFirstCSharp
{
    partial class Chap22_Algorithm_Test051
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtRan1 = new System.Windows.Forms.TextBox();
            this.txtRan2 = new System.Windows.Forms.TextBox();
            this.txtRan3 = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "버튼을 클릭하여 0 부터 100 까지의 임의의 수를 3번 받아 자료형 구조에 담고 (Array, ArrayList..) 각각 텍스트박스에 표현하고" +
    " 결과 버튼을 눌렀을때";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "3 수의 합이 100 미만일 경우 최소값 * 최대값  을 메세지로";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "3 수의 합이 100이상 200 미만 일 경우 최소값 + 최대값 을 메세지로";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "3 수의 합이 200이상일 경우 \"세 수의 합이 200 이 넘습니다.\" 메세지 를 표현하세요";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(124, 200);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(163, 41);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "난수 생성";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // txtRan1
            // 
            this.txtRan1.Location = new System.Drawing.Point(311, 215);
            this.txtRan1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRan1.Name = "txtRan1";
            this.txtRan1.Size = new System.Drawing.Size(88, 23);
            this.txtRan1.TabIndex = 8;
            // 
            // txtRan2
            // 
            this.txtRan2.Location = new System.Drawing.Point(411, 215);
            this.txtRan2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRan2.Name = "txtRan2";
            this.txtRan2.Size = new System.Drawing.Size(88, 23);
            this.txtRan2.TabIndex = 9;
            // 
            // txtRan3
            // 
            this.txtRan3.Location = new System.Drawing.Point(513, 215);
            this.txtRan3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRan3.Name = "txtRan3";
            this.txtRan3.Size = new System.Drawing.Size(88, 23);
            this.txtRan3.TabIndex = 10;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(615, 200);
            this.btnResult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(110, 41);
            this.btnResult.TabIndex = 11;
            this.btnResult.Text = "결과";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(702, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = " * 난수는 버튼을 클릭할때마다 텍스트 박스에 표현되며 만약 4번째 클릭일시 다시 첫번째 텍스트박스에 새로운 난수가 표현 된다.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(510, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = " * 결과 버튼 클릭시 난수 가 3개 생성 되어 있지 않으면 메세지로 표현후 실행을 하지 않는다. ";
            // 
            // Chap22_Algorithm_Test05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 272);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtRan3);
            this.Controls.Add(this.txtRan2);
            this.Controls.Add(this.txtRan1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Chap22_Algorithm_Test05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txtRan1;
        private System.Windows.Forms.TextBox txtRan2;
        private System.Windows.Forms.TextBox txtRan3;
        private System.Windows.Forms.Button btnResult;
        private Label label5;
        private Label label6;
    }
}