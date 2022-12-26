using System.Collections.Generic;

namespace WebApp3MVCwithDB.Models
{
    public interface IEmployeeRepository
    {
        //here we wil specify the operation to be allowed
        List<Employee> GetEmployees();
        Employee    GetEmployee(int id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);

    }
}
