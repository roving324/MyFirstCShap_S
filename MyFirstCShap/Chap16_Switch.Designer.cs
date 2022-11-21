namespace MyFirstCShap
{
    partial class Chap16_Switch
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFruit = new System.Windows.Forms.TextBox();
            this.btnFruit = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "과일 이름";
            // 
            // txtFruit
            // 
            this.txtFruit.Location = new System.Drawing.Point(98, 28);
            this.txtFruit.Name = "txtFruit";
            this.txtFruit.Size = new System.Drawing.Size(199, 23);
            this.txtFruit.TabIndex = 1;
            // 
            // btnFruit
            // 
            this.btnFruit.Location = new System.Drawing.Point(98, 73);
            this.btnFruit.Name = "btnFruit";
            this.btnFruit.Size = new System.Drawing.Size(96, 46);
            this.btnFruit.TabIndex = 2;
            this.btnFruit.Text = "찾기(if)";
            this.btnFruit.UseVisualStyleBackColor = true;
            this.btnFruit.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(201, 73);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(96, 46);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "찾기(switch)";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // Chap16_Switch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnFruit);
            this.Controls.Add(this.txtFruit);
            this.Controls.Add(this.label1);
            this.Name = "Chap16_Switch";
            this.Text = "Switch 분기문";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFruit;
        private Button btnFruit;
        private Button btnSwitch;
    }
}