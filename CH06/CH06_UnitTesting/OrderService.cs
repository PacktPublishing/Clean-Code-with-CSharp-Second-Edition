namespace CH06_UnitTesting;

public class OrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Order GetOrderById(int id)
    {
        return _orderRepository.GetById(id);
    }
}