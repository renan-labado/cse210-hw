public class Word
{
    private string _text;
    private bool _isHidden;
    private List<bool> _completelyHidden = new List<bool>();

    public Word(string text)
    {
        _isHidden = false;
        _text = text;
    }

    public void Hide()
    {
        string newText = "";
        for (int i = 0; i < _text.Count(); i++)
        {
            newText += "_";
        }
        _text = newText;
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
    public bool isHidden()
    {
        if (_isHidden == true)
            return true;
        else
            return false;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}