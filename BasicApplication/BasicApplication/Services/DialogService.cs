using BasicApplication.View;
using System.Windows;

namespace BasicApplication.Services
{
    class DialogService
    {
        private Window _addEmployeeView = null;

        /// <summary>
        /// Function to show Add Employee Dialog Window.
        /// </summary>
        public void ShowAddEmployeeDialog()
        {
            _addEmployeeView = new AddEmployee();
            _addEmployeeView.ShowDialog();
        }

        /// <summary>
        /// Function to close Add Employee Dialog window.
        /// </summary>
        public void CloseAddEmployeeDialog()
        {
            if(_addEmployeeView != null)
            _addEmployeeView.Close();
        }

    }
}
