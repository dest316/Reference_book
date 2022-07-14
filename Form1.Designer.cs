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
            this.addUserButton = new System.Windows.Forms.Button();
            this.addReviewButton = new System.Windows.Forms.Button();
            this.saveUsersButton = new System.Windows.Forms.Button();
            this.saveUsersTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveReviewsButton = new System.Windows.Forms.Button();
            this.saveReviewsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.debugButton = new System.Windows.Forms.Button();
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
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(26, 172);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(259, 23);
            this.addUserButton.TabIndex = 7;
            this.addUserButton.Text = "Изменить посетителей";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // addReviewButton
            // 
            this.addReviewButton.Location = new System.Drawing.Point(26, 201);
            this.addReviewButton.Name = "addReviewButton";
            this.addReviewButton.Size = new System.Drawing.Size(259, 23);
            this.addReviewButton.TabIndex = 8;
            this.addReviewButton.Text = "Изменить отзывы";
            this.addReviewButton.UseVisualStyleBackColor = true;
            this.addReviewButton.Click += new System.EventHandler(this.addReviewButton_Click);
            // 
            // saveUsersButton
            // 
            this.saveUsersButton.Location = new System.Drawing.Point(547, 430);
            this.saveUsersButton.Name = "saveUsersButton";
            this.saveUsersButton.Size = new System.Drawing.Size(130, 23);
            this.saveUsersButton.TabIndex = 9;
            this.saveUsersButton.Text = "Сохранить";
            this.saveUsersButton.UseVisualStyleBackColor = true;
            this.saveUsersButton.Click += new System.EventHandler(this.saveUsersButton_Click);
            // 
            // saveUsersTextBox
            // 
            this.saveUsersTextBox.Location = new System.Drawing.Point(320, 431);
            this.saveUsersTextBox.Name = "saveUsersTextBox";
            this.saveUsersTextBox.Size = new System.Drawing.Size(200, 22);
            this.saveUsersTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сохранить посетителей в ";
            // 
            // saveReviewsButton
            // 
            this.saveReviewsButton.Location = new System.Drawing.Point(547, 474);
            this.saveReviewsButton.Name = "saveReviewsButton";
            this.saveReviewsButton.Size = new System.Drawing.Size(130, 23);
            this.saveReviewsButton.TabIndex = 9;
            this.saveReviewsButton.Text = "Сохранить";
            this.saveReviewsButton.UseVisualStyleBackColor = true;
            this.saveReviewsButton.Click += new System.EventHandler(this.saveReviewsButton_Click);
            // 
            // saveReviewsTextBox
            // 
            this.saveReviewsTextBox.Location = new System.Drawing.Point(320, 475);
            this.saveReviewsTextBox.Name = "saveReviewsTextBox";
            this.saveReviewsTextBox.Size = new System.Drawing.Size(200, 22);
            this.saveReviewsTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сохранить отзывы в ";
            // 
            // debugButton
            // 
            this.debugButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.debugButton.ForeColor = System.Drawing.Color.Black;
            this.debugButton.Location = new System.Drawing.Point(772, 427);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(165, 69);
            this.debugButton.TabIndex = 12;
            this.debugButton.Text = "Режим отладки";
            this.debugButton.UseVisualStyleBackColor = false;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 573);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveReviewsTextBox);
            this.Controls.Add(this.saveUsersTextBox);
            this.Controls.Add(this.saveReviewsButton);
            this.Controls.Add(this.saveUsersButton);
            this.Controls.Add(this.addReviewButton);
            this.Controls.Add(this.addUserButton);
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
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button addReviewButton;
        private System.Windows.Forms.Button saveUsersButton;
        private System.Windows.Forms.TextBox saveUsersTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveReviewsButton;
        private System.Windows.Forms.TextBox saveReviewsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button debugButton;
    }
}

