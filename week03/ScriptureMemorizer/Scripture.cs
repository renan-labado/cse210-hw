public class Scripture
{
    private Reference _reference;
    private List<Word> _words= new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split(" ");
        for (int i = 0; i < parts.Count(); i++)
        {
            Word newWord = new Word(parts[i]);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < _words.Count(); i++)
        {
            if (i == numberToHide)
            {
                _words[i].Hide();
            }
        }
    }

    public string GetDisplayText()
    // display text here means that it is shown normally, and some replaced by underscores
    {
        return "";
    }

    public bool isCompletelyHidden()
    {
        return true;
    }
}