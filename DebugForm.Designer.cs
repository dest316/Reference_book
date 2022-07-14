namespace WindowsFormsApp1
{
    partial class DebugForm
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
            this.printTreeButton = new System.Windows.Forms.Button();
            this.printHashtableButton = new System.Windows.Forms.Button();
            this.debugTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // printTreeButton
            // 
            this.printTreeButton.Location = new System.Drawing.Point(68, 31);
            this.printTreeButton.Name = "printTreeButton";
            this.printTreeButton.Size = new System.Drawing.Size(182, 23);
            this.printTreeButton.TabIndex = 0;
            this.printTreeButton.Text = "Вывести дерево";
            this.printTreeButton.UseVisualStyleBackColor = true;
            // 
            // printHashtableButton
            // 
            this.printHashtableButton.Location = new System.Drawing.Point(305, 31);
            this.printHashtableButton.Name = "printHashtableButton";
            this.printHashtableButton.Size = new System.Drawing.Size(197, 23);
            this.printHashtableButton.TabIndex = 1;
            this.printHashtableButton.Text = "Вывести хеш-таблицу";
            this.printHashtableButton.UseVisualStyleBackColor = true;
            this.printHashtableButton.Click += new System.EventHandler(this.printHashtableButton_Click);
            // 
            // debugTextBox
            // 
            this.debugTextBox.Location = new System.Drawing.Point(12, 88);
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.ReadOnly = true;
            this.debugTextBox.Size = new System.Drawing.Size(949, 471);
            this.debugTextBox.TabIndex = 2;
            this.debugTextBox.Text = "";
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 571);
            this.Controls.Add(this.debugTextBox);
            this.Controls.Add(this.printHashtableButton);
            this.Controls.Add(this.printTreeButton);
            this.Name = "DebugForm";
            this.Text = "DebugForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printTreeButton;
        private System.Windows.Forms.Button printHashtableButton;
        private System.Windows.Forms.RichTextBox debugTextBox;
    }
}