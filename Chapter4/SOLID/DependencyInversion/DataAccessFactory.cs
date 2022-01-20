public class DataAccessFactory 
{
    public static IEmployeeDataAccess GetEmployeeDataAccessObj()
    {
        return new EmployeeDataAccess();
    }
}

// using Dependency inversion to this code is change static from calling EmployeeDataAccess directly to IEmployeeDataAccess