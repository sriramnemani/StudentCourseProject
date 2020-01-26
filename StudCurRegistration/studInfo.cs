using System;
using System.Collections.Generic;
using System.Text;

namespace StudCurRegistration
{
    enum TypeofGender
    {
        Female, 
        Male 
    }

    /// <summary>
    /// This represnets a student information
    /// to enroll the course and assignment scores.
    /// </summary>
    class studInfo
    {
        // declare static variable field
        private static int lastStudentId = 0;      
        
        #region properties of Student inforation
        /// <summary>
        /// unique student ID
        /// and student email address
        /// </summary>
        public int StudentId { get; private set; }
        public string StudPassword { get; set; }
        public string StudFirstName { get; set;}
        //public string StudLastName { get; set; }
        public DateTime StudDoB { get; set; }
        public TypeofGender StudGender { get; set; }
        public string StudEmailAdd { get; set; }
        public string StudAddress { get; set; }
        public long  StudphNum { get; set; }
        public decimal StudRegFee { get; private set; }
        //public string courseID { get; set; }  
        //public int score { get; set; }
        #endregion

        #region
        // declare static method 
        //declare public constructor
        public studInfo()
        {
            StudentId = ++lastStudentId;
            StudDoB = DateTime.UtcNow;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Student registration fee
        /// </summary>
        public void RegStudAmt(decimal amount)
        {
            StudRegFee = +amount;            
        }
        /// <summary>
        /// remove studentId from student list
        /// </summary>
        /// <param name="StudentId"></param>
      public void RemoveStudent(int StudentId)
        {

        }
        #endregion
    }

}
