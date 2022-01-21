// Without Interface Segregation Principle

// public class LiquidInkjetPrinter : IPrinterTasks
// {
//     public void Print(string PrintContent)
//     {
//         Console.WriteLine("Print Done");
//     }

//     public void Scan(string ScanContent)
//     {
//         Console.WriteLine("Scan Content");
//     }

//     public void Fax(string FaxContent)
//     {
//         throw new NotImplementedException();
//     }

//     public void PrintDuplex(string PrintDuplexContent)
//     {
//         throw new NotImplementedException();
//     }
// }

// With Interface Segregation Principle

public class LiquidInkjetPrinter : IPrinterTasks
{
    public void Print(string PrintContent)
    {
        Console.WriteLine("Print Done");
    }

    public void Scan(string ScanContent)
    {
        Console.WriteLine("Scan content");
    }
}