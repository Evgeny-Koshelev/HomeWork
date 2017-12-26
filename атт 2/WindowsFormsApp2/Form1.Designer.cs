namespace WindowsFormsApp2
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
            this.arrayInputTB = new System.Windows.Forms.TextBox();
            this.solutionButton = new System.Windows.Forms.Button();
            this.firstIndexTB = new System.Windows.Forms.TextBox();
            this.legtnTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // arrayInputTB
            // 
            this.arrayInputTB.Location = new System.Drawing.Point(12, 12);
            this.arrayInputTB.Multiline = true;
            this.arrayInputTB.Name = "arrayInputTB";
            this.arrayInputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.arrayInputTB.Size = new System.Drawing.Size(58, 216);
            this.arrayInputTB.TabIndex = 0;
            this.arrayInputTB.Text = "1,\r\n2,\r\n-2,\r\n1,\r\n10,\r\n3,\r\n105,\r\n4,\r\n-5,\r\n4,\r\n10,\r\n1,\r\n1,\r\n3,\r\n4,\r\n7,\r\n12,\r\n10\t";
            // 
            // solutionButton
            // 
            this.solutionButton.Location = new System.Drawing.Point(172, 187);
            this.solutionButton.Name = "solutionButton";
            this.solutionButton.Size = new System.Drawing.Size(100, 41);
            this.solutionButton.TabIndex = 1;
            this.solutionButton.Text = "Find subsequence";
            this.solutionButton.UseVisualStyleBackColor = true;
            this.solutionButton.Click += new System.EventHandler(this.solutionButton_Click);
            // 
            // firstIndexTB
            // 
            this.firstIndexTB.Location = new System.Drawing.Point(172, 35);
            this.firstIndexTB.Name = "firstIndexTB";
            this.firstIndexTB.Size = new System.Drawing.Size(100, 20);
            this.firstIndexTB.TabIndex = 2;
            // 
            // legtnTB
            // 
            this.legtnTB.Location = new System.Drawing.Point(172, 78);
            this.legtnTB.Name = "legtnTB";
            this.legtnTB.Size = new System.Drawing.Size(100, 20);
            this.legtnTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "First index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(169, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Length";
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(76, 12);
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTB.Size = new System.Drawing.Size(58, 216);
            this.outputTB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 240);
            this.Controls.Add(this.outputTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.legtnTB);
            this.Controls.Add(this.firstIndexTB);
            this.Controls.Add(this.solutionButton);
            this.Controls.Add(this.arrayInputTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrayInputTB;
        private System.Windows.Forms.Button solutionButton;
        private System.Windows.Forms.TextBox firstIndexTB;
        private System.Windows.Forms.TextBox legtnTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputTB;
    }
}

