using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    class TodoTask
    {
        public string TaskName { get; }
        public string Description { get; }

        public bool IsCompleted { get; private set; } = false;


        public TodoTask(string taskName, string description)
        {
            TaskName = taskName;
            Description = description;

        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;


        }

        public override string ToString()
        {
            string status = IsCompleted ? "Klar" : "Ej klar";
            return $"{TaskName} - {Description} [Status {status}]";
        }
    }
}
