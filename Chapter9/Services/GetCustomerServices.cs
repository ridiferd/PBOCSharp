public interface IGetCustomerServices{
    List<Customer> Get();
    Customer Detail(int ID);

}

public class GetCustomerServices : IGetCustomerServices {
    public List<Customer> Get(){
        return CustomerRepo();
    }

    public Customer Detail(int ID)
    {
        var repo = CustomerRepo();

        return repo.FirstOrDefault(x =>x.Id == ID);
    }


    private List<Customer> CustomerRepo()
    {
        List<Customer> customers = new List<Customer>();
        
        customers.Add(new Customer{
            Id = 1,
            Firstname = "Alehandro",
            LastName = "Maldini",
            Address = "Soul Ring Boulevard"
        });
        customers.Add(new Customer{
            Id = 2,
            Firstname = "Desperado",
            LastName = "Quintana",
            Address = "Lake Resort Adelaide"
        });
        customers.Add(new Customer{
            Id = 3,
            Firstname = "Helva",
            LastName = "Laguna Laputa",
            Address = "Sunset Beach"
        });
        customers.Add(new Customer{
            Id = 4,
            Firstname = "Doremifa",
            LastName = "Solasido",
            Address = "Gi Key Street"
        });
        customers.Add(new Customer{
            Id = 5,
            Firstname = "Alphabet",
            LastName = "Metaverse",
            Address = "Silicon Valley"
        });
        return customers;

    }
}