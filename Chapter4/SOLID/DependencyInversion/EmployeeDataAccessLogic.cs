public class EmployeeDataAccess : IEmployeeDataAccess
{
    public Employee GetEmployeeDetail(int id)
    {
        Employee emp = new Employee()
        {
            ID = id,
            Name = "Bambang",
            Department = "Administration",
            Salary = 1000000
        };
        return emp;
    }


}

// with Dependency Inversion : 
// use interface to make loosly coupled Class