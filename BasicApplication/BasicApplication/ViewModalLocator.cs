using BasicApplication.ViewModel;

namespace BasicApplication
{
    class ViewModalLocator
    {
        private static EmployeesViewModel _employeesViewModel = new EmployeesViewModel();
        private static AddEmployeeViewModel _addEmployeeViewModel = new AddEmployeeViewModel();
        private static UpdateEmployeeViewModel _updateEmployeeViewModel = new UpdateEmployeeViewModel();

        public static EmployeesViewModel EmployeesViewModel
        {
            get
            {
                return _employeesViewModel;
            }
        }

        public static AddEmployeeViewModel AddEmployeeViewModel
        {
            get
            {
                return _addEmployeeViewModel;
            }
        }

        public static UpdateEmployeeViewModel UpdateEmployeeViewModel
        {
            get
            {
                return _updateEmployeeViewModel;
            }
        }

    }
}
