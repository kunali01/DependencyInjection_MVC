using DIPatternDemo.Models;

namespace DIPatternDemo.Services
{
    public interface IEmployeeService
    {
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetAllEmployees();
    }
}
