namespace MyFirstCShap
{
    partial class Chap25_Exception_TryCatch
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
            this.btnException = new System.Windows.Forms.Button();
            this.btnTryCatch = new System.Windows.Forms.Button();
            this.btnMethodTryCatch = new System.Windows.Forms.Button();
            this.btnExceptionList = new System.Windows.Forms.Button();
            this.btnFinarry = new System.Windows.Forms.Button();
            this.btnThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnException
            // 
            this.btnException.Location = new System.Drawing.Point(25, 35);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(151, 65);
            this.btnException.TabIndex = 0;
            this.btnException.Text = "시스템 오류 발생";
            this.btnException.UseVisualStyleBackColor = true;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // btnTryCatch
            // 
            this.btnTryCatch.Location = new System.Drawing.Point(182, 35);
            this.btnTryCatch.Name = "btnTryCatch";
            this.btnTryCatch.Size = new System.Drawing.Size(151, 65);
            this.btnTryCatch.TabIndex = 0;
            this.btnTryCatch.Text = "예외 처리";
            this.btnTryCatch.UseVisualStyleBackColor = true;
            this.btnTryCatch.Click += new System.EventHandler(this.btnTryCatch_Click);
            // 
            // btnMethodTryCatch
            // 
            this.btnMethodTryCatch.Location = new System.Drawing.Point(339, 35);
            this.btnMethodTryCatch.Name = "btnMethodTryCatch";
            this.btnMethodTryCatch.Size = new System.Drawing.Size(151, 65);
            this.btnMethodTryCatch.TabIndex = 0;
            this.btnMethodTryCatch.Text = "메서드 내의 예외처리";
            this.btnMethodTryCatch.UseVisualStyleBackColor = true;
            this.btnMethodTryCatch.Click += new System.EventHandler(this.btnMethodTryCatch_Click);
            // 
            // btnExceptionList
            // 
            this.btnExceptionList.Location = new System.Drawing.Point(25, 106);
            this.btnExceptionList.Name = "btnExceptionList";
            this.btnExceptionList.Size = new System.Drawing.Size(151, 65);
            this.btnExceptionList.TabIndex = 0;
            this.btnExceptionList.Text = "Exception";
            this.btnExceptionList.UseVisualStyleBackColor = true;
            this.btnExceptionList.Click += new System.EventHandler(this.btnExceptionList_Click);
            // 
            // btnFinarry
            // 
            this.btnFinarry.Location = new System.Drawing.Point(182, 106);
            this.btnFinarry.Name = "btnFinarry";
            this.btnFinarry.Size = new System.Drawing.Size(151, 65);
            this.btnFinarry.TabIndex = 0;
            this.btnFinarry.Text = "Finarry";
            this.btnFinarry.UseVisualStyleBackColor = true;
            this.btnFinarry.Click += new System.EventHandler(this.btnFinarry_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(339, 106);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(151, 65);
            this.btnThrow.TabIndex = 0;
            this.btnThrow.Text = "Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // Chap25_Exception_TryCatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnFinarry);
            this.Controls.Add(this.btnExceptionList);
            this.Controls.Add(this.btnMethodTryCatch);
            this.Controls.Add(this.btnTryCatch);
            this.Controls.Add(this.btnException);
            this.Name = "Chap25_Exception_TryCatch";
            this.Text = "예외 처리";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnException;
        private Button btnTryCatch;
        private Button btnMethodTryCatch;
        private Button btnExceptionList;
        private Button btnFinarry;
        private Button btnThrow;
    }
}