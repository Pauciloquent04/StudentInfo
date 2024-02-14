using StudentInfo.Commands;
using StudentInfo.Models;
using StudentInfo.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace StudentInfo.ViewModels
{
    public class StudentDetailsViewModel : BaseViewModel
    {

        public ObservableCollection<Student> Students { get; set; }

        public string[] EducationList { get; set; }

        public List<string> CityList { get; set; }


        public StudentDetailsViewModel()
        {
            Students = StudentManager.GetStudents();
            EducationList = new string[] { "SSC", "HSC", "Bachelors", "Masters", "PHD" };
            CityList = StudentManager.City(Students);

            //Name = Students[0].Name;
            //Education = Students[0].Education;
            //City = Students[0].City;
            //SubmitCommand = new RelayCommand(ExecuteSubmitCommand, CanExecuteSubmitCommand);

        }

        private ICommand submitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if (submitCommand == null)
                    submitCommand = new RelayCommand(p => StudentManager.OnShow(Students[0]));
                return submitCommand;
            }
        }

    }

    

}

        /*
        private void ExecuteSubmitCommand(object parameter)
        {
            MessageBox.Show("Name: " + Name);
        }

        private bool CanExecuteSubmitCommand(object parameter)
        {
            if (string.IsNullOrEmpty(Name))
            {
                return false;
            }

            return true;
        }
        */
    
    /*
    public class GenderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((string)parameter == (string)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? parameter : null;
        }
    }
    */