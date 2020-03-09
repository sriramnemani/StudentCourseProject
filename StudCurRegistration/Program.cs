using System;
using System.Data;
using System.Collections.Generic;
namespace StudCurRegistration
{
   public class Program
    {
        static void Main(string[] args)
        {
            var students = new studInfo();
            var scourses = new Courses();
            var sList = new List<string>();
            //string CourseName ="";
            //string sUserInput = "";            
            //bool validInput = true;

            //List<string> lines = new List<string>();
            // var studentCurInfo = new studInfo();

            Console.WriteLine("*********************");
            Console.WriteLine("Welcome to School!");
            while (true)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. New Student Enrollment");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Get All Students by course");
                Console.WriteLine("5. View all Students");
                
                Console.WriteLine("Select an option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank You!!!");
                        return;

                    case "1":
                        Console.WriteLine("Student Name:");
                        var studName = Console.ReadLine();

                        Console.WriteLine("Student Email Address:");
                        var studEmail = Console.ReadLine();

                        Console.WriteLine("student Address:");
                        var stuAddress = Console.ReadLine();

                        Console.WriteLine("Student PhoneNumber:");
                        var studPh = Convert.ToInt64(Console.ReadLine());

                        Console.WriteLine("Student Gender:");
                        //Array of string assign to variable
                        var studGen = Enum.GetNames(typeof(TypeofGender));
                        for (var i = 0; i < studGen.Length; i++)
                        {
                            Console.WriteLine($"{i}. {studGen[i]}");
                        }

                        //Type casting
                        //Generic methods "<>"
                        //Read the value asking the enum to parse the string into and then give you the type.
                        var studGender = Enum.Parse<TypeofGender>(Console.ReadLine());

                      //  Console.WriteLine("Course Name: ");
                      //  var courseName = Console.ReadLine();

                        Console.WriteLine("Enrollment Fee:");
                        var enrollAmt = Convert.ToDecimal(Console.ReadLine());

                        var studentCurInfo = School.createNewStudEnroll(studName,studEmail,stuAddress,
                            studPh,studGender                           
                            , enrollAmt);
                        Console.WriteLine($"StudID: {studentCurInfo.StudentId} " +
                        $" StudName: {studentCurInfo.StudFirstName}" +
                         $" Email: {studentCurInfo.StudEmailAdd}" +
                         $" StudentGender: { studentCurInfo.StudGender}" +
                         $" Create Date: {studentCurInfo.StudStartDate}" +
                         $" Enrollment Fee: {studentCurInfo.StudEnrollFee:C}");

                        Console.WriteLine("Student Enrolled!");
                        break;

                    case "2":

                        Console.WriteLine("student ID:");
                        var studtId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("course Name:");
                        var courname = Console.ReadLine();

                        School.createCourse(studtId,courname);

                        Console.WriteLine("Course created!");
                        break;

                    case "3":
                        Console.WriteLine("student ID:");
                        var studentId = Convert.ToInt32(Console.ReadLine());

                        School.removeStudent(studentId);

                        Console.WriteLine("Student Record Deleted!");
                        break;

                    case "4":
                        Console.WriteLine("CourseName:");
                        var coursename = Console.ReadLine();
                        try
                        {
                            School.GetAllStudentsbycourse(coursename);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("The Course Name is invalid!");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("CourseName is invalid. Please try again!");
                        }
                        break;

                    case "5":
                        try
                        {
                            School.PrintAllstudentdetails();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Something went wrong!");
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid option! Try again!");
                        break;
                }

            }

        }
        

    }
}
