namespace MyApiSolution.Services;

public interface ICustomerService
{
    int AddCustomer(string name, string email);
    bool RemoveCustomer(int customerId);
    string GetCustomerDetails(int customerId);
}

public class CustomerService : ICustomerService
{
    public int AddCustomer(string name, string email)
    {
        // Stub: Add logic here
        return 0; // Placeholder
    }

    public bool RemoveCustomer(int customerId)
    {
        // Stub: Add logic here
        return false; // Placeholder
    }

    public string GetCustomerDetails(int customerId)
    {
        // Stub: Add logic here
        return ""; // Placeholder
    }
}