namespace MyFirstCShap
{
    partial class Chap03_DataTypeChang
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
            this.btnChangStoI = new System.Windows.Forms.Button();
            this.btnChangeStoI = new System.Windows.Forms.Button();
            this.btnNull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangStoI
            // 
            this.btnChangStoI.Location = new System.Drawing.Point(30, 23);
            this.btnChangStoI.Name = "btnChangStoI";
            this.btnChangStoI.Size = new System.Drawing.Size(175, 98);
            this.btnChangStoI.TabIndex = 0;
            this.btnChangStoI.Text = "숫자 -> 문자";
            this.btnChangStoI.UseVisualStyleBackColor = true;
            this.btnChangStoI.Click += new System.EventHandler(this.btnChangStoI_Click);
            // 
            // btnChangeStoI
            // 
            this.btnChangeStoI.Location = new System.Drawing.Point(211, 23);
            this.btnChangeStoI.Name = "btnChangeStoI";
            this.btnChangeStoI.Size = new System.Drawing.Size(175, 98);
            this.btnChangeStoI.TabIndex = 1;
            this.btnChangeStoI.Text = "문자 -> 숫자";
            this.btnChangeStoI.UseVisualStyleBackColor = true;
            this.btnChangeStoI.Click += new System.EventHandler(this.btnChangeStoI_Click);
            // 
            // btnNull
            // 
            this.btnNull.Location = new System.Drawing.Point(30, 127);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(175, 98);
            this.btnNull.TabIndex = 0;
            this.btnNull.Text = "NULL 변환 처리";
            this.btnNull.UseVisualStyleBackColor = true;
            this.btnNull.Click += new System.EventHandler(this.btnNull_Click);
            // 
            // Chap03_DataTypeChang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeStoI);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.btnChangStoI);
            this.Name = "Chap03_DataTypeChang";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnChangStoI;
        private Button btnChangeStoI;
        private Button btnNull;
    }
}