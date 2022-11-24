namespace MyFirstCShap
{
    partial class Chap21_Collection
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
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnHashTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(12, 12);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(142, 60);
            this.btnArrayList.TabIndex = 0;
            this.btnArrayList.Text = "ArrayList";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(160, 12);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(142, 60);
            this.btnQueue.TabIndex = 0;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(308, 12);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(142, 60);
            this.btnStack.TabIndex = 0;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Location = new System.Drawing.Point(12, 78);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(142, 60);
            this.btnDictionary.TabIndex = 0;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnHashTable
            // 
            this.btnHashTable.Location = new System.Drawing.Point(160, 78);
            this.btnHashTable.Name = "btnHashTable";
            this.btnHashTable.Size = new System.Drawing.Size(142, 60);
            this.btnHashTable.TabIndex = 0;
            this.btnHashTable.Text = "HashTable";
            this.btnHashTable.UseVisualStyleBackColor = true;
            this.btnHashTable.Click += new System.EventHandler(this.btnHashTable_Click);
            // 
            // Chap21_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 224);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnHashTable);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnArrayList);
            this.Name = "Chap21_Collection";
            this.Text = "컬렉션";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnArrayList;
        private Button btnQueue;
        private Button btnStack;
        private Button btnDictionary;
        private Button btnHashTable;
    }
}