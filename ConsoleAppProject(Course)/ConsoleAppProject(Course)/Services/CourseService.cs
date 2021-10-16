﻿using ConsoleAppProject_Course_.Enums;
using ConsoleAppProject_Course_.Interfaces;
using ConsoleAppProject_Course_.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject_Course_.Services
{
    class CourseService : ICourseService
    {
        private List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        public string CreateGroup(ClassCategory category)
        {
            Group group = new Group(category);
            _groups.Add(group);
            return group.No;

        }

        public string CreateStudent()
        {
            throw new NotImplementedException();
        }

        public void EditGroups()
        {
            throw new NotImplementedException();
        }

        public void GetAllStdents()
        {
            throw new NotImplementedException();
        }

        public void GetGroups()
        {
            throw new NotImplementedException();
        }

        public void GetGroupStudent()
        {
            throw new NotImplementedException();
        }
    }
}
