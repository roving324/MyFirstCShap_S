namespace MyFirstCSharp
{
    partial class Chap22_Algorithm_Test08
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDesc = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesc2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "아래의 수를 내림차순으로 정렬하여 텍스트박스에 표현하세요.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(79, 96);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 15);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "1, 11, 6, 20, 11, 8, 12, 6, 16, 13, 22";
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(16, 131);
            this.btnDesc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(353, 47);
            this.btnDesc.TabIndex = 5;
            this.btnDesc.Text = "내림차순 정렬";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(16, 234);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(354, 23);
            this.txtDesc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "* Array.Sort기능을 사용하지 말것";
            // 
            // btnDesc2
            // 
            this.btnDesc2.Location = new System.Drawing.Point(16, 181);
            this.btnDesc2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDesc2.Name = "btnDesc2";
            this.btnDesc2.Size = new System.Drawing.Size(353, 47);
            this.btnDesc2.TabIndex = 5;
            this.btnDesc2.Text = "내림차순 정렬";
            this.btnDesc2.UseVisualStyleBackColor = true;
            this.btnDesc2.Click += new System.EventHandler(this.btnDesc2_Click);
            // 
            // Chap22_Algorithm_Test08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnDesc2);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Chap22_Algorithm_Test08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private Button btnDesc2;
    }
}