class ListingActivity : MindfulnessActivity
{
    private readonly string[] prompts = { // Use readonly for prompts that won't change
        "List people who have made a positive impact on your life.",
        "List your personal strengths.",
        "List things you're grateful for today."
    };

    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity will help you reflect on the good things in your life by listing them. It's a way to bring gratitude and positivity to the forefront of your mind.";
    }

    protected override void RunActivity(int duration)
    {
        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"\n{selectedPrompt}");
        DisplayCountdown(5);

        Console.WriteLine("Start listing (press Enter after each item):");

        int count = 0;
        int timeLeft = duration;
        List<string> listedItems = new List<string>(); // Store user input in a list

        while (timeLeft > 0 && !Console.KeyAvailable) // Check for user input interruption
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                listedItems.Add(input);
                count++;
            }
            timeLeft -= 2; // Simulate 2 seconds for each list item
        }

        Console.WriteLine($"\nYou listed {count} items. Well done!");

        // Optional: Display the listed items (if desired)
        if (listedItems.Count > 0)
        {
            Console.WriteLine("\nYour list:");
            foreach (string item in listedItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}