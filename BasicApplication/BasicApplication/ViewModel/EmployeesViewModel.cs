using BasicApplication.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BasicApplication.ViewModel
{
    class EmployeesViewModel : INotifyPropertyChanged
    {
        private EmployeeHandler _employeeHandler;
        private ObservableCollection<Employee> _employees;

        private Employee _selectedEmployee;

        public Employee SelectedEmployee
        {
            get
            {
                return _selectedEmployee;
            }
            set
            {
                _selectedEmployee = value;
                RaisePropertyChanged("SelectedEmployee");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Employee> Employees
        {
            get
            {
                return _employees;
            }

            set
            {
                _employees = value;
                RaisePropertyChanged("Employees");
            }
        }

        public EmployeesViewModel()
        {
            _employeeHandler = new EmployeeHandler();
            Employees = new ObservableCollection<Employee>(_employeeHandler.GetEmployees());
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddEmployee(object obj)
        { 
            //TODO : add code
        }
    }
}
