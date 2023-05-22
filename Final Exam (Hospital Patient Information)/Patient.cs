using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Final_Exam__Hospital_Patient_Information_
{//The Patient's Class
    class Patient
    {
        //Get and Sets of the Patient Attributes.
        public int PatientID { get; set; }
        public string PFirstName { get; set; }
        public string PLastName { get; set; }
        public int DoctorID { get; set; }
        public string Condition { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        /// <summary>
        /// The method that initializes all patient attributes within the Patient Class.
        /// </summary>
        /// <param name="pid">Patient Identification Number</param>
        /// <param name="pfn">Patient First Name</param>
        /// <param name="pln">Patient Last Name</param>
        /// <param name="Ge">Patients Age</param>
        /// <param name="Gr">Patients Gender</param>
        /// <param name="Cd">Patients Condition</param>
        /// <param name="Loc">Patients Location</param>
        /// <param name="Did">Patient's Doctors Identification Number</param>
        public Patient(int pid, string pfn, string pln, int Ge, string Gr, string Cd, string Loc, int Did)
        {
            PatientID = pid;
            PFirstName = pfn;
            PLastName = pln;
            GE = Ge;
            //Check if age is more than zero, or less than 110
            GR = Gr;
            //Check if gender is "male" or "female" if not throw exception.
            CD = Cd;
            //Check if condition is "critical", "serious", "minor". 
            Location = Loc;
            //Check if location is "ER", "ICU", "General".
            DoctorID = Did;
            //Check if doctorID is the same as doctor.doctorID
        }
        /// <summary>
        /// This checks if the patients age is inputed as below 1 or above 110;
        /// </summary>
        public int GE
        {
            get
            {
                return GE;
            }
            set
            {
                try
                {
                    if (value >= 1 && value <= 110)
                    {
                        Age = value;
                    }
                    else
                    {
                        throw new Exception("Age can't be below 1 or above 110");
                    }
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1.Message);
                    Age = 1;
                }
            }
        }
        /// <summary>
        /// Checks if the Gender inputed is not male or female.
        /// </summary>
        public string GR
        {
            get
            {
                return GR;
            }
            set
            {
                try
                {
                    if (value == "male" || value == "female")
                    {
                        Gender = value;
                    }
                    else
                    {
                        throw new Exception("Gender has to be male or female");
                    }
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                    Gender = "UniSex";
                }
            }
        }
        /// <summary>
        /// Checks if an doctor is assigned to more than 4 patients
        /// </summary>
        public int Did
        {
            get
            {
                return Did;
            }
            set
            {
                try
                {
                    if (Did >= 1 && Did <= 4)
                    {
                        Did = value;
                    }
                    else
                    {
                        throw new Exception("DoctorID cant be used more than 4 times");
                    }
                }
                catch (Exception e3)
                {
                    Console.WriteLine(e3.Message);
                }
            }
        }
        /// <summary>
        /// turns Condition into a value
        /// Sets the conditions that no patient can be designated except than our three designations(critical, serious, minor).
        /// </summary>
        public string CD
        {
            get
            {
                return CD;
            }
            set
            {
                try
                {
                    if (value == "critical" || value == "serious" || value == "minor")
                    {
                        Condition = value;
                    }
                    else
                    {
                     throw new Exception("Does not fall into the specified conditions");
                    }
                }
                catch (Exception e4)
                {
                    Console.WriteLine(e4.Message);
                    Condition = "ConditionERROR1";
                }
            }
        }
        /// <summary>
        /// turns Location into a value
        /// Sets the location that no patient can be located anywhere else than our three wards.
        /// </summary>
        public string LOC
        {
            get
            {
                return LOC;
            }
            set
            {
                try
                {
                    if (value == "ER" || value == "ICU" || value == "General")
                    {
                        Location = value;
                    }
                    else
                    {
                        throw new Exception("Does not fall into the specified locations");
                    }
                }
                catch (Exception e5)
                {
                    Console.WriteLine(e5.Message);
                    Location = "LocationERROR1";
                }
            }
        }
        /// <summary>
        /// If patients with a critical condition are not in the ER an exception is thrown.
        /// If patients with a serious condition are not in the ICU an exception is thrown.
        /// If patients with a minor condition are not in the General an exception is thrown.
        /// </summary>
        /// <param name="Condition">Patient Condition</param>
        /// <param name="Location">Patient Location</param>
        public void Update(string Condition, string Location)
        {
            try
            {
                if (Condition == "critical" && Location != "ER")
                    throw new Exception("Patient with critical condition has to be in the ER");
                else if (Condition == "serious" && Location != "ICU")
                    throw new Exception("Patient with serious condition has to be in the ICU");
                else if (Condition == "minor" && Location != "General")
                    throw new Exception("Patient with minor condition has to be in the General");
            }
            catch (Exception e6)
            {
                Console.WriteLine(e6.Message);
                Condition = "ConditionERROR2";
                Location = "LocationERROR2";
            }   
        }
    }
}