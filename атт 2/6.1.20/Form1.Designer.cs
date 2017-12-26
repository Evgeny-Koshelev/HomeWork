namespace _6._1._20
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
            this.Changebutton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutTextBox = new System.Windows.Forms.TextBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Changebutton
            // 
            this.Changebutton.Location = new System.Drawing.Point(218, 112);
            this.Changebutton.Name = "Changebutton";
            this.Changebutton.Size = new System.Drawing.Size(299, 28);
            this.Changebutton.TabIndex = 0;
            this.Changebutton.Text = "Заменить + на -  ";
            this.Changebutton.UseVisualStyleBackColor = true;
            this.Changebutton.Click += new System.EventHandler(this.Changebutton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(87, 13);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(562, 20);
            this.InputTextBox.TabIndex = 1;
            // 
            // OutTextBox
            // 
            this.OutTextBox.Location = new System.Drawing.Point(87, 204);
            this.OutTextBox.Name = "OutTextBox";
            this.OutTextBox.Size = new System.Drawing.Size(562, 20);
            this.OutTextBox.TabIndex = 2;
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(87, 239);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(100, 20);
            this.CountBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "введите символы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "вывод";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "счетчик";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(700, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.OutTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.Changebutton);
            this.Name = "Form1";
            this.Text = "6.1.20";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Changebutton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutTextBox;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

