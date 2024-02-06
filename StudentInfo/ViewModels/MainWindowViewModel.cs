using StudentInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Student _model;
        private string _name;

        public MainWindowViewModel()
        {
            _model = new Student()
            {
                Name = "Rishi Arora"
            };
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChange("Name");
            }
        }

        private void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
