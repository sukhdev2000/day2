using System.Collections.Generic;
using Collection_practice2.Models;
using System;
using Collection_practice2.EmployeeList;
namespace Collection_practice2.EmployeeList
{
    public class EmployeesList:IEmployee
    {
        List<Employee> empList;
        public EmployeesList()
        {
            empList=new List<Employee>();
        }
        public int createEmployee(Employee employee)
        {
            empList.Add(employee);
            return 1;
        }
        public List<Employee> DisplayList()
        {
            return empList;
        }

        public Employee search(int index)
        {
            return empList.Find(e=>e.Id==index);
        } 
    }
}