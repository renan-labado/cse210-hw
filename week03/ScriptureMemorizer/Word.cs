public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _isHidden = false;
        _text = text;
    }

    public void Hide()
    {
        
    }

    public void Show()
    {
        
    }

    public bool isHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}