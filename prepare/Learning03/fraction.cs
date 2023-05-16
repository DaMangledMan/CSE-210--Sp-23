public class Fraction 
{
    // Attributes
    private int _numerator;
    private int _denominator;

    // Constructors
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Methods
    
    public int getNumerator()
    {
        return _numerator;
    }

    public void setNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int getDenominator()
    {
        return _denominator;
    }

    public void setDenominator(int denominator)
    {
        _denominator = denominator;
    }    

    public string getFractionStringView()
    {
        return $"{_numerator} / {_denominator}";
    }

    public double getFractionDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}