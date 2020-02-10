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
        private static int lastcourcode = 99;
        
        #region properties of Student inforation
        /// <summary>
        /// unique student ID
        /// and student email address
        /// </summary>
        public int StudentId { get; private set; }
        public string StudPassword { get; set; }
        public string StudFirstName { get; set;}
        //public string StudLastName { get; set; }
        public DateTime StudStartDate { get; set; }
        public TypeofGender StudGender { get; set; }
        public string StudEmailAdd { get; set; }
        public string StudAddress { get; set; }
        public long  StudphNum { get; set; }
        public decimal StudEnrollFee { get; private set; }
        public int CourseCode { get; private set; }
        public string CourseName { get; set; }
       
        #endregion

        #region
        // declare static method 
        //declare public constructor
        public studInfo()
        {
            StudentId = lastStudentId++;
            StudStartDate = DateTime.UtcNow;
            CourseCode = ++lastcourcode;
        }
        
        #endregion

        #region Methods
        /// <summary>
        /// Student Registration fee
        /// </summary>
        public void StudEnrollAmt(decimal amount)
        {
            StudEnrollFee = +amount;            
        }
        public void addstudcourse(int studid)
        {
            StudentId = studid;
        }
        #endregion
    }

}
