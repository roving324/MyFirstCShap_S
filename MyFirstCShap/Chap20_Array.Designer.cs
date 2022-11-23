namespace MyFirstCShap
{
    partial class Chap20_Array
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
            this.btmArrayFunction = new System.Windows.Forms.Button();
            this.btnArrayCopy = new System.Windows.Forms.Button();
            this.btn2D = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btn2DShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmArrayFunction
            // 
            this.btmArrayFunction.Location = new System.Drawing.Point(12, 12);
            this.btmArrayFunction.Name = "btmArrayFunction";
            this.btmArrayFunction.Size = new System.Drawing.Size(173, 61);
            this.btmArrayFunction.TabIndex = 0;
            this.btmArrayFunction.Text = "ArrayFunction";
            this.btmArrayFunction.UseVisualStyleBackColor = true;
            this.btmArrayFunction.Click += new System.EventHandler(this.btmArrayFunction_Click);
            // 
            // btnArrayCopy
            // 
            this.btnArrayCopy.Location = new System.Drawing.Point(191, 12);
            this.btnArrayCopy.Name = "btnArrayCopy";
            this.btnArrayCopy.Size = new System.Drawing.Size(173, 61);
            this.btnArrayCopy.TabIndex = 0;
            this.btnArrayCopy.Text = "ArrayCopy";
            this.btnArrayCopy.UseVisualStyleBackColor = true;
            this.btnArrayCopy.Click += new System.EventHandler(this.btnArrayCopy_Click);
            // 
            // btn2D
            // 
            this.btn2D.Location = new System.Drawing.Point(370, 12);
            this.btn2D.Name = "btn2D";
            this.btn2D.Size = new System.Drawing.Size(173, 61);
            this.btn2D.TabIndex = 0;
            this.btn2D.Text = "2차원 배열";
            this.btn2D.UseVisualStyleBackColor = true;
            this.btn2D.Click += new System.EventHandler(this.btn2D_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(12, 79);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(570, 204);
            this.txtShow.TabIndex = 1;
            // 
            // btn2DShow
            // 
            this.btn2DShow.Location = new System.Drawing.Point(549, 12);
            this.btn2DShow.Name = "btn2DShow";
            this.btn2DShow.Size = new System.Drawing.Size(173, 61);
            this.btn2DShow.TabIndex = 0;
            this.btn2DShow.Text = "2차원 배열 표현";
            this.btn2DShow.UseVisualStyleBackColor = true;
            this.btn2DShow.Click += new System.EventHandler(this.btn2DShow_Click);
            // 
            // Chap20_Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btn2DShow);
            this.Controls.Add(this.btn2D);
            this.Controls.Add(this.btnArrayCopy);
            this.Controls.Add(this.btmArrayFunction);
            this.Name = "Chap20_Array";
            this.Text = "Chap20_Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btmArrayFunction;
        private Button btnArrayCopy;
        private Button btn2D;
        private TextBox txtShow;
        private Button btn2DShow;
    }
}