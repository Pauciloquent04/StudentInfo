using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentInfo.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private Action<object> Excute {  get; set; }
        private Func<object, bool> CanExcute {  get; set; }


        public RelayCommand(Action<object> execute)
        {
            Excute = execute;
            CanExcute = null;
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            Excute = execute;
            CanExcute = canExecute;
        }

        //In our view, when we invoke a command. Below two methods will execute.
        public bool CanExecute(object parameter)
        {
            return CanExcute == null || CanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            Excute(parameter);
        }
    }
}
