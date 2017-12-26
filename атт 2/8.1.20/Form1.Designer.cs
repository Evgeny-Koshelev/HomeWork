namespace _8._1._20
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
            this.ListOneTextBox = new System.Windows.Forms.TextBox();
            this.ListTwoTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.Changebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListOneTextBox
            // 
            this.ListOneTextBox.Location = new System.Drawing.Point(58, 15);
            this.ListOneTextBox.Name = "ListOneTextBox";
            this.ListOneTextBox.Size = new System.Drawing.Size(311, 20);
            this.ListOneTextBox.TabIndex = 0;
            // 
            // ListTwoTextBox
            // 
            this.ListTwoTextBox.Location = new System.Drawing.Point(61, 61);
            this.ListTwoTextBox.Name = "ListTwoTextBox";
            this.ListTwoTextBox.Size = new System.Drawing.Size(307, 20);
            this.ListTwoTextBox.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(8, 241);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(416, 20);
            this.ResultTextBox.TabIndex = 2;
            // 
            // Changebutton
            // 
            this.Changebutton.Location = new System.Drawing.Point(60, 120);
            this.Changebutton.Name = "Changebutton";
            this.Changebutton.Size = new System.Drawing.Size(307, 67);
            this.Changebutton.TabIndex = 3;
            this.Changebutton.Text = "NewList";
            this.Changebutton.UseVisualStyleBackColor = true;
            this.Changebutton.Click += new System.EventHandler(this.Changebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 288);
            this.Controls.Add(this.Changebutton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ListTwoTextBox);
            this.Controls.Add(this.ListOneTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ListOneTextBox;
        private System.Windows.Forms.TextBox ListTwoTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button Changebutton;
    }
}

