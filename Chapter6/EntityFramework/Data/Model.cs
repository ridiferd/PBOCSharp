
using System.ComponentModel.DataAnnotations.Schema;

public class Customer
{
    public int CustomerId { get; set; }
    public string FirstName {get;set;}
    public string LastName { get; set; }
    public string Address { get; set; }
    public virtual List<Invoice> Invoices { get; set; }
}

public class Invoice {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int CustomerId { get; set; }

    [ForeignKey("CustomerId")]
    public virtual Customer customer { get; set; }
}