namespace EternalQuest
{
    public abstract class Goal
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Points { get; protected set; }

        protected Goal(string name, string description, int points)
        {
            Name = name;
            Description = description;
            Points = points;
        }

        public abstract void RecordProgress();
        public abstract string DisplayStatus();
    }
}
