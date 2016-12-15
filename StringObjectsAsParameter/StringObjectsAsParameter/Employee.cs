using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringObjectsAsParameter
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {
            Id = 1;
            Name = "Tanvi";
            Salary = 5678.90m;
        }

        /*
         The same scenarios apply for String. For string two things need to be kept in mind :
         *  1. Strings are immutable
         *  2. String a = "abc" is equivalent to new String("abc")
         */

        ///// <summary>
        ///// Case 1 : When object not passed using ref keyword and value of property of the object changes.
        ///// </summary>
        ///// <param name="employee"></param>
        //public void EditEmployee(Employee employee)
        //{
        //    employee.Name = "Karan";
        //}

        ///// <summary>
        ///// Case 2 : When object not passed using ref keyword and reference to the parameter object changes in 
        ///// function. Now formal parameter will be different from actual parameter.
        ///// </summary>
        ///// <param name="employee"></param>
        //public void EditEmployee(Employee employee)
        //{
        //    employee = new Employee()
        //    {
        //        Name = "John",
        //        Id = 2,
        //        Salary = 12345.6m
        //    };
        //}

        ///// <summary>
        ///// Case 3 : When object using ref keyword and value of property of the object changes.
        ///// </summary>
        ///// <param name="employee"></param>
        //public void EditEmployee(ref Employee employee)
        //{
        //    employee.Name = "Karan";
        //}

        /// <summary>
        /// Case 4 : When object is passed using ref keyword and reference to the parameter object changes in 
        /// function. Now formal parameter will be same as actual parameter.
        /// </summary>
        /// <param name="employee"></param>
        public void EditEmployee(ref Employee employee)
        {
            employee = new Employee()
            {
                Name = "John",
                Id = 2,
                Salary = 12345.6m
            };
        }

    }
}
