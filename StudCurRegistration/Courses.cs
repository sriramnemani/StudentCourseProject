using System;
using System.Collections.Generic;
using System.Text;

namespace StudCurRegistration
{
    class Courses
    {
        //private static int lastcourcode = 99;
        public int CourseCode { get; set; }
        public DateTime CourseDate { get; set; }
        public string CourseName { get; set; }
        public decimal Amount { get; set; }
        public int StudentId { get; set; }
        public studInfo  StudInfo { get; set; }
    }
}
