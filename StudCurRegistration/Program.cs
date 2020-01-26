using System;

namespace StudCurRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
           var studentCurInfo =  Registration.createNewStudReg("Rama", "Rama@gmail.com", TypeofGender.Female,
                regamt: 100);

            Console.WriteLine($"StudID: {studentCurInfo.StudentId} " + "\n"+
                $"StudName: {studentCurInfo.StudFirstName}" + "\n" +
                $"Email: {studentCurInfo.StudEmailAdd}" + "\n" +
                $"StudentGender: { studentCurInfo.StudGender}" + "\n" +            
                $"StudRegAmount: {studentCurInfo.StudRegFee}");

           // var studentCurInfo2 = new studInfo();
           // Console.WriteLine($"StudID: {studentCurInfo2.StudentId},Email: {studentCurInfo2.StudEmailAdd}," +
             //   $" StudentGender: {studentCurInfo2.StudGender}");
            

        }


    }
}
