namespace CH3.Coupling.LooseCoupling;

public class Order
{
    private readonly IDiscountCalculator discountCalculator;

    public Order(IDiscountCalculator discountCalculator)
    {
        this.discountCalculator = discountCalculator;
    }

    public decimal CalculateTotalPrice(decimal unitPrice, int quantity)
    {
        decimal discount = discountCalculator.CalculateDiscount(unitPrice, quantity);
        return unitPrice * quantity - discount;
    }
}