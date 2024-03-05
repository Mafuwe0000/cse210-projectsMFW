using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your name??");
        string firstName=Console.Readline();

        Console.Write("What is your last name??");
        string lastName=Console.Readline();

        Console.WriteLine ($"your name is {lastName}, {firstName} {lastName}");
    }
}