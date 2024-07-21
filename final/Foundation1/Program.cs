using System;
using System.Collections.Generic;

class Program
{
    static void InputProgram(List<Video> videoList)
    {
        Comment comment1;Comment comment2;Comment comment3;

        Video video;List<Comment> commentList;

        comment1 = new Comment("Sam", "Great tutorial!");

        comment2 = new Comment("Dave", "If you found this video helpful check out website for mechanic tutorials!");

        comment3 = new Comment("Philip", "Thank you so much!");

        commentList = new List<Comment>{comment1,comment2,comment3};

        video = new Video("HJ-Samson's Tutorials",
        "Learn C#", 600, commentList);
        videoList.Add(video);

        comment1 = new Comment("Moses", "Wonderful lecture thank you so much!");

        comment2 = new Comment("Emmanuel", "Not the worst things I've learnt...");

        comment3 = new Comment("Frank", "At Excellent Content!...");

        commentList = new List<Comment>{comment1,comment2,comment3};
        video = new Video("HJ-Samson's Advanced Tutorials",
        "Learn Advance C#.", 1200, commentList);
        videoList.Add(video);

        comment1 = new Comment("Grace", "I learned a lot.");
        
        comment2 = new Comment("Peace", "Very well explained.");

        comment3 = new Comment("Ivan", "Can you make a video on SOLID principles?.");

        commentList = new List<Comment>{comment1,comment2,comment3};
        video = new Video("HJ-Samson's Lecture",
        "C# Design Patterns", 1800, commentList);
        videoList.Add(video);
    }

    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>{};
        InputProgram(videoList);
        
        foreach(Video video in videoList)
        {
            video.Display();
            Console.WriteLine();
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}