class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public int getNumerator()
    {
        return _numerator;
    }

    public int getDenominator()
    {
        return _denominator;
    }

    public void setNumerator(int newNum)
    {
        _numerator = newNum;
    }

    public void setDenominator(int newDem)
    {
        _denominator = newDem;
    }

    public string getFractionString()
    {
        return ($"{_numerator}/{_denominator}");
    }

    public double getDecimalValue()
    {
        return (double)_numerator/(double)_denominator;
    }
}