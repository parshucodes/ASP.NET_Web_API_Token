using jwt11april.Models;

namespace jwt11april.Interfaces
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeeDetails();
        public Employee GetEmployeeDetails(int id);
        public Employee AddEmployee(Employee employee);
        public Employee UpdateEmployee(int id, Employee employee);
        public bool DeleteEmployee(int id);

    }
}
