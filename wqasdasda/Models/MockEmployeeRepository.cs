﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wqasdasda.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="Mary",Department=Dept.HR,Email="mary@email.com"},
                new Employee(){Id=2,Name="John",Department=Dept.IT,Email="john@email.com"},
                new Employee(){Id=3,Name="Sam",Department=Dept.IT,Email="sam@email.com"}
            };
        }

        public Employee Add(Employee employee)
        {
           employee.Id = _employees.Max(x => x.Id) + 1;
            _employees.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employees.FirstOrDefault(x => x.Id == id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employees;
        }

        public Employee GetEmployee(int Id)
        {
            return _employees.FirstOrDefault(x => x.Id==Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employees.FirstOrDefault(x => x.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
