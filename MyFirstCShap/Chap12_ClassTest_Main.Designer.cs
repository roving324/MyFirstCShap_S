namespace MyFirstCShap
{
    partial class Chap12_ClassTest_Main
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
            this.btnNowStatus = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNowStatus
            // 
            this.btnNowStatus.Location = new System.Drawing.Point(46, 24);
            this.btnNowStatus.Name = "btnNowStatus";
            this.btnNowStatus.Size = new System.Drawing.Size(102, 176);
            this.btnNowStatus.TabIndex = 0;
            this.btnNowStatus.Text = "설비 현재 상태 확인";
            this.btnNowStatus.UseVisualStyleBackColor = true;
            this.btnNowStatus.Click += new System.EventHandler(this.btnNowStatus_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(163, 24);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(136, 85);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "가동 화면 호출";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(163, 115);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(136, 85);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "정지 화면 호출";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Chap12_ClassTest_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 259);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnNowStatus);
            this.Name = "Chap12_ClassTest_Main";
            this.Text = "설비 가동/비가동";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNowStatus;
        private Button btnRun;
        private Button btnStop;
    }
}