public class Fraction
{
    private int _top;
    private int _bottom; 

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void SetNumerator(int num)
    {
        _top = num;
    }
    public void SetDenominator(int dem)
    {
        _bottom = dem;
    }

    public int GetNumerator()
    {
        return _top;
    }
    public int GetDenominator()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        string result = $"{_top}/{_bottom}";
        return result;
    }
    public double GetDecimalValue()
    {
        double result = (double)_top / _bottom;
        return result;
    }
}