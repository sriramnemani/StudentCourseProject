using System;
using System.Collections.Generic;
using System.Text;

namespace StudCurRegistration
{
    /// <summary>
    /// This represnets a student information
    /// to enroll the course and assignment scores.
    /// </summary>
    class studInfo
    {
        //declare public constructor
        public studInfo()
        {
        }
        // declare static variable field
        public static int count_studentID;
        
        #region properties of Student inforation
        /// <summary>
        /// unique student ID
        /// and student email address
        /// </summary>
        public int StudentId { get; private set; }
        public string StudPassword { get; set; }
        public string StudFirstName { get; set;}
        public string StudLastName { get; set; }
        public DateTime StudDoB { get; set; }
        public string StudGender { get; set; }

        public string StudEmailAdd { get; set; }
        public string StudAddress { get; set; }
        public long  StudphNum { get; set; }
        //public string courseID { get; set; }  
        //public int score { get; set; }
        #endregion

        #region
        // declare static method 
        public static int StudID_Count()
        {
            return ++count_studentID;
        }
        #endregion

        #region Methods
        /// <summary>
        /// add a new student in student list
        /// </summary>
        public void AddNewStudent(int StudentId)
        {
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
