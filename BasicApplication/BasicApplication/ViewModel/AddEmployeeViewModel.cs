using BasicApplication.Messages;
using BasicApplication.Model;
using BasicApplication.Services;
using BasicApplication.Utility;
using System.Windows.Input;

namespace BasicApplication.ViewModel
{
    class AddEmployeeViewModel
    {
        private EmployeeHandler _employeeHandler;
        private DialogService _dialogService;

        public Employee Employee { get; set; }
        public ICommand AddCommand { get; set; }

        public AddEmployeeViewModel()
        {
            _employeeHandler = new EmployeeHandler();
            LoadCommands();

            //Messenger.Default.Register<Employee>(this, OnEmployeeReceived);

            Employee = new Employee();
            _dialogService = new DialogService();
        }

        //private void OnEmployeeReceived(Employee employee)
        //{
        //    Employee = employee;
        //}

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
            var isEmployeeAdded = _employeeHandler.AddEmployee(Employee);
            Messenger.Default.Send<UpdateEmployeeListMessage>(new UpdateEmployeeListMessage());
        }

    }
}
