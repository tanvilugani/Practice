using BasicApplication.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApplication.ViewModel
{
    class EmployeesViewModel
    {
        private EmployeeHandler _employeeHandler;
        public ObservableCollection<Employee> Employees {get; set;}
        //List<Employee> Employees {get; set;}
        
        public EmployeesViewModel()
        {
            _employeeHandler = new EmployeeHandler();
            Employees = new ObservableCollection<Employee>(_employeeHandler.GetEmployees());
           // Employees = _employeeHandler.GetEmployees();
        }
    }
}
