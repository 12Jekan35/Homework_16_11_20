using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Task
    {
        public string Title { get; set; }
        public DateTime DateTimeByExecute { get; set; } = DateTime.Now;
    }
}
