namespace CH3.Coupling.TightCoupling;

public class Order
{
    public decimal CalculateTotalPrice(decimal unitPrice, int quantity)
    {
        decimal discount = DiscountCalculator.CalculateDiscount(unitPrice, quantity);
        return unitPrice * quantity - discount;
    }
}