using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public string City { get; set; }
        public string Gender { get; set; }

        public string Education { get; set; }

        public Student()
        {
            
        }


    }
}
