using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // Create first video and add comments
        Video video1 = new Video("How to Cook Pasta", "Chef Mario", 300);
        video1.AddComment(new Comment("Alice", "Looks delicious!"));
        video1.AddComment(new Comment("Bob", "I tried this and it turned out great."));
        video1.AddComment(new Comment("Charlie", "Can you make one on sauces next?"));
        videos.Add(video1);

        // Create second video and add comments
        Video video2 = new Video("Beginner Yoga Routine", "YogaWithEmma", 600);
        video2.AddComment(new Comment("Dana", "Very relaxing."));
        video2.AddComment(new Comment("Eli", "I feel much better now."));
        video2.AddComment(new Comment("Faith", "Loved the music too!"));
        videos.Add(video2);

        // Create third video and add comments
        Video video3 = new Video("Top 10 Programming Tips", "CodeNinja", 450);
        video3.AddComment(new Comment("George", "Tip #3 saved me hours."));
        video3.AddComment(new Comment("Hannah", "More like this, please."));
        video3.AddComment(new Comment("Isaac", "Tip #7 was new to me!"));
        videos.Add(video3);

        // Create fourth video and add comments
        Video video4 = new Video("Exploring Iceland", "TravelWithSam", 900);
        video4.AddComment(new Comment("Jack", "Now I want to visit Iceland!"));
        video4.AddComment(new Comment("Karen", "The drone shots were amazing."));
        video4.AddComment(new Comment("Liam", "Thanks for the travel tips."));
        videos.Add(video4);

        // Display details for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.Length}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  - {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
