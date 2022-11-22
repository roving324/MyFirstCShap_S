namespace MyFirstCShap
{
    partial class Chap19_Loop03_Foreach
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
            this.btnstringForeach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstringForeach = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnstringForeach
            // 
            this.btnstringForeach.Location = new System.Drawing.Point(22, 38);
            this.btnstringForeach.Name = "btnstringForeach";
            this.btnstringForeach.Size = new System.Drawing.Size(120, 67);
            this.btnstringForeach.TabIndex = 0;
            this.btnstringForeach.Text = "string Foreach";
            this.btnstringForeach.UseVisualStyleBackColor = true;
            this.btnstringForeach.Click += new System.EventHandler(this.btnstringForeach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ABCDEFGHJKLMNOPQRST";
            // 
            // txtstringForeach
            // 
            this.txtstringForeach.Location = new System.Drawing.Point(168, 82);
            this.txtstringForeach.Name = "txtstringForeach";
            this.txtstringForeach.Size = new System.Drawing.Size(194, 23);
            this.txtstringForeach.TabIndex = 2;
            // 
            // Chap19_Loop03_Foreach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtstringForeach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstringForeach);
            this.Name = "Chap19_Loop03_Foreach";
            this.Text = "Foreach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnstringForeach;
        private Label label1;
        private TextBox txtstringForeach;
    }
}