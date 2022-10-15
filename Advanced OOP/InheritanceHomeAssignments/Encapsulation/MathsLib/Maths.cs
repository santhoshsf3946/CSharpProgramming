namespace MathsLib;
public class Maths
{
    protected internal double PI = 3.14;

    internal double g = 9.8;

    public double CalculateWeight (double mass)
    {
        return mass * g;
    }
}
