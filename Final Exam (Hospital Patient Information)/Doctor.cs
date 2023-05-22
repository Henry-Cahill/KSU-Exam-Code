using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam__Hospital_Patient_Information_
{ //The Doctor's Class
    class Doctor
    {
        //Gets and Sets of the Doctor Attributes.
        public int DoctorID { get; set; }
        public string DFirstName { get; set; }
        public string DLastName { get; set; }

        /// <summary>
        /// The method that initializes all doctors attributes within the Doctor Class.
        /// </summary>
        /// <param name="did">Doctor Identification Number</param>
        /// <param name="dfn">Doctor First Name</param>
        /// <param name="dln">Doctor Last Name</param>
        public Doctor(int did, string dfn, string dln)
        {
            DoctorID = did;
            DFirstName = dfn;
            DLastName = dln;
        }
    }
}
