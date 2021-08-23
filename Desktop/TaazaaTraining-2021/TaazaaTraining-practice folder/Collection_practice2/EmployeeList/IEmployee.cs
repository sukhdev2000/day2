using Collection_practice2.Models;
using System.Collections.Generic;
namespace Collection_practice2.EmployeeList
{
    public interface IEmployee
    {
         int createEmployee(Employee employee);
         List<Employee> DisplayList();
         Employee search(int index);
    }
}