using jwt11april.Context;
using jwt11april.Interfaces;
using jwt11april.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace jwt11april.Services
{
    public class EmployeeSerivce : IEmployeeService
    {
        private readonly JwtContext _jwtContext;
        public EmployeeSerivce(JwtContext jwtContext)
        {
            this._jwtContext = jwtContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            var emp = _jwtContext.Employees.Add(employee);
            _jwtContext.SaveChanges();
            return emp.Entity;

        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                var emp = _jwtContext.Employees.SingleOrDefault(x => x.Id == id);
                if (emp == null)
                {
                    throw new Exception("User not found");
                }
                else
                {
                    _jwtContext.Employees.Remove(emp);
                    _jwtContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex) { return false; }
        }

        public List<Employee> GetEmployeeDetails()
        {
            var emp = _jwtContext.Employees.ToList();
            return emp;
        }

        public Employee GetEmployeeDetails(int id)
        {
            var emp = _jwtContext.Employees.SingleOrDefault(x => x.Id == id);
            return emp;
        }
        public Employee UpdateEmployee(Employee employee)
        {
            var emp = _jwtContext.Employees.Update(employee);
            _jwtContext.SaveChanges();
            return emp.Entity;
        }
    }
}
