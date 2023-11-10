public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public void Show()
    {
        Console.WriteLine($"Reference: {_reference.GetRenderedText()}");
        Console.WriteLine("Scripture Text:");
        foreach (Word word in _words)
        {
            Console.Write(word.GetRenderedText() + " ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWord()
    {
        List<Word> remainingWords = _words.Where(w => !w.IsHidden()).ToList();

        if (remainingWords.Count > 0)
        {
            int randomIndex = new Random().Next(remainingWords.Count);
            remainingWords[randomIndex].Hide();
            return true;
        }

        return false;
    }
}

