using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace testapp.Model
{
    public class CommandAction : ICommand
    {

        Action action;
        Action<object> actionObject;
        public CommandAction(Action action)
        {
            this.action = action;
        }
        public CommandAction(Action<object> actionObject)
        {
            this.actionObject = actionObject;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (actionObject != null)
            {
                return parameter != null;
            }
            return true;
        }

        public void Execute(object parameter)
        {
            action?.Invoke();
            actionObject?.Invoke(parameter);
        }
    }
}
