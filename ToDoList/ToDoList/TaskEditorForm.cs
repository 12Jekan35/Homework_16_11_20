using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class TaskEditorForm : Form
    {
        public TaskEditorForm()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(ref Task _task)
        {
            if (_task.DateTimeByExecute != null || _task.Title != null)
            {
                TitleTaskTextBox.Text = _task.Title;
                DateTimeByExecutePicker.Value = _task.DateTimeByExecute;
            }
            var result = this.ShowDialog();
            if (result == DialogResult.OK)
            {
                _task.DateTimeByExecute = DateTimeByExecutePicker.Value;
                _task.Title = TitleTaskTextBox.Text;
            }
            return result;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleTaskTextBox.Text))
            {
                MessageBox.Show("Не корректное название задачи!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
