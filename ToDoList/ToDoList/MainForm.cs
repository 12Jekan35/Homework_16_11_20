using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDoList
{
    public partial class MainForm : Form
    {
        public string FilePath { get; } = @"C:\Users\Public\Documents\tasks.txt";
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateOrEditTaskButton_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            if (TaskListViewer.SelectedItems.Count > 0)
            {
                task.Title = TaskListViewer.SelectedItems[0].SubItems[1].Text;
                task.DateTimeByExecute = DateTime.Parse(TaskListViewer.SelectedItems[0].SubItems[0].Text);
            }

            var result = new TaskEditorForm().ShowDialog(ref task);

            if (result == DialogResult.OK)
            {
                if (TaskListViewer.SelectedItems.Count < 1)
                {
                    TaskListViewer.Items.Add(new ListViewItem(new[] { task.DateTimeByExecute.ToString(), task.Title }));
                }
                else
                {
                    TaskListViewer.SelectedItems[0].SubItems[0].Text = task.DateTimeByExecute.ToString();
                    TaskListViewer.SelectedItems[0].SubItems[1].Text = task.Title;
                }
            }
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskListViewer.SelectedItems.Count < 1)
                return;
            TaskListViewer.Items.Remove(TaskListViewer.SelectedItems[0]);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(FilePath))
                return;
            string[] lines;
            using (FileStream fileStream = new FileStream(FilePath, FileMode.Open))
            {
                StreamReader reader = new StreamReader(fileStream);
                string text = reader.ReadToEnd();
                lines = text.Split('\n');
                ListViewItem item;
                for (int i = 0; i < lines.Length; i++)
                {
                    item = new ListViewItem(lines[i].Split('|'));
                    TaskListViewer.Items.Add(item);
                }
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fileStream = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                string savedTaskList = "";
                StreamWriter writer = new StreamWriter(fileStream);
                foreach (ListViewItem item in TaskListViewer.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    {
                        savedTaskList += subitem.Text + "|";
                    }
                    savedTaskList += "\n";
                }
                writer.Write(savedTaskList);
                writer.Flush();
            }
        }
    }
}
