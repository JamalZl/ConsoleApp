using Console_App_Course_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_App_Course_.Model
{
    class Group
    {
        public string No { get; set; }
        public ClassCategory Category { get; set; }
        public string IsOnline { get; set; }
        public int Limit { get; set; }
        public Student[] Students { get; set; }
        public Group(Student fullname,int no,ClassCategory category)
        {

        }
    }
}
