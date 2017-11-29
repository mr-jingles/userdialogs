﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Acr.UserDialogs
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        readonly Action action;

        public Command(Action action)
        {
            this.action = action;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.action();
        }
    }
}
