﻿namespace MyFirstCShap
{
    partial class Chap16_Switch_Test
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApple = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMellon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMellonCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnW_M = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblW_MCount = new System.Windows.Forms.Label();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApple);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAppCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사과";
            // 
            // btnApple
            // 
            this.btnApple.Location = new System.Drawing.Point(6, 49);
            this.btnApple.Name = "btnApple";
            this.btnApple.Size = new System.Drawing.Size(162, 118);
            this.btnApple.TabIndex = 1;
            this.btnApple.Text = "사과 주문";
            this.btnApple.UseVisualStyleBackColor = true;
            this.btnApple.Click += new System.EventHandler(this.btnApple_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "개";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "2000원 남은 수량 :";
            // 
            // lblAppCount
            // 
            this.lblAppCount.AutoSize = true;
            this.lblAppCount.Location = new System.Drawing.Point(122, 19);
            this.lblAppCount.Name = "lblAppCount";
            this.lblAppCount.Size = new System.Drawing.Size(21, 15);
            this.lblAppCount.TabIndex = 1;
            this.lblAppCount.Text = "10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMellon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblMellonCount);
            this.groupBox2.Location = new System.Drawing.Point(198, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 181);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "참외";
            // 
            // btnMellon
            // 
            this.btnMellon.Location = new System.Drawing.Point(6, 49);
            this.btnMellon.Name = "btnMellon";
            this.btnMellon.Size = new System.Drawing.Size(162, 118);
            this.btnMellon.TabIndex = 1;
            this.btnMellon.Text = "참외 주문";
            this.btnMellon.UseVisualStyleBackColor = true;
            this.btnMellon.Click += new System.EventHandler(this.btnMellon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "개";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "2500원 남은 수량 :";
            // 
            // lblMellonCount
            // 
            this.lblMellonCount.AutoSize = true;
            this.lblMellonCount.Location = new System.Drawing.Point(122, 19);
            this.lblMellonCount.Name = "lblMellonCount";
            this.lblMellonCount.Size = new System.Drawing.Size(21, 15);
            this.lblMellonCount.TabIndex = 1;
            this.lblMellonCount.Text = "10";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnW_M);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblW_MCount);
            this.groupBox3.Location = new System.Drawing.Point(384, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 181);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "수박";
            // 
            // btnW_M
            // 
            this.btnW_M.Location = new System.Drawing.Point(6, 49);
            this.btnW_M.Name = "btnW_M";
            this.btnW_M.Size = new System.Drawing.Size(162, 118);
            this.btnW_M.TabIndex = 1;
            this.btnW_M.Text = "수박 주문";
            this.btnW_M.UseVisualStyleBackColor = true;
            this.btnW_M.Click += new System.EventHandler(this.btnW_M_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "개";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "18000원 남은 수량 :";
            // 
            // lblW_MCount
            // 
            this.lblW_MCount.AutoSize = true;
            this.lblW_MCount.Location = new System.Drawing.Point(122, 19);
            this.lblW_MCount.Name = "lblW_MCount";
            this.lblW_MCount.Size = new System.Drawing.Size(21, 15);
            this.lblW_MCount.TabIndex = 1;
            this.lblW_MCount.Text = "10";
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Location = new System.Drawing.Point(198, 224);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(180, 95);
            this.btnTotalPrice.TabIndex = 1;
            this.btnTotalPrice.Text = "총 결제 금액 보기";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // Chap16_Switch_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 348);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chap16_Switch_Test";
            this.Text = "Switch 분기문 실습";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label lblAppCount;
        private Label label3;
        private Button btnApple;
        private GroupBox groupBox2;
        private Button btnMellon;
        private Label label2;
        private Label label4;
        private Label lblMellonCount;
        private GroupBox groupBox3;
        private Button btnW_M;
        private Label label5;
        private Label label6;
        private Label lblW_MCount;
        private Button btnTotalPrice;
    }
}