using HelpCode.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpCode.Data
{
    public class StudentAccess
    {
        private readonly List<Student> _students;

        public StudentAccess()
        {
            _students = new List<Student>();
        }

        public List<Student> DemoStudents
        {
            get
            {
                _students.Add(new Student(1, "Hans", "Hansen"));
                _students.Add(new Student(1, "Ole", "Olsen"));
                return _students;
            }
        }
    }
}
