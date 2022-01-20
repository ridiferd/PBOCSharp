/// Without Interface Segregation Principle
public interface IPrinterTasks
{
    void Print(string PrintContent);
    void Scan(string ScanContent);
    void Fax(string FaxContent);
    void PrintDuplex(string PrintDuplexContent);
}

/// With Interface Segregation Principle
public interface IPrinterTasks
{
    void Print(string PrintContent);
    void Scan(string ScanContent);
}

public interface IFaxTasks
{
    void Fax(string content);
}

public interface IPrintDuplexTasks
{
    void PrintDuplex(string content);
}
