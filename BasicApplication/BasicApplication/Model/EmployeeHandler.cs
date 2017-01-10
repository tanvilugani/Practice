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
                    Salary = 61452,
                    Department = "IT"
                });

                _employees.Add(new Employee
                {
                    EmpId = 2,
                    Name = "Karan",
                    DOJ = DateTime.Now.Date,
                    Salary = 52480,
                    Department = "IT"
                });
            }
        }

        /// <summary>
        /// Function to add employee to the list.
        /// </summary>
        /// <param name="employee">employee to be added.</param>
        /// <returns>true if successfull else false.</returns>
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

        /// <summary>
        /// Function to delete Employee. Its not used at present.
        /// </summary>
        /// <param name="empId">Id of employee to be deleted.</param>
        /// <returns>True if succcessful else false.</returns>
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

        /// <summary>
        /// Function to get list of employees
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        /// <summary>
        /// Function to get details of a particular employee. Not used at present
        /// </summary>
        /// <param name="empId">Employee Id</param>
        /// <returns>Employee object</returns>
        public Employee GetEmployee(int empId)
        {
            return _employees.Where(e => e.EmpId == empId).FirstOrDefault();
        }
    }
}
