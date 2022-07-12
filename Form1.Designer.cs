namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userFileName = new System.Windows.Forms.TextBox();
            this.reviewFileName = new System.Windows.Forms.TextBox();
            this.userScanButton = new System.Windows.Forms.Button();
            this.reviewScanButton = new System.Windows.Forms.Button();
            this.createReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите файл с посетителями";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите файл с отзывами";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userFileName
            // 
            this.userFileName.Location = new System.Drawing.Point(359, 32);
            this.userFileName.Name = "userFileName";
            this.userFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userFileName.Size = new System.Drawing.Size(224, 22);
            this.userFileName.TabIndex = 2;
            // 
            // reviewFileName
            // 
            this.reviewFileName.Location = new System.Drawing.Point(359, 78);
            this.reviewFileName.Name = "reviewFileName";
            this.reviewFileName.Size = new System.Drawing.Size(224, 22);
            this.reviewFileName.TabIndex = 3;
            // 
            // userScanButton
            // 
            this.userScanButton.Location = new System.Drawing.Point(601, 30);
            this.userScanButton.Name = "userScanButton";
            this.userScanButton.Size = new System.Drawing.Size(119, 25);
            this.userScanButton.TabIndex = 4;
            this.userScanButton.Text = "Сканировать";
            this.userScanButton.UseVisualStyleBackColor = true;
            this.userScanButton.Click += new System.EventHandler(this.userScanButton_Click);
            // 
            // reviewScanButton
            // 
            this.reviewScanButton.Location = new System.Drawing.Point(601, 75);
            this.reviewScanButton.Name = "reviewScanButton";
            this.reviewScanButton.Size = new System.Drawing.Size(119, 25);
            this.reviewScanButton.TabIndex = 5;
            this.reviewScanButton.Text = "Сканировать";
            this.reviewScanButton.UseVisualStyleBackColor = true;
            this.reviewScanButton.Click += new System.EventHandler(this.reviewScanButton_Click);
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(26, 116);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(303, 23);
            this.createReportButton.TabIndex = 6;
            this.createReportButton.Text = "Создать отчет";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 573);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.reviewScanButton);
            this.Controls.Add(this.userScanButton);
            this.Controls.Add(this.reviewFileName);
            this.Controls.Add(this.userFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Агрегатор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userFileName;
        private System.Windows.Forms.TextBox reviewFileName;
        private System.Windows.Forms.Button userScanButton;
        private System.Windows.Forms.Button reviewScanButton;
        private System.Windows.Forms.Button createReportButton;
    }
}

