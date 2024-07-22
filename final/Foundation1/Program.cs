using System;

class Program
    {
        static void Main(string[] args)
        {
            // Creates a list to hold videos
            List<Video> videos = new List<Video>();

            // Creates Three videos
            Video video1 = new Video("Introduction to C#", "Dwayne The Rock Johnson", 600);

            Video video2 = new Video("Advanced Pro gamer moves in Valorant", "MJ Twitch", 1200);

            Video video3 = new Video("How To Save Kittens From a Tree", "Idaho FirefightersYT", 900);

            // Adds comments to video1
            video1.AddComment(new Comment("Alice", "Great video!"));

            video1.AddComment(new Comment("Bob", "Very informative."));

            video1.AddComment(new Comment("Charlie", "Loved the examples."));

            // Adds comments to video2
            video2.AddComment(new Comment("Dave", "Excellent explanations."));

            video2.AddComment(new Comment("Eve", "Helped me a lot."));

            video2.AddComment(new Comment("Frank", "Thanks for sharing."));

            // Adds comments to video3
            video3.AddComment(new Comment("Grace", "Well structured."));

            video3.AddComment(new Comment("Hank", "Good job!"));

            video3.AddComment(new Comment("Ivy", "I learned a lot."));

            // Adds videos to the list
            videos.Add(video1);

            videos.Add(video2);

            videos.Add(video3);

            // Iterates through the list and display details
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video._title}");

                Console.WriteLine($"Author: {video._author}");

                Console.WriteLine($"Length: {video._length} seconds");

                Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
                
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment._commenterName}: {comment._text}");
                }

                Console.WriteLine();
            }
        }
    }