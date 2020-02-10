using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudCurRegistration
{
    static class School
    {
        private static List<studInfo> studList = new List<studInfo>();
        
        /// <summary>
        /// create a student registration
        /// </summary>
        /// <param name="studName"> Student Name</param>
        /// <param name="emailaddress">Student Email Address</param>
        /// <param name="coursename">Course Name</param>
        /// <param name="enrollamt">Registration /Enrollment Amount</param>
        /// <returns> New Enrollment details of Student</returns>
        public static studInfo createNewStudEnroll(
            string studentName,
            string emailaddress,
            string coursename,
            TypeofGender gender = TypeofGender.Female,
            decimal enrollamt = 0)
        {
            //object Initialization
            var studentenroll = new studInfo
            {
                StudFirstName = studentName,
                StudEmailAdd = emailaddress,
                StudGender = gender,
                CourseName = coursename
            };
            if (enrollamt > 0)
            {
                studentenroll.StudEnrollAmt(enrollamt);
            }
            studList.Add(studentenroll);
            return studentenroll;
        }
        
        public static void removeStudent(int studId)
        {
            var studCurInfo = studList.Where(a => a.StudentId == studId).SingleOrDefault ();
            studList.Remove(studCurInfo);
        }
                
        public static void PrintAllstudentdetails()
        {
            if (studList != null)
            {
                foreach (var a in studList)
                {
                    Console.WriteLine($"StudentID: {a.StudentId}, " +
                     $"StudentName: {a.StudFirstName}, " +
                     $"Fee: {a.StudEnrollFee:C}, " +
                     $"CourseName: {a.CourseName}," +
                     $" Course Code:{a.CourseCode}" +
                     $" CourseDate: {a.StudStartDate}, " +
                     $"Email: {a.StudEmailAdd} ," +
                     $"Gender: {a.StudGender}");

                }
            }
            else 
            {
                Console.WriteLine("Student List is Empty");
            }
        }              
        
    }

}


 

        

