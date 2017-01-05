using BasicApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApplication.ViewModel
{
    class AddUpdateEmployeeViewModel
    {
        private EmployeeHandler _employeeHandler;

        public Employee Employee { get; set; }

        public AddUpdateEmployeeViewModel()
        {
            _employeeHandler = new EmployeeHandler();

            GetEmployee();
        }

        private void GetEmployee()
        {
            //Hardcoded for testing the functionality.
            Employee = _employeeHandler.GetEmployee(1);
        }

        
    }
}
