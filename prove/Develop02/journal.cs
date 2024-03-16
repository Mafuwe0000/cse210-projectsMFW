using System;
public class Journal
{
    private string journalFilePath;

    public Journal (string filepath)
    {

        journalFilePath =filepath;
    }

    public void AddEntry (string entry)
    {
        File.AppendAllText(journalFilePath, $"{DateTime.Now}:{entry}\n");
    }

    public string ReadEntries ()
    {
        return
        File.ReadAllText(journalFilePath);
    }
    public void SavedToAFile(string filepath)
    {
        File.WriteAllText(filepath, ReadEntries());
    }
    public void LoadingFromAFile (string filepath)
    {
        if (File.Exists(filepath))
        {
            string data = File.ReadAllText(filepath);
            File.WriteAllText(journalFilePath, data);

        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}