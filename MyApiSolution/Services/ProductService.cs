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
        // Stub: Add logic here
        return 0; // Placeholder
    }

    public bool RemoveProduct(int productId)
    {
        // Stub: Add logic here
        return false; // Placeholder
    }

    public List<string> GetAllProducts()
    {
        // Stub: Add logic here
        return new List<string>(); // Placeholder
    }
}