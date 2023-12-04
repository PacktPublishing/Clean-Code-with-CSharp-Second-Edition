namespace CH06_UnitTesting;

public class MathService
{
    private readonly ICalculator _calculator;

    public MathService(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public int AddNumbers(int a, int b)
    {
        return _calculator.Add(a, b);
    }
}
