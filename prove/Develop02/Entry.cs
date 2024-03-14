public class Entry
{        
    public string _date="";
    public string _promptText="";
    public string _entryText = "";
    
    public void Write()
    {

    }
    
    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        
        
                            
        foreach (string item in randomPrompt)
        {
            Console.WriteLine($"{_date} - {randomPrompt}");
        }
    }
}