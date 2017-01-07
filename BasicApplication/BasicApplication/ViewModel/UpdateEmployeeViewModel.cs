using BasicApplication.Model;

namespace BasicApplication.ViewModel
{
    class UpdateEmployeeViewModel
    {
        private EmployeeHandler _employeeHandler;

        public Employee Employee { get; set; }

        public UpdateEmployeeViewModel()
        {
            _employeeHandler = new EmployeeHandler();
        }

        private void GetEmployee()
        {
            //Hardcoded for testing the functionality.
            Employee = _employeeHandler.GetEmployee(1);
        }
    }
}
