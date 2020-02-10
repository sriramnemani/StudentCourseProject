using System;

namespace StudCurRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new studInfo();       
        // var studentCurInfo = new studInfo();

        Console.WriteLine("*********************");
            Console.WriteLine("Welcome to School!");
            while (true)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. New Student Enrollment");
                //Console.WriteLine("2. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. View all Students");
                
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

                        // Course Name
                        Console.WriteLine("Course Name:");
                        var courseName = Console.ReadLine();

                        Console.WriteLine("Enrollment Fee:");
                        var enrollAmt = Convert.ToDecimal(Console.ReadLine());
                        
                        var studentCurInfo = School.createNewStudEnroll(studName,studEmail,courseName,
                            studGender,enrollAmt);
                        Console.WriteLine($"StudID: {studentCurInfo.StudentId} " +
                        $" StudName: {studentCurInfo.StudFirstName}" +
                         $" Email: {studentCurInfo.StudEmailAdd}" +
                         $" StudentGender: { studentCurInfo.StudGender}" +
                         $" Create Date: {studentCurInfo.StudStartDate}" +
                         $" Course Code:{studentCurInfo.CourseCode}" +
                         $" Course Name:{studentCurInfo.CourseName}" +
                         $" Enrollment Fee: {studentCurInfo.StudEnrollFee:C}");

                        Console.WriteLine("Student Enrolled!");
                        break;

                    case "2":                       
                        Console.WriteLine("student ID:");
                        var studentId = Convert.ToInt32(Console.ReadLine());

                        School.removeStudent(studentId);

                        Console.WriteLine("Student Record Deleted!");
                        break;                       

                    case "3":
                        School.PrintAllstudentdetails();
                        break;
                    default:
                        Console.WriteLine("Invalid option! Try again!");
                        break;
                }

            }

        }
        

    }
}
