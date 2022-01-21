public class EmployeeBusinessLogic
{
    IEmployeeDataAccess _EmployeeDataAccess;
    public EmployeeBusinessLogic()
    {
        _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
    }

    public Employee GetEmployeeDetail(int id)
    {
        return _EmployeeDataAccess.GetEmployeeDetail(id);
    }
}