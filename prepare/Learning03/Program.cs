using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.Writeline(f1.GetFractionString());
        Console.Writeline(f1.GetDecimalValue()); 

        Fraction f2 = new Fraction(5);
        Console.Writeline(f2.GetFractionString());
        Console.Writeline(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3,4);
        Console.Writeline(f3.GetFractionString());
        Console.Writeline(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.Writeline(f4.GetFractionString());
        Console.Writeline(f4.GetDecimalValue());
    }
}