using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalTracker tracker = new GoalTracker();

            // Sample goals for testing
            tracker.AddGoal(new SimpleGoal("Run a marathon", "Complete a marathon for the first time", 1000));
            tracker.AddGoal(new EternalGoal("Read Scriptures", "Daily scripture reading", 100));
            tracker.AddGoal(new ChecklistGoal("Attend Temple", "Attend temple 10 times", 50, 10, 500));

            // Simulate progress
            tracker.RecordEvent("Read Scriptures");
            tracker.RecordEvent("Attend Temple");

            // Display goals and progress
            tracker.DisplayGoals();

            // Saving and loading goals
            tracker.SaveGoals("goals.txt");
            tracker.LoadGoals("goals.txt");
            tracker.DisplayGoals();
        }
    }
}
