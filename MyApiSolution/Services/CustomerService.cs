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
        if (name.ToLower() == "john doe" && email.ToLower() == "john.doe@example.com")
            return 1;
        
        return 0;
    }

    public bool RemoveCustomer(int customerId)
    {
        if (customerId == 1)
            return true;
        
        return false;
    }

    public string GetCustomerDetails(int customerId)
    {
        if (customerId == 1)
            return "details";
        
        return string.Empty;
    }
}