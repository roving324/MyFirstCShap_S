namespace MyFirstCShap
{
    partial class Chap13_Static_Const
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
            this.btnHello = new System.Windows.Forms.Button();
            this.btnNice = new System.Windows.Forms.Button();
            this.btnFighting = new System.Windows.Forms.Button();
            this.btnStaticOrInstance = new System.Windows.Forms.Button();
            this.btnStaticOrInstance_Call = new System.Windows.Forms.Button();
            this.btnConst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(21, 40);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(151, 61);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "안녕하세요";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnNice
            // 
            this.btnNice.Location = new System.Drawing.Point(178, 40);
            this.btnNice.Name = "btnNice";
            this.btnNice.Size = new System.Drawing.Size(151, 61);
            this.btnNice.TabIndex = 0;
            this.btnNice.Text = "반갑습니다.";
            this.btnNice.UseVisualStyleBackColor = true;
            this.btnNice.Click += new System.EventHandler(this.btnNice_Click);
            // 
            // btnFighting
            // 
            this.btnFighting.Location = new System.Drawing.Point(335, 40);
            this.btnFighting.Name = "btnFighting";
            this.btnFighting.Size = new System.Drawing.Size(151, 61);
            this.btnFighting.TabIndex = 0;
            this.btnFighting.Text = "화이팅";
            this.btnFighting.UseVisualStyleBackColor = true;
            this.btnFighting.Click += new System.EventHandler(this.btnFighting_Click);
            // 
            // btnStaticOrInstance
            // 
            this.btnStaticOrInstance.Location = new System.Drawing.Point(21, 107);
            this.btnStaticOrInstance.Name = "btnStaticOrInstance";
            this.btnStaticOrInstance.Size = new System.Drawing.Size(227, 61);
            this.btnStaticOrInstance.TabIndex = 0;
            this.btnStaticOrInstance.Text = "정적/인스턴스 필드 값 대입";
            this.btnStaticOrInstance.UseVisualStyleBackColor = true;
            this.btnStaticOrInstance.Click += new System.EventHandler(this.btnStaticOrInstance_Click);
            // 
            // btnStaticOrInstance_Call
            // 
            this.btnStaticOrInstance_Call.Location = new System.Drawing.Point(259, 107);
            this.btnStaticOrInstance_Call.Name = "btnStaticOrInstance_Call";
            this.btnStaticOrInstance_Call.Size = new System.Drawing.Size(227, 61);
            this.btnStaticOrInstance_Call.TabIndex = 0;
            this.btnStaticOrInstance_Call.Text = "정적/인스턴스 필드 호출";
            this.btnStaticOrInstance_Call.UseVisualStyleBackColor = true;
            this.btnStaticOrInstance_Call.Click += new System.EventHandler(this.btnStaticOrInstance_Call_Click);
            // 
            // btnConst
            // 
            this.btnConst.Location = new System.Drawing.Point(21, 174);
            this.btnConst.Name = "btnConst";
            this.btnConst.Size = new System.Drawing.Size(151, 61);
            this.btnConst.TabIndex = 0;
            this.btnConst.Text = "상수";
            this.btnConst.UseVisualStyleBackColor = true;
            this.btnConst.Click += new System.EventHandler(this.btnConst_Click);
            // 
            // Chap13_Static_Const
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 285);
            this.Controls.Add(this.btnConst);
            this.Controls.Add(this.btnFighting);
            this.Controls.Add(this.btnNice);
            this.Controls.Add(this.btnStaticOrInstance_Call);
            this.Controls.Add(this.btnStaticOrInstance);
            this.Controls.Add(this.btnHello);
            this.Name = "Chap13_Static_Const";
            this.Text = "static 한정자와 변수";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHello;
        private Button btnNice;
        private Button btnFighting;
        private Button btnStaticOrInstance;
        private Button btnStaticOrInstance_Call;
        private Button btnConst;
    }
}