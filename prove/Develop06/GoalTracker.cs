using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalTracker
    {
        private List<Goal> goals = new List<Goal>();
        private int totalScore = 0;

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void RecordEvent(string goalName)
        {
            foreach (Goal goal in goals)
            {
                if (goal.Name == goalName)
                {
                    goal.RecordProgress();
                    totalScore += goal.Points;
                    break;
                }
            }
        }

        public void DisplayGoals()
        {
            Console.WriteLine("\nYour Goals:");
            foreach (Goal goal in goals)
            {
                Console.WriteLine(goal.DisplayStatus());
            }
            Console.WriteLine($"\nTotal Score: {totalScore}");
        }

        public void SaveGoals(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(totalScore);
                foreach (Goal goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points}");
                }
            }
        }

        public void LoadGoals(string filename)
        {
            if (File.Exists(filename))
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    totalScore = int.Parse(reader.ReadLine());
                    goals.Clear();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string type = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);

                        switch (type)
                        {
                            case "SimpleGoal":
                                goals.Add(new SimpleGoal(name, description, points));
                                break;
                            case "EternalGoal":
                                goals.Add(new EternalGoal(name, description, points));
                                break;
                            case "ChecklistGoal":
                                int targetCount = int.Parse(parts[4]);
                                int bonusPoints = int.Parse(parts[5]);
                                goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                                break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Save file not found.");
            }
        }
    }
}
