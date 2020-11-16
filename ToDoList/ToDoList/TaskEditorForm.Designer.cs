
namespace ToDoList
{
    partial class TaskEditorForm
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
            this.DateTimeByExecutePicker = new System.Windows.Forms.DateTimePicker();
            this.TitleTaskTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTimeByExecutePicker
            // 
            this.DateTimeByExecutePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.DateTimeByExecutePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeByExecutePicker.Location = new System.Drawing.Point(12, 27);
            this.DateTimeByExecutePicker.Name = "DateTimeByExecutePicker";
            this.DateTimeByExecutePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimeByExecutePicker.TabIndex = 0;
            // 
            // TitleTaskTextBox
            // 
            this.TitleTaskTextBox.Location = new System.Drawing.Point(12, 66);
            this.TitleTaskTextBox.Name = "TitleTaskTextBox";
            this.TitleTaskTextBox.Size = new System.Drawing.Size(200, 20);
            this.TitleTaskTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата и время выполнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(137, 112);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(56, 112);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 5;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // TaskEditorForm
            // 
            this.AcceptButton = this.AcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 148);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleTaskTextBox);
            this.Controls.Add(this.DateTimeByExecutePicker);
            this.Name = "TaskEditorForm";
            this.Text = "TaskEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimeByExecutePicker;
        private System.Windows.Forms.TextBox TitleTaskTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AcceptButton;
    }
}