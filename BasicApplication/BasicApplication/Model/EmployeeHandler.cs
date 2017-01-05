using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicApplication.Model
{
    class EmployeeHandler
    {
        private static List<Employee> _employees;

        public EmployeeHandler()
        {
            if (_employees == null)
                _employees = new List<Employee>();

            if (_employees.Count == 0)
            {
                _employees.Add(new Employee
                {
                    EmpId = 1,
                    Name = "Tanvi",
                    DOJ = DateTime.Now.Date,
                    Salary = 5248,
                    Department = "IT"
                });

                _employees.Add(new Employee
                {
                    EmpId = 2,
                    Name = "Tanvi",
                    DOJ = DateTime.Now.Date,
                    Salary = 5248,
                    Department = "IT"
                });
            }
        }

        public bool AddEmployee(Employee employee)
        {
            try
            {
                _employees.Add(employee);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteEmployee(int empId)
        {
            try
            {
                var employee = _employees.Where(e => e.EmpId == empId).FirstOrDefault();

                if (employee == null)
                {
                    //to signify employee does not exist.
                    return false;
                }
                else
                {
                    _employees.Remove(employee);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

    }
}
