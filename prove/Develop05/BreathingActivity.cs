class BreathingActivity : MindfulnessActivity
{
    private int breathingDuration = 10; // Default duration in seconds
    private BreathingPattern breathingPattern = BreathingPattern.Normal; // Default breathing pattern

    public BreathingActivity(int duration = 10, BreathingPattern pattern = BreathingPattern.Normal)
    {
        Name = "Breathing";
        Description = "This activity will help you relax by guiding you through deep breathing. Focus on your breath as you inhale and exhale slowly.";
        breathingDuration = duration;
        breathingPattern = pattern;
    }

    // ... (rest of the class)

    protected override void RunActivity(int duration)
    {
        // ... (original code)

        switch (breathingPattern)
        {
            case BreathingPattern.Deep:
                // Adjust breathing times for deep breathing
                break;
            case BreathingPattern.Slow:
                // Adjust breathing times for slow breathing
                break;
            default:
                // Use default breathing pattern
                break;
        }
    }
}

enum BreathingPattern
{
    Normal,
    Deep,
    Slow
}