using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Console_App_Course_.Interfaces
{
    interface ICourseService
    {
        public List<Group> Groups { get; }
        public string CreateGroup();
        public void GetGroups();
        public void EditGroups();
        public void GetGroupsStudents();
        public void GetAllStudents();
        public string CreateStudent();

    }
}
