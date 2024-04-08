namespace queue_start;

public class TaskScheduler
{
    private Queue<Task> taskQueue;

    public TaskScheduler()
    {
        taskQueue = new Queue<Task>();
    }

    public void AddTask(Task task)
    {
        //TODO
        // Create the add task function
    }

    public void ExecuteTasks()
    {
        while (taskQueue.Count > 0)
        {
            Task nextTask = GetHighestPriorityTask();
            Console.WriteLine($"Executing task: {nextTask.Name}, Priority: {nextTask.Priority}");
            // Simulating task execution
            System.Threading.Thread.Sleep(1000);
            //TODO
            //Make sure the task gets Dequeued
        }
    }

    private Task GetHighestPriorityTask()
    {
        Task[] tasks = taskQueue.ToArray();
        Array.Sort(tasks, (t1, t2) => t2.Priority.CompareTo(t1.Priority));
        return tasks[0];
    }
}