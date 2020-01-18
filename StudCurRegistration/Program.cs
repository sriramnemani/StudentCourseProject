using System;

namespace StudCurRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
           var studentCurInfo = new studInfo();
           // studentCurInfo.StudentId = 11;
            studentCurInfo.StudFirstName = "Rama";
            studentCurInfo.StudLastName = "AR";
            studentCurInfo.StudGender = "Male";
            studentCurInfo.StudphNum = 4253194523;
            studentCurInfo.StudAddress = "Bellevue";
            studentCurInfo.StudEmailAdd = "ramraj@gmail.com";
            
            studInfo.count_studentID = 0;
            studInfo.StudID_Count();
            Console.WriteLine($"StudID: {studInfo.count_studentID},Email: {studentCurInfo.StudEmailAdd}");
            //Console.WriteLine(studInfo.count_studentID);

            // Accessing without any instance of the class 
            studInfo.StudID_Count();
            Console.WriteLine($"StudID: {studInfo.count_studentID},Email: {studentCurInfo.StudEmailAdd}");
            //Console.WriteLine(studInfo.count_studentID);         

        }


    }
}
