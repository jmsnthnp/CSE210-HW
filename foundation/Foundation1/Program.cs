using System;  
using System.Collections.Generic;  

namespace YoutubeVideos  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Video video1 = new Video("How to Cook a Perfect Steak", "Gordy Ramses", 600);  
            video1.AddComment(new Comment("John", "What a deliiciious steak!"));  
            video1.AddComment(new Comment("Jude", "Very informative. Thank you!"));  
            video1.AddComment(new Comment("Jay", "Wow, amazing technique"));  

            Video video2 = new Video("How to Code for Dummies", "Albert Goldstein", 1800);  
            video2.AddComment(new Comment("Bob", "Very helpful!"));  
            video2.AddComment(new Comment("Bryan", "Great Video!")); 
            video2.AddComment(new Comment("Bruno", "Simple and informative."));   

            Video video3 = new Video("How to Get Rich Instantly", "John Scammer", 1200);  
            video3.AddComment(new Comment("Alice", "Fake Video!")); 
            video3.AddComment(new Comment("Alex", "Stop spreading misinformation!")); 
            video3.AddComment(new Comment("Andrew", "This video is unhelpful"));  

            // List of videos  
            List<Video> videos = new List<Video> { video1, video2, video3 };  

            // Display information about each video  
            foreach (var video in videos)  
            {  
                Console.WriteLine(video.GetVideoInfo());  
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");  
                Console.WriteLine("Comments:");  
                foreach (var comment in video.ListComments())  
                {  
                    Console.WriteLine($"  - {comment}");  
                }  
                Console.WriteLine();  // for spacing between videos  
            }  
        }  
    }  
}