using BasicApplication.Messages;
using BasicApplication.Model;
using BasicApplication.Utility;
using System.ComponentModel;

namespace BasicApplication.ViewModel
{
    //Not currently being used.
    class UpdateEmployeeViewModel : INotifyPropertyChanged
    {
        private EmployeeHandler _employeeHandler;
        private Employee _selectedEmployee;
        public event PropertyChangedEventHandler PropertyChanged;

        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }

            set
            {
                _selectedEmployee = value;
                RaisePropertyChanged("SelectedEmployee");
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public UpdateEmployeeViewModel()
        {
            _employeeHandler = new EmployeeHandler();
            Messenger.Default.Register<Employee>(this, OnEmployeeReceived);
        }

        public void OnEmployeeReceived(Employee selectedEmployee)
        {
            SelectedEmployee = selectedEmployee;
        }

        private bool CanUpdateEmployee(object obj)
        {
            return true;
        }

        private void UpdateEmployee(object obj)
        {
             _employeeHandler.UpdateEmployee(SelectedEmployee);
            Messenger.Default.Send<UpdateEmployeeListMessage>(new UpdateEmployeeListMessage());
        }
    }
}
