using System;
using System.Collections.Generic;
using System.Linq;
public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide() 
    {
        _hidden = true;
    }
    
    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetRenderedText()
    {
        return _hidden ? new string('_', _word.Length) : _word;
    }
}