using System;
using System.Collections.Generic;
using System.Text;

namespace StudCurRegistration
{
    static class Registration
    {
        /// <summary>
        /// create a student registration
        /// </summary>
        /// <param name="studName"> Student Name</param>
        /// <param name="emailaddress">Student Email Address</param>
        /// <param name="regamt">Registration Amount</param>
        /// <returns> New Registration details of Student</returns>
        public static studInfo createNewStudReg(
            string studName,
            string emailaddress,
            TypeofGender gender = TypeofGender.Female,
            decimal regamt = 0)            
        {
            //object Initialization
            var studentInfo = new studInfo
            {
                StudFirstName = studName,
                StudEmailAdd = emailaddress,
                StudGender = gender
            };
            if (regamt > 0)
            {
               studentInfo.RegStudAmt(regamt);
            }

            return studentInfo;
        }

   
    }
}
