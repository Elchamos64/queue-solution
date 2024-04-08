namespace queue_start;

public class Program
{
    public static void Main(string[] args)
    {
        TaskScheduler scheduler = new TaskScheduler();

        // Adding tasks with different priorities
        scheduler.AddTask(new Task("Urgent Task 1", 10));
        scheduler.AddTask(new Task("Urgent Task 2", 10));
        scheduler.AddTask(new Task("Regular Task 1", 5));
        scheduler.AddTask(new Task("Regular Task 2", 5));
        scheduler.AddTask(new Task("Background Task 1", 1));
        scheduler.AddTask(new Task("Background Task 2", 1));

        // Execute tasks
        scheduler.ExecuteTasks();
    }
}