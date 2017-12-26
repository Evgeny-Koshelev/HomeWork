namespace _7._1._20
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreatNewString = new System.Windows.Forms.Button();
            this.FirstBox = new System.Windows.Forms.TextBox();
            this.OuttextBox = new System.Windows.Forms.TextBox();
            this.Long = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreatNewString
            // 
            this.CreatNewString.Location = new System.Drawing.Point(304, 102);
            this.CreatNewString.Name = "CreatNewString";
            this.CreatNewString.Size = new System.Drawing.Size(256, 66);
            this.CreatNewString.TabIndex = 0;
            this.CreatNewString.Text = "CreatNewString";
            this.CreatNewString.UseVisualStyleBackColor = true;
            this.CreatNewString.Click += new System.EventHandler(this.CreatNewString_Click);
            // 
            // FirstBox
            // 
            this.FirstBox.Location = new System.Drawing.Point(85, 13);
            this.FirstBox.Name = "FirstBox";
            this.FirstBox.Size = new System.Drawing.Size(526, 20);
            this.FirstBox.TabIndex = 1;
            // 
            // OuttextBox
            // 
            this.OuttextBox.Location = new System.Drawing.Point(85, 203);
            this.OuttextBox.Name = "OuttextBox";
            this.OuttextBox.Size = new System.Drawing.Size(526, 20);
            this.OuttextBox.TabIndex = 2;
            // 
            // Long
            // 
            this.Long.Location = new System.Drawing.Point(85, 102);
            this.Long.Name = "Long";
            this.Long.Size = new System.Drawing.Size(110, 20);
            this.Long.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 261);
            this.Controls.Add(this.Long);
            this.Controls.Add(this.OuttextBox);
            this.Controls.Add(this.FirstBox);
            this.Controls.Add(this.CreatNewString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatNewString;
        private System.Windows.Forms.TextBox FirstBox;
        private System.Windows.Forms.TextBox OuttextBox;
        private System.Windows.Forms.TextBox Long;
    }
}

