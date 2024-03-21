using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Mafuwe Manuel", "Phisics");
        Console.WriteLine(a1.GetSummary());
    
        MathAssignment b1 = new MathAssignment ("7.3", "8-19", "Robert Rodriguez", "Fractions");
        Console.WriteLine(b1.GetSummary());
        Console.WriteLine(b1.GetHomeWorkList());

        WriteAssignment c1 = new WriteAssignment ("Mary Poppins", "European History", "The causes of great Depression");
        Console.WriteLine(c1.GetWritingInformation());
    }
}