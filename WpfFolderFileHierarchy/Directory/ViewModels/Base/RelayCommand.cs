using System;
using System.Windows.Input;

namespace WpfFolderFileHierarchy
{
    /// <summary>
    /// 
    ///  A basic command that run an Action
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Private Members

        // The action to run
        private Action mAction;

        #endregion


        #region Public Events

        /// <summary>
        /// The event that's fired when the <see cref="CanExecute(object)"/> value was changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion

        #region Constructor

        /// <summary>
        ///  Default Constructor
        /// </summary>
        public RelayCommand(Action action)
        {
            mAction = action;
        }

        #endregion

        #region Command Methods

        /// <summary>
        ///  A realy comand can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the commands Action
        /// </summary>
        /// <param name="parameter"></param>
        
        public void Execute(object parameter)
        {
            mAction();
        }

        #endregion

    }
}
