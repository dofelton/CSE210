using System;
using System.Runtime.Intrinsics;
using System.Security.Cryptography;

// create 3-4 instances of the video class appropriatly setting all attributes
// each instance will have 3-4 comments, name and text
// put all videos into a list, then iterate through the list of videos and display title, author, length, number of comments and all comments for each video

// create 3-4 instances of the video class appropriatly setting all attributes
// each instance will have 3-4 comments, name and text
// put all videos into a list, then iterate through the list of videos and display title, author, length, number of comments and all comments for each video

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video v1 = new Video("Beef", "Sue", 53);
        Comment c1 = new Comment("Hal", "Nice!");
        Comment c2 = new Comment("Bill", "Whoa");
        Comment c3 = new Comment("Gary", "Cool");
        v1.Comments.Add(c1);
        v1.Comments.Add(c2);
        v1.Comments.Add(c3);
        videos.Add(v1);

        Video v2 = new Video("Pork", "Jeff", 134);
        Comment c4 = new Comment("shelly", "Seriously good eats");
        Comment c5 = new Comment("Kate", "Disgusting");
        Comment c6 = new Comment("larry", "Spicy is Nicey");
        v2.Comments.Add(c4);
        v2.Comments.Add(c5);
        v2.Comments.Add(c6);
        videos.Add(v2);

        Video v3 = new Video("Chicken", "Sally", 320);
        Comment c7 = new Comment("Jeff", "Amazing");
        Comment c8 = new Comment("Kelly", "Boring");
        Comment c9 = new Comment("Ivy", "Chef is Awesome");
        Comment c10 = new Comment("Izzy", "Yummy! I Love It!");
        v3.Comments.Add(c7);
        v3.Comments.Add(c8);
        v3.Comments.Add(c9);
        v3.Comments.Add(c10);
        videos.Add(v3);

        foreach (Video vid in videos)
        {
            vid.DisplayDetails(vid);

            foreach (Comment comment in vid.Comments)
            {
                comment.DisplayComment(comment);
            }
        }
    }
}