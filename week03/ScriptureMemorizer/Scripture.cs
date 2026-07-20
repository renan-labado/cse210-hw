using System.Diagnostics;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words= new List<Word>();
    private List<int> _numbers = new List<int>();


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
        _numbers.Add(numberToHide);
        foreach (int number in _numbers)
        {
            if (numberToHide != number)
            {
                _numbers.Add(numberToHide);
                break;
            }
        
            else
            {
                break;
            }
        }
        for (int i = 0; i < _words.Count(); i++)
        {
            if (i == numberToHide)
            {
                bool wordsHidden = _words[i].isHidden();
                if (wordsHidden == false)
                {
                    _words[i].Hide();
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }

    public string GetDisplayText()
    // display text here means that it is shown normally, and some replaced by underscores
    {
        string verse = "";
        foreach (Word word in _words)
        {
            verse += word.GetDisplayText() + " ";
        }
        return $"{verse}";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}