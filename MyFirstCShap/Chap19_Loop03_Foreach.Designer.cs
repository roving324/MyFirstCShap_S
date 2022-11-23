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
            this.btnArrayForeach = new System.Windows.Forms.Button();
            this.btnObjForeach = new System.Windows.Forms.Button();
            this.grbTextBoxInit = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObj1 = new System.Windows.Forms.TextBox();
            this.txtObj2 = new System.Windows.Forms.TextBox();
            this.txtObj3 = new System.Windows.Forms.TextBox();
            this.txtObj4 = new System.Windows.Forms.TextBox();
            this.grbTextBoxInit.SuspendLayout();
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
            this.txtstringForeach.Location = new System.Drawing.Point(168, 61);
            this.txtstringForeach.Name = "txtstringForeach";
            this.txtstringForeach.Size = new System.Drawing.Size(90, 23);
            this.txtstringForeach.TabIndex = 2;
            // 
            // btnArrayForeach
            // 
            this.btnArrayForeach.Location = new System.Drawing.Point(22, 111);
            this.btnArrayForeach.Name = "btnArrayForeach";
            this.btnArrayForeach.Size = new System.Drawing.Size(120, 67);
            this.btnArrayForeach.TabIndex = 0;
            this.btnArrayForeach.Text = "Array Foreach";
            this.btnArrayForeach.UseVisualStyleBackColor = true;
            this.btnArrayForeach.Click += new System.EventHandler(this.btnArrayForeach_Click);
            // 
            // btnObjForeach
            // 
            this.btnObjForeach.Location = new System.Drawing.Point(22, 184);
            this.btnObjForeach.Name = "btnObjForeach";
            this.btnObjForeach.Size = new System.Drawing.Size(120, 67);
            this.btnObjForeach.TabIndex = 0;
            this.btnObjForeach.Text = "Object Foreach";
            this.btnObjForeach.UseVisualStyleBackColor = true;
            this.btnObjForeach.Click += new System.EventHandler(this.btnObjForeach_Click);
            // 
            // grbTextBoxInit
            // 
            this.grbTextBoxInit.Controls.Add(this.txtObj4);
            this.grbTextBoxInit.Controls.Add(this.txtObj2);
            this.grbTextBoxInit.Controls.Add(this.txtObj3);
            this.grbTextBoxInit.Controls.Add(this.txtObj1);
            this.grbTextBoxInit.Controls.Add(this.label2);
            this.grbTextBoxInit.Location = new System.Drawing.Point(234, 167);
            this.grbTextBoxInit.Name = "grbTextBoxInit";
            this.grbTextBoxInit.Size = new System.Drawing.Size(440, 241);
            this.grbTextBoxInit.TabIndex = 3;
            this.grbTextBoxInit.TabStop = false;
            this.grbTextBoxInit.Text = "Text Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Foreach 로 텍스트박스 일괄 처리하기.";
            // 
            // txtObj1
            // 
            this.txtObj1.Location = new System.Drawing.Point(19, 70);
            this.txtObj1.Name = "txtObj1";
            this.txtObj1.Size = new System.Drawing.Size(249, 23);
            this.txtObj1.TabIndex = 1;
            // 
            // txtObj2
            // 
            this.txtObj2.Location = new System.Drawing.Point(19, 99);
            this.txtObj2.Name = "txtObj2";
            this.txtObj2.Size = new System.Drawing.Size(249, 23);
            this.txtObj2.TabIndex = 1;
            // 
            // txtObj3
            // 
            this.txtObj3.Location = new System.Drawing.Point(19, 128);
            this.txtObj3.Name = "txtObj3";
            this.txtObj3.Size = new System.Drawing.Size(249, 23);
            this.txtObj3.TabIndex = 1;
            // 
            // txtObj4
            // 
            this.txtObj4.Location = new System.Drawing.Point(19, 157);
            this.txtObj4.Name = "txtObj4";
            this.txtObj4.Size = new System.Drawing.Size(249, 23);
            this.txtObj4.TabIndex = 1;
            // 
            // Chap19_Loop03_Foreach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbTextBoxInit);
            this.Controls.Add(this.txtstringForeach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObjForeach);
            this.Controls.Add(this.btnArrayForeach);
            this.Controls.Add(this.btnstringForeach);
            this.Name = "Chap19_Loop03_Foreach";
            this.Text = "Foreach";
            this.grbTextBoxInit.ResumeLayout(false);
            this.grbTextBoxInit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnstringForeach;
        private Label label1;
        private TextBox txtstringForeach;
        private Button btnArrayForeach;
        private Button btnObjForeach;
        private GroupBox grbTextBoxInit;
        private TextBox txtObj4;
        private TextBox txtObj2;
        private TextBox txtObj3;
        private TextBox txtObj1;
        private Label label2;
    }
}