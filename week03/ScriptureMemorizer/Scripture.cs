public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split(" ");
    }

    public void HideRandomWords(int numberToHide)
    {
        
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool isCompletelyHidden()
    {
        return true;
    }
}