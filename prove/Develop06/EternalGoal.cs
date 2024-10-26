namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordProgress()
        {
            Console.WriteLine($"{Name} recorded! You earned {Points} points.");
        }

        public override string DisplayStatus()
        {
            return "[∞] " + Name;
        }
    }
}
