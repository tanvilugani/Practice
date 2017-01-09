using BasicApplication.Model;
using BasicApplication.Utility;
using BasicApplication.View;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace BasicApplication.ViewModel
{
    class EmployeesViewModel : INotifyPropertyChanged
    {
        private EmployeeHandler _employeeHandler;
        private ObservableCollection<Employee> _employees;

        private Employee _selectedEmployee;

        public ICommand AddEmployeeCommand { get; set; }

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
            LoadCommands();
        }

        private void LoadCommands()
        {
            AddEmployeeCommand = new CustomCommand(AddEmployee, CanAddEmployee);
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddEmployee(object obj)
        {
            Messenger.Default.Send<Employee>(_selectedEmployee);
        }

        private bool CanAddEmployee(object obj)
        {
            return true;
        }
    }
}
