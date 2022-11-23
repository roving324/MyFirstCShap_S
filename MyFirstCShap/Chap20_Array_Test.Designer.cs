namespace MyFirstCShap
{
    partial class Chap20_Array_Test
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
            this.btnChange = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래의 2,4배열을 만들고 1행과 2행을 바꾸어 새로운 배열에 담아";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "배열과 결과를 텍스트 박스에 표현하세요.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "(1, 2, 3, 4) => (5, 6, 7, 8)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "(5, 6, 7, 8)      (1, 2, 3, 4)";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(28, 133);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(144, 36);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "변경하기";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(28, 188);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(261, 105);
            this.txtResult.TabIndex = 2;
            // 
            // Chap20_Array_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_Array_Test";
            this.Text = "배열 실습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnChange;
        private TextBox txtResult;
    }
}