// 
using (var context = new MyContext())
{
    //INPUT DATA TO DB
    var customerA = new Customer
    {
        CustomerId = 1,
        FirstName = "Mamang",
        LastName = "Daya",
        Address = "Banten"
    };

    var customerB = new Customer 
    {
        CustomerId = 2,
        FirstName = "Abah",
        LastName = "Sayuti",
        Address  = "Subang",
    };

    context.Customers.Add(customerA);
    context.Customers.Add(customerB);

    context.SaveChanges();


    //RETRIEVE DATA FROM DB
    var customers = context.Customers;

    foreach(var customer  in customers)
    {
        Console.WriteLine($"{customer.FirstName} {customer.LastName} - {customer.Address}");
    }
}