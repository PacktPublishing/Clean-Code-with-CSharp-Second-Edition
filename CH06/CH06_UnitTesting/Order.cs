namespace CH06_UnitTesting;

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public virtual double TotalPrice { get; set; }
}
