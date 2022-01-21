using System.Collections.Generic;

public interface IGetCustomers
{
    public List<Customer> Get();
}

public class GetCustomers : IGetCustomers
{
    public List<Customer> Get()
    {
        var result = new List<Customer>();

        result.Add(new Customer()
        {
            Firstname = "Alexander",
            LastName = "Frostbite",
            Address = "Sweden Street"
        });

        result.Add(new Customer()
        {
            Firstname = "Juliano",
            LastName = "Maradondo",
            Address = "Venezuela Street"
        });

        result.Add(new Customer()
        {
            Firstname = "Dominique",
            LastName = "Elizabeth",
            Address = "New Jersey Steet"
        });

        return result;
    }

}