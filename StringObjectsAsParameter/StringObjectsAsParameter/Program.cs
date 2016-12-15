using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringObjectsAsParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            
            #region Object with no ref keyword used for parameter
            
            Console.WriteLine("Value of employee before function call : {0}", employee.Name);

            //employee.EditEmployee(employee); 
            employee.EditEmployee(ref employee);
            
            Console.WriteLine("Value of employee after function call : {0}", employee.Name);
            #endregion

            Console.ReadKey();
        }
    }
}
