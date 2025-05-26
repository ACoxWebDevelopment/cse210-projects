class Reference

{
    private string _book;
    private int _chapter;
    private int _beginVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int beginVerse)
    {
        _book = book;
        _chapter = chapter;
        _beginVerse = beginVerse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int beginVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _beginVerse = beginVerse;
        _endVerse = endVerse;

    }

    public string GetDisplay()
    {
        if (_endVerse == 0)

        { return ($"{_book} {_chapter}:{_beginVerse}"); }
        else return ($"{_book} {_chapter}:{_beginVerse}-{_endVerse}");
    }
    

}