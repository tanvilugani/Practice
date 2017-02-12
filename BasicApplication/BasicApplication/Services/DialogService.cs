using BasicApplication.View;
using System.Windows;

namespace BasicApplication.Services
{
    class DialogService
    {
        private Window _addEmployeeView = null;
        private Window _updateEmployeeView = null;

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

        /// <summary>
        /// Function to show Update Employee Dialog Window.
        /// </summary>
        public void ShowUpdateEmployeeDialog()
        {
            _updateEmployeeView = new UpdateEmployee();
            _updateEmployeeView.ShowDialog();
        }

        /// <summary>
        /// Function to close Update Employee Dialog window.
        /// </summary>
        public void CloseUpdateEmployeeDialog()
        {
            if (_updateEmployeeView != null)
                _updateEmployeeView.Close();
        }

    }
}
