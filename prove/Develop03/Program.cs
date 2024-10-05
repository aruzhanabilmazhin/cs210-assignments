using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a sample scripture
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        // Main program loop
        while (true)
        {
            scripture.DisplayScripture();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden! Program will now end.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3); // Hides 3 random words at each step
            }
        }
    }
}
