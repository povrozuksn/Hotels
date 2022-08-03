namespace Booking
{
    partial class MainForm
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
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.HotelsPanel = new System.Windows.Forms.Panel();
            this.FiltrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.Controls.Add(this.button1);
            this.FiltrPanel.Controls.Add(this.dateTimePicker2);
            this.FiltrPanel.Controls.Add(this.label3);
            this.FiltrPanel.Controls.Add(this.FiltrButton);
            this.FiltrPanel.Controls.Add(this.dateTimePicker1);
            this.FiltrPanel.Controls.Add(this.label2);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Controls.Add(this.comboBox1);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 0);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(750, 120);
            this.FiltrPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(586, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(396, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(176, 26);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(392, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата выезда";
            // 
            // FiltrButton
            // 
            this.FiltrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiltrButton.Location = new System.Drawing.Point(0, 0);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(113, 29);
            this.FiltrButton.TabIndex = 4;
            this.FiltrButton.Text = "Фильтр";
            this.FiltrButton.UseVisualStyleBackColor = true;
            this.FiltrButton.Click += new System.EventHandler(this.FiltrButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(195, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата заезда";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите город";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // HotelsPanel
            // 
            this.HotelsPanel.AutoScroll = true;
            this.HotelsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelsPanel.Location = new System.Drawing.Point(0, 120);
            this.HotelsPanel.Name = "HotelsPanel";
            this.HotelsPanel.Size = new System.Drawing.Size(750, 355);
            this.HotelsPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 475);
            this.Controls.Add(this.HotelsPanel);
            this.Controls.Add(this.FiltrPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel HotelsPanel;
    }
}

