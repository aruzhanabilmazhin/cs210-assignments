class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Please choose an activity: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.StartActivity();
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.StartActivity();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.StartActivity();
                    break;
                case "4":
                    keepRunning = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
