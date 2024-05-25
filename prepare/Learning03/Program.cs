using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Console.WriteLine($"fraction one's numerator and denominator is: {one.getNumerator} and {one.getDenominator} ");
        Console.WriteLine(one.getFractionString());
        Console.WriteLine(one.getDecimalValue());

        Fraction two = new Fraction(6);
        Console.WriteLine($"fraction two's numerator and denominator is: {two.getNumerator} and {two.getDenominator} ");
        Console.WriteLine(two.getFractionString());
        Console.WriteLine(two.getDecimalValue());

        Fraction three = new Fraction(6,7);
        Console.WriteLine($"fraction three's numerator and denominator is: {three.getNumerator} and {three.getDenominator} ");        
        Console.WriteLine(three.getFractionString());
        Console.WriteLine(three.getDecimalValue());
    }
}