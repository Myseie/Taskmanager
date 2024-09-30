using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    class Taskmanager
    {
        private List<TodoTask> tasks = new List<TodoTask>();


        public void AddTask(TodoTask task)
        {
            tasks.Add(task);

            Console.WriteLine($"Uppgiften '{task.TaskName}' har lagts till.");
        }

        public void MarkTaskCompleted(string taskName)
        {
            TodoTask taskToMark = tasks.Find(t => t.TaskName.ToLower() == taskName.ToLower());

            if (taskToMark != null)
            {
                taskToMark.MarkAsCompleted();
                Console.WriteLine($"Uppgiften '{taskToMark.TaskName}' har markerats som klar.");

            }
            else
            {
                Console.WriteLine($"Uppgiften '{taskName}' hittades inte ");
            }
        }

        public void RemoveTask(string taskName)
        {
            TodoTask taskToRemove = tasks.Find(t => t.TaskName.ToLower() == taskName.ToLower());
            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
                Console.WriteLine($"Uppgiften '{taskToRemove.TaskName}' har tagits bort.");

            }
            else
            {
                Console.WriteLine($"Uppgiften '{taskToRemove.TaskName}' hittades inte.");

            }

        }

        public void ShowAllTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Inga uppgifter har lagts till ännu.");
            }
            else
            {
                Console.WriteLine("Alla uppgifter :");
                foreach (var task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
        }
        public void ShowCompletedTasks()
        {
            var completedTasks = tasks.Where(t => t.IsCompleted).ToList();
            if (completedTasks.Count == 0)
            {
                Console.WriteLine("Inga klara uppgifter.");
            }
            else
            {
                Console.WriteLine("Klara uppgifter: ");
                foreach (var task in completedTasks)
                {
                    Console.WriteLine(task);
                }
            }
        }

        public void ShowIncompletedTasks()
        {
            var incompleteTasks = tasks.Where(t => !t.IsCompleted).ToList();

            if (incompleteTasks.Count == 0)
            {
                Console.WriteLine("Alla uppgifter är klara.");
            }
            else
            {
                Console.WriteLine("Ej klara uppgifter : ");
                foreach (var task in incompleteTasks)
                {
                    Console.WriteLine(task);
                }
            }
        }
    }
}
