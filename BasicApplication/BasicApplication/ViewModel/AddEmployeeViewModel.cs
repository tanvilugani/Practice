using BasicApplication.Model;
using BasicApplication.Utility;
using System.Windows.Input;

namespace BasicApplication.ViewModel
{
    class AddEmployeeViewModel
    {
        private EmployeeHandler _employeeHandler;

        public Employee Employee { get; set; }
        public ICommand AddCommand { get; set; }

        public AddEmployeeViewModel()
        {
            _employeeHandler = new EmployeeHandler();
            LoadCommands();
        }

        private void LoadCommands()
        {
            AddCommand = new CustomCommand(AddEmployee, CanAddEmployee);
        }

        private bool CanAddEmployee(object obj)
        {
            return true; 
        }
 
        private void AddEmployee(object obj)
        { 
            var isEmployeeAdded = _employeeHandler.AddEmployee((Employee)obj);
        }
     }
}
