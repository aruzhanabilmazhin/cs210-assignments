// Video.cs
using System.Collections.Generic;

public class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public string Title => title;
    public string Author => author;
    public int LengthInSeconds => lengthInSeconds;
    public List<Comment> Comments => comments;

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }
}
