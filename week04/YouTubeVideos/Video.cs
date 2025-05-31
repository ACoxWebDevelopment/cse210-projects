using System.Transactions;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment = new List<Comment>();

    public Video(string title, string author, int length, List<Comment> comment)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = comment;
    }

    public int NumberOfComments()
    {
        return _comment.Count();
    }
    public void DisplayVideo(Video video)
    {
        _title = video._title;
        _author = video._author;
        _length = video._length;
        _comment = video._comment;
        int numComments = NumberOfComments();

        Console.WriteLine($"Video Title:{_title}  Video Author:{_author}  Video Length:{_length} seconds  Number of Comments:{numComments} ");
        Console.WriteLine();
        foreach (Comment vid in video._comment)
        {
            Console.WriteLine(vid.DisplayComment());
        }
    }
}