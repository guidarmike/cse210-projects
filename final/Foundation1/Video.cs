class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public void SetTitle(string videoTitle)
    {
        _title = videoTitle;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetAuthor(string videoAuthor)
    {
        _author = videoAuthor;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetLengthInSeconds(int videoLength)
    {
        _lengthInSeconds = videoLength;
    }

    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }

    public Video(string title, string author, int lengthInSeconds)
    {
        SetTitle(title);
        SetAuthor(author);
        SetLengthInSeconds(lengthInSeconds);
        _comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
        _comments.Add(newComment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}