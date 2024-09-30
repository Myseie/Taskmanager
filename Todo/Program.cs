using Todo;

class Program
{
    static void Main()
    {
        Taskmanager manager = new Taskmanager();
        bool exit = false;


        while (!exit)
        {
            Console.WriteLine("\nVälj ett alternativ.");
            Console.WriteLine("1. Lägg till uppgift");
            Console.WriteLine("2. Markera uppgift som klar.");
            Console.WriteLine("3. Ta bort uppgift.");
            Console.WriteLine("4. Visa alla uppgifter.");
            Console.WriteLine("5. Visa klara uppgifter.");
            Console.WriteLine("6. Visa inte klara uppgifter.");
            Console.WriteLine("7. Avsluta.");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Ange uppgiftnamn:");
                    string taskName = Console.ReadLine();

                    Console.Write("Ange beskrivning :");
                    string description = Console.ReadLine();

                    TodoTask newTask = new TodoTask(taskName, description);
                    manager.AddTask(newTask);
                    break;
                case "2":
                    Console.Write("Ange uppgiftsnamn:");
                    string taskToMark = Console.ReadLine();

                    manager.MarkTaskCompleted(taskToMark);
                    break;
                case "3":
                    Console.Write("Ange uppgiftsnamn :");
                    string taskToRemove = Console.ReadLine();
                    break;
                case "4":
                    manager.ShowAllTasks();
                    break;

                case "5":
                    manager.ShowCompletedTasks();
                    break;
                case "6":
                    manager.ShowIncompletedTasks();
                    break;
                case "7":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Ogiltligt val, försök igen");
                    break;
            }
        }
    }
}