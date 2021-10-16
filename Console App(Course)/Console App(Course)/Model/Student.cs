using Console_App_Course_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App_Course_.Model
{
    class Student
    {
        public string FullName { get; set; }
        public EducationType EduCategory { get; set; }
        public Student(string fullname,Group groupNo,EducationType edutype)
        {
            FullName = fullname;
            EduCategory = edutype;
        }

    }
}
