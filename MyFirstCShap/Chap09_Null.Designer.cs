namespace MyFirstCShap
{
    partial class Chap09_Null
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
            this.btnHasValue = new System.Windows.Forms.Button();
            this.btnNullFlag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHasValue
            // 
            this.btnHasValue.Location = new System.Drawing.Point(28, 51);
            this.btnHasValue.Name = "btnHasValue";
            this.btnHasValue.Size = new System.Drawing.Size(148, 53);
            this.btnHasValue.TabIndex = 0;
            this.btnHasValue.Text = "HasValue";
            this.btnHasValue.UseVisualStyleBackColor = true;
            this.btnHasValue.Click += new System.EventHandler(this.btnHasValue_Click);
            // 
            // btnNullFlag
            // 
            this.btnNullFlag.Location = new System.Drawing.Point(211, 51);
            this.btnNullFlag.Name = "btnNullFlag";
            this.btnNullFlag.Size = new System.Drawing.Size(148, 53);
            this.btnNullFlag.TabIndex = 0;
            this.btnNullFlag.Text = "Null 의 판단";
            this.btnNullFlag.UseVisualStyleBackColor = true;
            this.btnNullFlag.Click += new System.EventHandler(this.btnNullFlag_Click);
            // 
            // Chap09_Null
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 158);
            this.Controls.Add(this.btnNullFlag);
            this.Controls.Add(this.btnHasValue);
            this.Name = "Chap09_Null";
            this.Text = "Null 다루기";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHasValue;
        private Button btnNullFlag;
    }
}