namespace MyFirstCShap
{
    partial class Chap18_Loop02_While
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnWhileNonExit = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWhile.Location = new System.Drawing.Point(38, 44);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(159, 124);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnWhileNonExit
            // 
            this.btnWhileNonExit.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWhileNonExit.Location = new System.Drawing.Point(203, 44);
            this.btnWhileNonExit.Name = "btnWhileNonExit";
            this.btnWhileNonExit.Size = new System.Drawing.Size(159, 124);
            this.btnWhileNonExit.TabIndex = 0;
            this.btnWhileNonExit.Text = "무한 루프";
            this.btnWhileNonExit.UseVisualStyleBackColor = true;
            this.btnWhileNonExit.Click += new System.EventHandler(this.btnWhileNonExit_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDoWhile.Location = new System.Drawing.Point(368, 44);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(159, 124);
            this.btnDoWhile.TabIndex = 0;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // Chap18_Loop02_While
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 215);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhileNonExit);
            this.Controls.Add(this.btnWhile);
            this.Name = "Chap18_Loop02_While";
            this.Text = "Chap18_Loop02_While";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnWhile;
        private Button btnWhileNonExit;
        private Button btnDoWhile;
    }
}