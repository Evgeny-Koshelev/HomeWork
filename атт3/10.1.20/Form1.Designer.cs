namespace _10._1._20
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.countPlaceTextBox = new System.Windows.Forms.TextBox();
            this.abiturDataGridView = new System.Windows.Forms.DataGridView();
            this.Fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Russky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mathem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Physic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Original = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abiturDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // ansTextBox
            // 
            this.ansTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ansTextBox.Location = new System.Drawing.Point(539, 101);
            this.ansTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ansTextBox.Multiline = true;
            this.ansTextBox.Name = "ansTextBox";
            this.ansTextBox.Size = new System.Drawing.Size(374, 233);
            this.ansTextBox.TabIndex = 7;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(643, 73);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(192, 24);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Отобрать студентов";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество бюджетных мест";
            // 
            // countPlaceTextBox
            // 
            this.countPlaceTextBox.Location = new System.Drawing.Point(720, 42);
            this.countPlaceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.countPlaceTextBox.Name = "countPlaceTextBox";
            this.countPlaceTextBox.Size = new System.Drawing.Size(29, 20);
            this.countPlaceTextBox.TabIndex = 10;
            this.countPlaceTextBox.Text = "10";
            // 
            // abiturDataGridView
            // 
            this.abiturDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abiturDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fio,
            this.Russky,
            this.Mathem,
            this.Physic,
            this.Original});
            this.abiturDataGridView.Location = new System.Drawing.Point(0, 26);
            this.abiturDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.abiturDataGridView.Name = "abiturDataGridView";
            this.abiturDataGridView.RowTemplate.Height = 28;
            this.abiturDataGridView.Size = new System.Drawing.Size(534, 276);
            this.abiturDataGridView.TabIndex = 11;
            // 
            // Fio
            // 
            this.Fio.HeaderText = "ФИО";
            this.Fio.Name = "Fio";
            // 
            // Russky
            // 
            this.Russky.HeaderText = "Русский язык";
            this.Russky.Name = "Russky";
            // 
            // Mathem
            // 
            this.Mathem.HeaderText = "Математика";
            this.Mathem.Name = "Mathem";
            // 
            // Physic
            // 
            this.Physic.HeaderText = "Физика";
            this.Physic.Name = "Physic";
            // 
            // Original
            // 
            this.Original.HeaderText = "Оригинал";
            this.Original.Name = "Original";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 325);
            this.Controls.Add(this.abiturDataGridView);
            this.Controls.Add(this.countPlaceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.ansTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abiturDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox ansTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countPlaceTextBox;
        private System.Windows.Forms.DataGridView abiturDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Russky;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Physic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Original;
    }
}

