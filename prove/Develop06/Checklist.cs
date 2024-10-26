namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int targetCount;
        private int currentCount;
        private int bonusPoints;

        public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
            : base(name, description, points)
        {
            this.targetCount = targetCount;
            this.bonusPoints = bonusPoints;
            currentCount = 0;
        }

        public override void RecordProgress()
        {
            if (currentCount < targetCount)
            {
                currentCount++;
                Console.WriteLine($"{Name} recorded! You earned {Points} points.");

                if (currentCount == targetCount)
                {
                    Console.WriteLine($"{Name} completed! You earned an additional bonus of {bonusPoints} points.");
                }
            }
            else
            {
                Console.WriteLine($"{Name} is already completed.");
            }
        }

        public override string DisplayStatus()
        {
            return currentCount >= targetCount
                ? $"[X] {Name} (Completed {currentCount}/{targetCount})"
                : $"[ ] {Name} (Completed {currentCount}/{targetCount})";
        }
    }
}
