using System;
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
