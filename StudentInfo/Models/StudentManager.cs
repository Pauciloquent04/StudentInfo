using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace StudentInfo.Models
{
    public class StudentManager
    {
        public static ObservableCollection<Student> _StudentsData = new ObservableCollection<Student>()
        {
            new Student{ Id = 1, Name = "Rishi Arora", Education = "Bachelors", Gender = "M", City = "Vadodara"},
            new Student{ Id = 3, Name = "Rohit Sharma", Education = "Bachelors", Gender = "M", City = "Mumbai"},
            new Student{ Id = 7, Name = "Pratham", Education = "HSC", Gender = "M", City = "Ahmedabad"},
            new Student{ Id = 2, Name = "Virat Kohli", Education = "HSC", Gender = "M", City = "Delhi"},
            new Student{ Id = 9, Name = "Dhruv", Education = "SSC", Gender = "M", City = "Rajkot"},
            new Student{ Id = 6, Name = "Aman", Education = "HSC", Gender = "M", City = "Rhotak"},
            new Student{ Id = 8, Name = "Mihir", Education = "Masters", Gender = "M", City = "Bhavnagar"},
            new Student{ Id = 4, Name = "KL Rahul", Education = "Bachelors", Gender = "M", City = "Bangalore"},
            new Student{ Id = 5, Name = "Rohan", Education = "Masters", Gender = "M", City = "Pune"},
            new Student{ Id = 10, Name = "Aayush", Education = "SSC", Gender = "M", City = "Vadodara"}
        };


        public static ObservableCollection<Student> GetStudents()
        {
            Sort(_StudentsData);
            return _StudentsData;
        }

        public void AddStudent(Student student)
        {
            _StudentsData.Add(student);
            Sort(_StudentsData);
        }

        public static List<string> City(ObservableCollection<Student> students)
        {
            List<string> city = new List<string>();
            foreach (Student student in students)
            {
                if (!city.Contains(student.City))
                {
                    city.Add(student.City);
                }
            }
            return city;
        }

        public static void OnShow(Student objStudent)
        {
            MessageBox.Show("Name: " + objStudent. Name
                + "\nEducation: " + objStudent.Education
                + "\nGender: " +objStudent.Gender
                + "\nCity: " + objStudent.City);
        }

        public static void Sort(ObservableCollection<Student> students)
        {
            Student temp;
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = i+1; j < students.Count; j++)
                {
                    if (students[i].Id > students[j].Id)
                    {
                        temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }
    }

    /*class Comp : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null || y == null) return 0;
            return x.CompareTo(y);
        }
    }*/
}
