namespace MyFirstCShap
{
    partial class Chap08_Test
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNameChange = new System.Windows.Forms.Button();
            this.btnswFound = new System.Windows.Forms.Button();
            this.btnKDT = new System.Windows.Forms.Button();
            this.btnToLower = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(749, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "안녕하세요 2022 스마트팩토리 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 SMARTFACTORY 교육이 되었으면 합니다" +
    ".";
            // 
            // btnNameChange
            // 
            this.btnNameChange.Location = new System.Drawing.Point(25, 78);
            this.btnNameChange.Name = "btnNameChange";
            this.btnNameChange.Size = new System.Drawing.Size(130, 53);
            this.btnNameChange.TabIndex = 1;
            this.btnNameChange.Text = "OOO -> 본인이름 변경";
            this.btnNameChange.UseVisualStyleBackColor = true;
            this.btnNameChange.Click += new System.EventHandler(this.btnNameChange_Click);
            // 
            // btnswFound
            // 
            this.btnswFound.Location = new System.Drawing.Point(161, 78);
            this.btnswFound.Name = "btnswFound";
            this.btnswFound.Size = new System.Drawing.Size(130, 53);
            this.btnswFound.TabIndex = 1;
            this.btnswFound.Text = "s/w 위치 찾기";
            this.btnswFound.UseVisualStyleBackColor = true;
            this.btnswFound.Click += new System.EventHandler(this.btnswFound_Click);
            // 
            // btnKDT
            // 
            this.btnKDT.Location = new System.Drawing.Point(297, 78);
            this.btnKDT.Name = "btnKDT";
            this.btnKDT.Size = new System.Drawing.Size(130, 53);
            this.btnKDT.TabIndex = 1;
            this.btnKDT.Text = "앞,뒤\"-KDT-\"입력";
            this.btnKDT.UseVisualStyleBackColor = true;
            this.btnKDT.Click += new System.EventHandler(this.btnKDT_Click);
            // 
            // btnToLower
            // 
            this.btnToLower.Location = new System.Drawing.Point(25, 137);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(266, 53);
            this.btnToLower.TabIndex = 1;
            this.btnToLower.Text = "SMARTFACTORY 소문자로 변경하기";
            this.btnToLower.UseVisualStyleBackColor = true;
            this.btnToLower.Click += new System.EventHandler(this.btnToLower_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 53);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "모든 공백 없애기";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(433, 78);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(130, 53);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "되돌리기";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Chap08_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnKDT);
            this.Controls.Add(this.btnswFound);
            this.Controls.Add(this.btnToLower);
            this.Controls.Add(this.btnNameChange);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap08_Test";
            this.Text = "문자열 다루기 Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnNameChange;
        private Button btnswFound;
        private Button btnKDT;
        private Button btnToLower;
        private Button btnDelete;
        private Button btnReturn;
    }
}