using System;
using Collection_practice2.Models;
using Collection_practice2.EmployeeList;
using System.Collections.Generic;
namespace Collection_practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesList employeesList=new EmployeesList();
            Employee employee=new Employee();
            employee.Id=100;
            employee.Name="Sukhdev";
            employeesList.createEmployee(employee);


            Employee employee1=new Employee();
            employee1.Id=101;
            employee1.Name="Das Sukhdev";
            employeesList.createEmployee(employee1);
            

            /* int temp=employeesList.createEmployee(employee);
            if(temp==1)
            {
                System.Console.WriteLine("Added Successfully");
            } */
            
            List<Employee> employees= employeesList.DisplayList();
            int count=employees.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(employees[i].Id+" "+employees[i].Name);
            }
            int targetID=101;
            Employee obj=employeesList.search(targetID);
            Console.WriteLine(obj.Id+" "+obj.Name);
        }
    }
}
