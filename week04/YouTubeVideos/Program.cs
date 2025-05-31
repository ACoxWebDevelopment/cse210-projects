using System;

class Program
{
    static void Main(string[] args)
    {
        Comment video1MyComment = new Comment("Me", "I can't believe he did that");
        Comment video1HisComment = new Comment("Him", "I can't believe she did that");
        Comment video1HerComment = new Comment("Her", "What were they thinking?");
        List<Comment> video1Comments = new List<Comment> { video1MyComment, video1HisComment, video1HerComment };

        Video video1 = new Video("video1", "George", 120, video1Comments);
        Console.Clear();
        video1.DisplayVideo(video1);
        Console.WriteLine();

        Comment video2MyComment = new Comment("Me", "Amazing video");
        Comment video2HisComment = new Comment("Him", "Thank-you for posting");
        Comment video2HerComment = new Comment("Her", "Absolutely incredible!");
        List<Comment> video2Comments = new List<Comment> { video2MyComment, video2HisComment, video2HerComment };

        Video video2 = new Video("video2", "Marty", 90, video2Comments);
        video2.DisplayVideo(video2);
        Console.WriteLine();

        Comment video3MyComment = new Comment("Me", "Truly inspiring");
        Comment video3HisComment = new Comment("Him", "Best video yet");
        Comment video3HerComment = new Comment("Her", "Amazing job");
        List<Comment> video3Comments = new List<Comment> { video3MyComment, video3HisComment, video3HerComment };

        Video video3 = new Video("video3", "Eric", 82, video3Comments);
        video3.DisplayVideo(video3);

    }
}