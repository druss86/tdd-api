namespace MyApiSolution.Services;

public interface IOrderService
{
    int PlaceOrder(int customerId, List<int> productIds);
    bool CancelOrder(int orderId);
    List<int> GetOrderDetails(int orderId);
}

public class OrderService
{
    public int PlaceOrder(int customerId, List<int> productIds)
    {
        if (customerId == 1 && productIds.Any())
            return productIds.Count;
        
        return 0;
    }

    public bool CancelOrder(int orderId)
    {
        if (orderId == 1)
            return true;
        
        return false;
    }

    public List<int> GetOrderDetails(int orderId)
    {
        if (orderId == 1)
            return [1, 2];
        
        return [];
    }

}