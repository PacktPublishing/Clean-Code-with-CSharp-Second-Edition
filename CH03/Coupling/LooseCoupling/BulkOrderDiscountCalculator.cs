namespace CH3.Coupling.LooseCoupling;

public class BulkOrderDiscountCalculator : IDiscountCalculator
{
    public decimal CalculateDiscount(decimal unitPrice, int quantity)
    {
        if (quantity >= 10)
        {
            return unitPrice * quantity * 0.1m; // 10% discount for bulk orders
        }
        else
        {
            return 0m; // No discount
        }
    }
}