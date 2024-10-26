namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool isComplete;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            isComplete = false;
        }

        public override void RecordProgress()
        {
            if (!isComplete)
            {
                Console.WriteLine($"{Name} completed! You earned {Points} points.");
                isComplete = true;
            }
            else
            {
                Console.WriteLine($"{Name} is already completed.");
            }
        }

        public override string DisplayStatus()
        {
            return isComplete ? "[X] " + Name : "[ ] " + Name;
        }
    }
}
