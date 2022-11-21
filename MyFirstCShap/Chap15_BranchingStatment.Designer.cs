namespace MyFirstCShap
{
    partial class Chap15_BranchingStatment
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnIF = new System.Windows.Forms.Button();
            this.btnInIF = new System.Windows.Forms.Button();
            this.btnAndIF = new System.Windows.Forms.Button();
            this.btnOrIF = new System.Windows.Forms.Button();
            this.btnBoolIf = new System.Windows.Forms.Button();
            this.btnP_MFlag = new System.Windows.Forms.Button();
            this.btnH_JTest = new System.Windows.Forms.Button();
            this.btnTernaryOperator = new System.Windows.Forms.Button();
            this.btnElseIF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(17, 26);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(197, 23);
            this.txtInput.TabIndex = 0;
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(17, 55);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(80, 43);
            this.btnIF.TabIndex = 1;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // btnInIF
            // 
            this.btnInIF.Location = new System.Drawing.Point(103, 55);
            this.btnInIF.Name = "btnInIF";
            this.btnInIF.Size = new System.Drawing.Size(80, 43);
            this.btnInIF.TabIndex = 1;
            this.btnInIF.Text = "in IF";
            this.btnInIF.UseVisualStyleBackColor = true;
            this.btnInIF.Click += new System.EventHandler(this.btnInIF_Click);
            // 
            // btnAndIF
            // 
            this.btnAndIF.Location = new System.Drawing.Point(17, 104);
            this.btnAndIF.Name = "btnAndIF";
            this.btnAndIF.Size = new System.Drawing.Size(80, 43);
            this.btnAndIF.TabIndex = 1;
            this.btnAndIF.Text = "And IF";
            this.btnAndIF.UseVisualStyleBackColor = true;
            this.btnAndIF.Click += new System.EventHandler(this.btnAndIF_Click);
            // 
            // btnOrIF
            // 
            this.btnOrIF.Location = new System.Drawing.Point(103, 104);
            this.btnOrIF.Name = "btnOrIF";
            this.btnOrIF.Size = new System.Drawing.Size(80, 43);
            this.btnOrIF.TabIndex = 1;
            this.btnOrIF.Text = "Or IF";
            this.btnOrIF.UseVisualStyleBackColor = true;
            this.btnOrIF.Click += new System.EventHandler(this.btnOrIF_Click);
            // 
            // btnBoolIf
            // 
            this.btnBoolIf.Location = new System.Drawing.Point(189, 104);
            this.btnBoolIf.Name = "btnBoolIf";
            this.btnBoolIf.Size = new System.Drawing.Size(80, 43);
            this.btnBoolIf.TabIndex = 1;
            this.btnBoolIf.Text = "Bool If";
            this.btnBoolIf.UseVisualStyleBackColor = true;
            this.btnBoolIf.Click += new System.EventHandler(this.btnBoolIf_Click);
            // 
            // btnP_MFlag
            // 
            this.btnP_MFlag.Location = new System.Drawing.Point(17, 153);
            this.btnP_MFlag.Name = "btnP_MFlag";
            this.btnP_MFlag.Size = new System.Drawing.Size(80, 43);
            this.btnP_MFlag.TabIndex = 1;
            this.btnP_MFlag.Text = "음수/양수 Test";
            this.btnP_MFlag.UseVisualStyleBackColor = true;
            this.btnP_MFlag.Click += new System.EventHandler(this.btnP_MFlag_Click);
            // 
            // btnH_JTest
            // 
            this.btnH_JTest.Location = new System.Drawing.Point(103, 153);
            this.btnH_JTest.Name = "btnH_JTest";
            this.btnH_JTest.Size = new System.Drawing.Size(80, 43);
            this.btnH_JTest.TabIndex = 1;
            this.btnH_JTest.Text = "홀수/짝수 Test";
            this.btnH_JTest.UseVisualStyleBackColor = true;
            this.btnH_JTest.Click += new System.EventHandler(this.btnH_JTest_Click);
            // 
            // btnTernaryOperator
            // 
            this.btnTernaryOperator.Location = new System.Drawing.Point(189, 153);
            this.btnTernaryOperator.Name = "btnTernaryOperator";
            this.btnTernaryOperator.Size = new System.Drawing.Size(80, 43);
            this.btnTernaryOperator.TabIndex = 1;
            this.btnTernaryOperator.Text = "삼항연산자";
            this.btnTernaryOperator.UseVisualStyleBackColor = true;
            this.btnTernaryOperator.Click += new System.EventHandler(this.btnTernaryOperator_Click);
            // 
            // btnElseIF
            // 
            this.btnElseIF.Location = new System.Drawing.Point(189, 55);
            this.btnElseIF.Name = "btnElseIF";
            this.btnElseIF.Size = new System.Drawing.Size(80, 43);
            this.btnElseIF.TabIndex = 1;
            this.btnElseIF.Text = "Else IF";
            this.btnElseIF.UseVisualStyleBackColor = true;
            this.btnElseIF.Click += new System.EventHandler(this.btnElseIF_Click);
            // 
            // Chap15_BranchingStatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTernaryOperator);
            this.Controls.Add(this.btnH_JTest);
            this.Controls.Add(this.btnP_MFlag);
            this.Controls.Add(this.btnBoolIf);
            this.Controls.Add(this.btnOrIF);
            this.Controls.Add(this.btnAndIF);
            this.Controls.Add(this.btnElseIF);
            this.Controls.Add(this.btnInIF);
            this.Controls.Add(this.btnIF);
            this.Controls.Add(this.txtInput);
            this.Name = "Chap15_BranchingStatment";
            this.Text = "분기문";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput;
        private Button btnIF;
        private Button btnInIF;
        private Button btnAndIF;
        private Button btnOrIF;
        private Button btnBoolIf;
        private Button btnP_MFlag;
        private Button btnH_JTest;
        private Button btnTernaryOperator;
        private Button btnElseIF;
    }
}