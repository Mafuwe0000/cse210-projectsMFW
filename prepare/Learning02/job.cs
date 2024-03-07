public class Job
{
    public string _jobTitle;
    public string _nameOfTheCompany;
    public int  _startYear;
    public int _endYear;

    public void  DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} {_nameOfTheCompany} {_startYear} - {_endYear}");
    }
}