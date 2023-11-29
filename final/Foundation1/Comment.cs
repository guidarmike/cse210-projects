class Comment
{
    private string _commenterName;
    private string _commentText;

    public void SetCommenterName(string name)
    {
        _commenterName = name;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public void SetCommentText(string text)
    {
        _commentText = text;
    }

    public string GetCommentText()
    {
        return _commentText;
    }

    public Comment(string commenterName, string commentText)
    {
        SetCommenterName(commenterName);
        SetCommentText(commentText);
    }
}