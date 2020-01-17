using System;

namespace StudCurRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
           var studentCurInfo = new studInfo();
            studentCurInfo.StudentId = 111;
            studentCurInfo.StudFirstName = "Ram";
            studentCurInfo.StudLastName = "Raj";
            studentCurInfo.Studgender = "Male";
            studentCurInfo.StudphNum = 4253194523;
            studentCurInfo.StudAddress = "Bellevue";
            studentCurInfo.StudEmailAdd = "ramraj@gmail.com"; 

        }
    }
}
