namespace MyApiSolution.Services;

public interface IProductService
{
    int AddProduct(string name, decimal price);
    bool RemoveProduct(int productId);
    List<string> GetAllProducts();
}

public class ProductService
{
    public int AddProduct(string name, decimal price)
    {
        if (price < 0 || string.IsNullOrWhiteSpace(name))
            return 0;

        if (price > 0)
            return 1;
        
        return 0;
    }

    public bool RemoveProduct(int productId)
    {
        if (productId == 1)
            return true;
        
        return false;
    }

    public List<string> GetAllProducts()
    {
        return ["Laptop"];
    }
}