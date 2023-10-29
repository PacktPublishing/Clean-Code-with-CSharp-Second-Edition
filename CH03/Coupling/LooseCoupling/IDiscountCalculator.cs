namespace CH3.Coupling.LooseCoupling;

public interface IDiscountCalculator
{
    decimal CalculateDiscount(decimal unitPrice, int quantity);
}