class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you showed great courage.",
        "Think of a moment when you helped someone in need.",
        "Think of a time when you faced a challenge and overcame it."
    };

    private string[] questions = {
        "Why was this experience important to you?",
        "How did it shape you?",
        "What did you learn from it?",
        "How can you apply this experience to future challenges?"
    };

    public ReflectionActivity()
    {
        Name = "Reflection";
        Description = "This activity will help you reflect on positive experiences, allowing you to gain deeper insight into your strengths.";
    }

    protected override void RunActivity(int duration)
    {
        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"\nReflect on this: {selectedPrompt}");
        DisplayCountdown(5); // Pause for initial reflection

        Console.WriteLine("Write down your thoughts: ");
        string reflectionInput = Console.ReadLine(); // Capture user reflection

        int timeLeft = duration;
        foreach (string question in questions)
        {
            Console.WriteLine($"\n{question}");
            DisplayCountdown(5); // Pause for reflection on each question
            Console.WriteLine("Write down your thoughts: ");
            string questionInput = Console.ReadLine(); // Capture user response for each question
            timeLeft -= 5;

            if (timeLeft <= 0) break; // Exit loop if time runs out
        }
    }
}