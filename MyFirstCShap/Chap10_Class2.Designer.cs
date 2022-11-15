namespace MyFirstCSharp
{
    partial class Chap10_Class2
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
            this.btnClassInstance = new System.Windows.Forms.Button();
            this.btnClassInstance2 = new System.Windows.Forms.Button();
            this.btnMethodCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClassInstance
            // 
            this.btnClassInstance.Location = new System.Drawing.Point(86, 59);
            this.btnClassInstance.Name = "btnClassInstance";
            this.btnClassInstance.Size = new System.Drawing.Size(191, 51);
            this.btnClassInstance.TabIndex = 0;
            this.btnClassInstance.Text = "Class 객체 생성 및 호출";
            this.btnClassInstance.UseVisualStyleBackColor = true;
            this.btnClassInstance.Click += new System.EventHandler(this.btnClassInstance_Click);
            // 
            // btnClassInstance2
            // 
            this.btnClassInstance2.Location = new System.Drawing.Point(86, 116);
            this.btnClassInstance2.Name = "btnClassInstance2";
            this.btnClassInstance2.Size = new System.Drawing.Size(191, 51);
            this.btnClassInstance2.TabIndex = 0;
            this.btnClassInstance2.Text = "클래스 생성 및 호출2";
            this.btnClassInstance2.UseVisualStyleBackColor = true;
            this.btnClassInstance2.Click += new System.EventHandler(this.btnClassInstance2_Click);
            // 
            // btnMethodCall
            // 
            this.btnMethodCall.Location = new System.Drawing.Point(86, 173);
            this.btnMethodCall.Name = "btnMethodCall";
            this.btnMethodCall.Size = new System.Drawing.Size(191, 51);
            this.btnMethodCall.TabIndex = 0;
            this.btnMethodCall.Text = "다른 클래스 매서드 호출하기";
            this.btnMethodCall.UseVisualStyleBackColor = true;
            this.btnMethodCall.Click += new System.EventHandler(this.btnMethodCall_Click);
            // 
            // Chap10_Class2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.btnMethodCall);
            this.Controls.Add(this.btnClassInstance2);
            this.Controls.Add(this.btnClassInstance);
            this.Name = "Chap10_Class2";
            this.Text = "Class";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClassInstance;
        private Button btnClassInstance2;
        private Button btnMethodCall;
    }
}