namespace MyFirstCShap
{
    partial class Chap14_Method
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMethodCall = new System.Windows.Forms.Button();
            this.btnArg_Par = new System.Windows.Forms.Button();
            this.btnVoidReturn = new System.Windows.Forms.Button();
            this.btnStringReturn = new System.Windows.Forms.Button();
            this.btnIntReturn = new System.Windows.Forms.Button();
            this.btnDefaultReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCatch2 = new System.Windows.Forms.Button();
            this.btnCatch1 = new System.Windows.Forms.Button();
            this.btnArrayArg = new System.Windows.Forms.Button();
            this.btnArrayReturn = new System.Windows.Forms.Button();
            this.btnClassMCall = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(255, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            // 
            // btnMethodCall
            // 
            this.btnMethodCall.Location = new System.Drawing.Point(12, 56);
            this.btnMethodCall.Name = "btnMethodCall";
            this.btnMethodCall.Size = new System.Drawing.Size(81, 45);
            this.btnMethodCall.TabIndex = 2;
            this.btnMethodCall.Text = "함수 호출";
            this.btnMethodCall.UseVisualStyleBackColor = true;
            this.btnMethodCall.Click += new System.EventHandler(this.btnMethodCall_Click);
            // 
            // btnArg_Par
            // 
            this.btnArg_Par.Location = new System.Drawing.Point(99, 56);
            this.btnArg_Par.Name = "btnArg_Par";
            this.btnArg_Par.Size = new System.Drawing.Size(81, 45);
            this.btnArg_Par.TabIndex = 2;
            this.btnArg_Par.Text = "인수 인자";
            this.btnArg_Par.UseVisualStyleBackColor = true;
            this.btnArg_Par.Click += new System.EventHandler(this.btnArg_Par_Click);
            // 
            // btnVoidReturn
            // 
            this.btnVoidReturn.Location = new System.Drawing.Point(12, 107);
            this.btnVoidReturn.Name = "btnVoidReturn";
            this.btnVoidReturn.Size = new System.Drawing.Size(81, 45);
            this.btnVoidReturn.TabIndex = 2;
            this.btnVoidReturn.Text = "Void Return";
            this.btnVoidReturn.UseVisualStyleBackColor = true;
            this.btnVoidReturn.Click += new System.EventHandler(this.btnVoidReturn_Click);
            // 
            // btnStringReturn
            // 
            this.btnStringReturn.Location = new System.Drawing.Point(99, 107);
            this.btnStringReturn.Name = "btnStringReturn";
            this.btnStringReturn.Size = new System.Drawing.Size(81, 45);
            this.btnStringReturn.TabIndex = 2;
            this.btnStringReturn.Text = "String Return";
            this.btnStringReturn.UseVisualStyleBackColor = true;
            this.btnStringReturn.Click += new System.EventHandler(this.btnStringReturn_Click);
            // 
            // btnIntReturn
            // 
            this.btnIntReturn.Location = new System.Drawing.Point(186, 107);
            this.btnIntReturn.Name = "btnIntReturn";
            this.btnIntReturn.Size = new System.Drawing.Size(81, 45);
            this.btnIntReturn.TabIndex = 2;
            this.btnIntReturn.Text = "Int Return";
            this.btnIntReturn.UseVisualStyleBackColor = true;
            this.btnIntReturn.Click += new System.EventHandler(this.btnIntReturn_Click);
            // 
            // btnDefaultReturn
            // 
            this.btnDefaultReturn.Location = new System.Drawing.Point(268, 107);
            this.btnDefaultReturn.Name = "btnDefaultReturn";
            this.btnDefaultReturn.Size = new System.Drawing.Size(119, 45);
            this.btnDefaultReturn.TabIndex = 2;
            this.btnDefaultReturn.Text = "Default Return";
            this.btnDefaultReturn.UseVisualStyleBackColor = true;
            this.btnDefaultReturn.Click += new System.EventHandler(this.btnDefaultReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCatch2);
            this.groupBox1.Controls.Add(this.btnCatch1);
            this.groupBox1.Location = new System.Drawing.Point(17, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "술래잡기";
            // 
            // btnCatch2
            // 
            this.btnCatch2.Location = new System.Drawing.Point(169, 37);
            this.btnCatch2.Name = "btnCatch2";
            this.btnCatch2.Size = new System.Drawing.Size(195, 32);
            this.btnCatch2.TabIndex = 0;
            this.btnCatch2.UseVisualStyleBackColor = true;
            this.btnCatch2.Click += new System.EventHandler(this.btnCatch2_Click);
            // 
            // btnCatch1
            // 
            this.btnCatch1.Location = new System.Drawing.Point(6, 37);
            this.btnCatch1.Name = "btnCatch1";
            this.btnCatch1.Size = new System.Drawing.Size(157, 32);
            this.btnCatch1.TabIndex = 0;
            this.btnCatch1.Text = "나 잡아 봐라~~";
            this.btnCatch1.UseVisualStyleBackColor = true;
            this.btnCatch1.Click += new System.EventHandler(this.btnCatch1_Click);
            // 
            // btnArrayArg
            // 
            this.btnArrayArg.Location = new System.Drawing.Point(17, 282);
            this.btnArrayArg.Name = "btnArrayArg";
            this.btnArrayArg.Size = new System.Drawing.Size(119, 45);
            this.btnArrayArg.TabIndex = 2;
            this.btnArrayArg.Text = "Array Argument";
            this.btnArrayArg.UseVisualStyleBackColor = true;
            this.btnArrayArg.Click += new System.EventHandler(this.btnArrayArg_Click);
            // 
            // btnArrayReturn
            // 
            this.btnArrayReturn.Location = new System.Drawing.Point(142, 282);
            this.btnArrayReturn.Name = "btnArrayReturn";
            this.btnArrayReturn.Size = new System.Drawing.Size(119, 45);
            this.btnArrayReturn.TabIndex = 2;
            this.btnArrayReturn.Text = "Array Return";
            this.btnArrayReturn.UseVisualStyleBackColor = true;
            this.btnArrayReturn.Click += new System.EventHandler(this.btnArrayReturn_Click);
            // 
            // btnClassMCall
            // 
            this.btnClassMCall.Location = new System.Drawing.Point(267, 282);
            this.btnClassMCall.Name = "btnClassMCall";
            this.btnClassMCall.Size = new System.Drawing.Size(119, 45);
            this.btnClassMCall.TabIndex = 2;
            this.btnClassMCall.Text = "Class Method Call";
            this.btnClassMCall.UseVisualStyleBackColor = true;
            this.btnClassMCall.Click += new System.EventHandler(this.btnClassMCall_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(17, 333);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(119, 45);
            this.btnRef.TabIndex = 2;
            this.btnRef.Text = "ref";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(142, 333);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(119, 45);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Chap14_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoidReturn);
            this.Controls.Add(this.btnArg_Par);
            this.Controls.Add(this.btnClassMCall);
            this.Controls.Add(this.btnArrayReturn);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnArrayArg);
            this.Controls.Add(this.btnDefaultReturn);
            this.Controls.Add(this.btnIntReturn);
            this.Controls.Add(this.btnStringReturn);
            this.Controls.Add(this.btnMethodCall);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Name = "Chap14_Method";
            this.Text = "메서드를 공부합시다.";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTitle;
        private Label lblTitle;
        private Button btnMethodCall;
        private Button btnArg_Par;
        private Button btnVoidReturn;
        private Button btnStringReturn;
        private Button btnIntReturn;
        private Button btnDefaultReturn;
        private GroupBox groupBox1;
        private Button btnCatch2;
        private Button btnCatch1;
        private Button btnArrayArg;
        private Button btnArrayReturn;
        private Button btnClassMCall;
        private Button btnRef;
        private Button btnOut;
    }
}