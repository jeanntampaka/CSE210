using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "TechWithTim", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Could use more examples."));

        Video video2 = new Video("Advanced C# OOP", "CodeAcademy", 1200);
        video2.AddComment(new Comment("Dave", "Loved the abstraction concept."));
        video2.AddComment(new Comment("Eva", "Encapsulation made easy!"));
        video2.AddComment(new Comment("Frank", "More videos like this, please."));

        Video video3 = new Video("C# Interfaces Explained", "ProgrammingGuru", 800);
        video3.AddComment(new Comment("Grace", "Crystal clear. Thanks!"));
        video3.AddComment(new Comment("Hank", "Too fast at some points."));
        video3.AddComment(new Comment("Ivy", "Nice visuals."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
