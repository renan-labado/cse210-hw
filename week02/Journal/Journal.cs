public class Journal
{
    public List<Entry> _entries = new List<Entry>(); 

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))     
        foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}: Prompt - {entry._promptText}: {entry._entryText}");
            }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
        string[] parts = line.Split(":");

        string firstLine = parts[0];
        string secondLine = parts[1];
        }
    }
}