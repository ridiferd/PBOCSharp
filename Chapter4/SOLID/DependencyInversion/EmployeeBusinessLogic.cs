public class EmployeeBusinessLogic
{
    IEmployeeDataAccess _EmployeeDataAccess;
    public EmployeeBusinessLogic()
    {
        _EmployeeDataAccess = DataAccessFactory.GetEmployeeDAtaAccessObj();
    }

    public Employee GetEmployeeDetail(int id)
    {
        return _EmployeeDataAccess.GetEmployeeDetail(id);
    }
}