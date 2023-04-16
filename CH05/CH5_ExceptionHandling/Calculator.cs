namespace CH5_ExceptionHandling;

public  class Calculator
{
    public double Divide(double numerator, double denominator)
    {
        if (denominator == 0)
            throw new DivideByZeroException("Denominator cannot be zero."); 

        return (numerator / denominator);
    }
}
