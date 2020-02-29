﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfDialog.Helper
{
    public sealed class DelegateCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;

        public string CommandName { get; }

        public DelegateCommand(Action execute, string commandName) : this(execute, () => true, commandName)
        {
        }
        public DelegateCommand(Action execute, Func<bool> canExecute, string commandName)
        {
            CommandName = commandName;
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute()
        {
            return _canExecute();
        }

        public void Execute()
        {
            _execute();
        }

        /// <inheritdoc/>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                return;
            }
            remove
            {
                return;
            }
        }

        #region ICommand
        /// <inheritdoc/>
        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute();
        }
        /// <inheritdoc/>
        void ICommand.Execute(object parameter)
        {
            Execute();
        }
        #endregion
    }
}
