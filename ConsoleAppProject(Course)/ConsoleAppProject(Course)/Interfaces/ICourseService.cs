using ConsoleAppProject_Course_.Enums;
using ConsoleAppProject_Course_.Model;
using System;
using System.Collections.Generic;
using System.Text;

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
