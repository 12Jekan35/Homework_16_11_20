
namespace ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.CreateOrEditTaskButton = new System.Windows.Forms.Button();
            this.TaskListViewer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DeleteTaskButton
            // 
            resources.ApplyResources(this.DeleteTaskButton, "DeleteTaskButton");
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.UseVisualStyleBackColor = true;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // CreateOrEditTaskButton
            // 
            resources.ApplyResources(this.CreateOrEditTaskButton, "CreateOrEditTaskButton");
            this.CreateOrEditTaskButton.Name = "CreateOrEditTaskButton";
            this.CreateOrEditTaskButton.UseVisualStyleBackColor = true;
            this.CreateOrEditTaskButton.Click += new System.EventHandler(this.CreateOrEditTaskButton_Click);
            // 
            // TaskListViewer
            // 
            this.TaskListViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.TaskListViewer.FullRowSelect = true;
            this.TaskListViewer.GridLines = true;
            this.TaskListViewer.HideSelection = false;
            resources.ApplyResources(this.TaskListViewer, "TaskListViewer");
            this.TaskListViewer.MultiSelect = false;
            this.TaskListViewer.Name = "TaskListViewer";
            this.TaskListViewer.UseCompatibleStateImageBehavior = false;
            this.TaskListViewer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaskListViewer);
            this.Controls.Add(this.CreateOrEditTaskButton);
            this.Controls.Add(this.DeleteTaskButton);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DeleteTaskButton;
        private System.Windows.Forms.Button CreateOrEditTaskButton;
        private System.Windows.Forms.ListView TaskListViewer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

