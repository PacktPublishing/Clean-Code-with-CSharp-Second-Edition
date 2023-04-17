namespace CH06_UnitTesting;

public interface IOrderRepository
{
    Order GetById(int id);
    void Add(Order order);
}

