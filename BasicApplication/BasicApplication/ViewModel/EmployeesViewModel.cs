using BasicApplication.Messages;
using BasicApplication.Model;
using BasicApplication.Services;
using BasicApplication.Utility;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace BasicApplication.ViewModel
{
    class EmployeesViewModel : INotifyPropertyChanged
    {
        private EmployeeHandler _employeeHandler;
        private ObservableCollection<Employee> _employees;
        private Employee _selectedEmployee;
        private DialogService _dialogService;

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
            _dialogService = new DialogService();
            LoadData();
            LoadCommands();
            Messenger.Default.Register<UpdateEmployeeListMessage>(this, OnUpdateListMessageReceived);
        }

        private void LoadData()
        {
            Employees = new ObservableCollection<Employee>(_employeeHandler.GetEmployees());
        }

        private void OnUpdateListMessageReceived(UpdateEmployeeListMessage obj)
        {
            LoadData();
            _dialogService.CloseAddEmployeeDialog();
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

        /// <summary>
        /// Function to open Add Employee Dialog.
        /// </summary>
        /// <param name="obj"></param>
        public void AddEmployee(object obj)
        {
            //Messenger.Default.Send<Employee>(_selectedEmployee);
            _dialogService.ShowAddEmployeeDialog();
        }

        /// <summary>
        /// Confirm if Employee can be added.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool CanAddEmployee(object obj)
        {
            return true;
        }
    }
}
