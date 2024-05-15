using DLL.Interfaces;
using DLL.Models;
using DLL.Repos;

namespace DLL
{
    public class DataAccessFactory
    {
        public static IRepo<Employee, int, Employee> EmployeeData()
        {
            return new AdminRepo();
        }
    }
}
