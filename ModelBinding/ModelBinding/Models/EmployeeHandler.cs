using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBinding.Models
{
    public class EmployeeHandler
    {
        public static List<Employee> Employees { get; set; }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public bool AddEmployee(Employee employee)
        {
            try
            {
                if (Employees == null)
                {
                    Employees = new List<Employee>();
                }

                Employees.Add(employee);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public IList<Employee> DeleteEmployee(List<Employee> employees)
        {
            /*Removing from foreach wont wont because it throws exception 
            IEnumerable modified and hence this wont work*/
            //foreach (var employee in employees)
            //{
            //    if (employee.IsSelected)
            //    {
            //        employees.Remove(employee);
            //    }
            //}

            employees.RemoveAll(e => e.IsSelected == true);

            return employees;
        }
    }
}