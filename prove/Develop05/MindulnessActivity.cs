using System;

abstract class MindfulnessActivity
{
    protected string Name { get; set; }
    protected string Description { get; set; }

    public void StartActivity()
    {
        Console.WriteLine($"\nStarting {Name} Activity");
        Console.WriteLine($"{Description}");
        Console.WriteLine("How long would you like to do this activity (in seconds)?");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        Pause(3); // Simulate preparation

        RunActivity(duration);
        EndActivity(duration);
    }

    protected abstract void RunActivity(int duration);

    protected void EndActivity(int duration)
    {
        Console.WriteLine($"\nWell done! You have completed the {Name} Activity for {duration} seconds.");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rPausing... {i}");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
