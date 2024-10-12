using System; // This should be at the very top
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("Intro to C#", "John Doe", 300);
        Video video2 = new Video("Advanced Python", "Jane Smith", 450);
        Video video3 = new Video("JavaScript Tips", "Chris Johnson", 600);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great introduction!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "Helped me a lot, thanks!"));

        // Add comments to video2
        video2.AddComment(new Comment("David", "Loved the advanced topics."));
        video2.AddComment(new Comment("Eve", "Very well explained."));
        video2.AddComment(new Comment("Frank", "Good insights into Python."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Awesome tips, thanks!"));
        video3.AddComment(new Comment("Hank", "JavaScript has so many tricks!"));
        video3.AddComment(new Comment("Ivy", "Very helpful content."));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list of videos and display details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();  // Blank line between videos
        }
    }
}
