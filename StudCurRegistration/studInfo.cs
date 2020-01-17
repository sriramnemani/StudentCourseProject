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
        #region properties of Student inforation
        /// <summary>
        /// unique student email address
        /// </summary>
        public int StudentId {get; set;}
        public string StudFirstName { get; set;}
        public string StudLastName { get; set; }
        public DateTime StudDoB { get; set; }
        public string Studgender { get; set; }

        public string StudEmailAdd { get; set; }
        public string StudAddress { get; set; }
        public long  StudphNum { get; set; }
        public string courseID { get; set; }  
        public long score { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// enroll a course to student
        /// </summary>
        public void course(string courseID) 
        {

        }


        #endregion
    }

}
