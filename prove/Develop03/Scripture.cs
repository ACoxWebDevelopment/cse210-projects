
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    Reference _reference;
    string _text;
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }


    }
    public void HideRandomWords()
    {
        Random random = new Random(); 
        
       
            int wordNumber;
            do
            {
                wordNumber = random.Next(0, _words.Count);
            }
            while (_words[wordNumber].IsHidden()); //keep choosing random words until one is not already hidden
            _words[wordNumber].Hide();
        
    }
    public string GetDisplayText()
{
    List<string> displayWords = new List<string>();

    foreach (Word word in _words)
    {
        displayWords.Add(word.GetDisplayText());
    }

    return $"{_reference.GetDisplay()}: {string.Join(" ", displayWords)}";
}

    public bool IsCompletelyHidden()
{
    return _words.All(word => word.IsHidden());
}

}