using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace StudCurRegistration
{
   public static class School
    {
        private static SchoolContext db = new SchoolContext();
        /// <summary>
        /// create a student registration
        /// </summary>
        /// <param name="studName"> Student Name</param>
        /// <param name="emailaddress">Student Email Address</param>   
        /// <param name="enrollamt">Registration /Enrollment Amount</param>
        /// <returns> New Enrollment details of Student</returns>
        public static studInfo createNewStudEnroll(
            string studentName,
            string emailaddress,
            string address,
            long phonenumber,
           // string coursename,            
            TypeofGender gender = TypeofGender.Female,
            decimal enrollamt = 0)
        {
            //object Initialization

            var studentenroll = new studInfo
            {
                StudFirstName = studentName,
                StudEmailAdd = emailaddress,
                StudAddress = address,
                StudphNum = phonenumber,
                StudGender = gender
            };            

            db.Students.Add(studentenroll);
            db.SaveChanges();
            if (enrollamt > 0)
            {
                studentenroll.StudEnrollAmt(enrollamt);
            }            
            //createstudentregCourse(studentenroll.StudentId, coursename);
            return studentenroll;
        }
        
        public static void removeStudent(int studId)
        {
            var studCurInfo = db.Students.Where(a => a.StudentId == studId).SingleOrDefault();
            db.Students.Remove(studCurInfo);
            db.SaveChanges();
        }

        public static void GetAllStudentsbycourse(string coursename)
        {
            var students = from student in db.Students
                           from cs in db.Courses.Where
                           (cs => cs.CourseName == coursename && student.StudentId == cs.StudentId)
                           select student;

            foreach (var a in students)
            {
                Console.WriteLine($"StudentID: {a.StudentId}, " +
                 $"StudentName: {a.StudFirstName}");                  
            }
        }
       

        public static void PrintAllstudentdetails()
        {
            if (db.Students != null)
            {
                var viewlist = db.Students.Join(db.Courses, s => s.StudentId,
                    c => c.StudentId, (s, c)=> new
                    {
                        studnetId= s.StudentId,
                        studentName = s.StudFirstName,
                        gender = s.StudGender,
                        amount = s.StudEnrollFee,
                        email = s.StudEmailAdd,
                        courseName = c.CourseName,
                        courseDate = c.CourseDate,
                        coursecode = c.CourseCode 
                        
                });
                                             
                foreach (var a in viewlist)
                {
                    Console.WriteLine($"StudentID: {a.studnetId}, " +
                     $"StudentName: {a.studentName}, " +
                     $"Fee: {a.amount:C}, " +
                     $"CourseName: {a.courseName}, " +
                    // $"Course Code: {a.coursecode}, "  +
                     $"Email: {a.email}, " +
                     $"Gender: {a.gender}, " +
                     $"CourseDate: {a.courseDate}");
                }
            }
            else
            {
                Console.WriteLine("Student List is Empty");

            }

        }

        public static IEnumerable<studInfo> GetAllstudentsByEmailAddress(string emailAddress)
        { 
            return db.Students.Where(a => a.StudEmailAdd == emailAddress);
        }        

        public static Courses createCourse(int studid,string coursename)
        {
            var courses = new Courses
            {
                CourseName = coursename,
                StudentId = studid,
                CourseDate = DateTime.UtcNow 
            };
            db.Courses.Add(courses);
            db.SaveChanges();
            return courses;
        }

        public static studInfo GetStudentId(int studentid)
        {
            return db.Students.SingleOrDefault(a => a.StudentId == studentid);
        }

        public static void createStudCourReg(string studentName,string emailaddress,string address,
                             long phonenumber,TypeofGender gender,decimal enrollamt,string coursename)
        {
            createNewStudEnroll(studentName, emailaddress, address, phonenumber, TypeofGender.Male, enrollamt);
            
            //createCourse(, coursename);
        }
    }
}
