using StudentInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChange("Name");
            }
        }
        public MainWindowViewModel()
        {
            Name = "Rishi Arora";
        }

    }
}
