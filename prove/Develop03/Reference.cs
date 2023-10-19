using System;
using System.Collections.Generic;
using System.Linq;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetRenderedText()
    {
        return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }
}