using ConsoleAppProject_Course_.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleAppProject_Course_.Interfaces
{
    interface ICourseService
    {
        public List<Group> Groups { get; }
        public string CreateGroup(ClassCategory category);
        public void GetGroups();
        public void EditGroups();
        public void GetGroupStudent();
        public void GetAllStdents();
        public string CreateStudent();

    }
}
