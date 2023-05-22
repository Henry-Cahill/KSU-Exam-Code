using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam__Hospital_Patient_Information_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Random Number generator for patient
            Random patientRN = new Random();

            Doctor[] doc = new Doctor[5];
            //The Five Doctor Objects that are created, with thier initial values.
            doc[0] = new Doctor(1, "Joeseph",    "Buckman");
            doc[1] = new Doctor(2, "Michael",    "Chilton");
            doc[2] = new Doctor(3, "Roger",      "Friedman");
            doc[3] = new Doctor(4, "Steephanson","Anthonymuthu");
            doc[4] = new Doctor(5, "Brad",       "Cunningham");

            Patient[] pat = new Patient[10];
            //Ten patient objects
            pat[0] = new Patient(patientRN.Next(1, 100000), "Henry",   "Cahill",   21,"male",  "critical","ER",     doc[0].DoctorID);
            pat[1] = new Patient(patientRN.Next(1, 100000), "Coleman", "Bushy",    20,"male",  "critical","ER",     doc[4].DoctorID);
            pat[2] = new Patient(patientRN.Next(1, 100000), "Michael", "Rayl",     20,"male",  "serious", "ICU",    doc[3].DoctorID);
            pat[3] = new Patient(patientRN.Next(1, 100000), "Jonathan","Reiff",    21,"male",  "serious", "ICU",    doc[1].DoctorID);
            pat[4] = new Patient(patientRN.Next(1, 100000), "Mitchell","Walden",   20,"male",  "minor",   "General",doc[2].DoctorID);
            pat[5] = new Patient(patientRN.Next(1, 100000), "Cody",    "Woodruff", 20,"male",  "minor",   "General",doc[3].DoctorID);
            pat[6] = new Patient(patientRN.Next(1, 100000), "Courtney","Glasco",   21,"female","critical","ER",     doc[1].DoctorID);
            pat[7] = new Patient(patientRN.Next(1, 100000), "Jacob",   "Meyerhoff",21,"male",  "critical","ER",     doc[0].DoctorID);
            pat[8] = new Patient(patientRN.Next(1, 100000), "Aaron",   "Lozano",   21,"male",  "serious", "ICU",    doc[1].DoctorID);
            pat[9] = new Patient(patientRN.Next(1, 100000), "Katie",   "Cicmanec", 20,"female","serious", "ICU",    doc[3].DoctorID);

            //The Doctor information displayed in the console.
            Console.Write("DoctorId"+"\t"+"FirstName"+"\t"+"LastName\n");
            Console.WriteLine(doc[0].DoctorID+"\t\t"+doc[0].DFirstName+"\t\t"+doc[0].DLastName);
            Console.WriteLine(doc[1].DoctorID+"\t\t"+doc[1].DFirstName+"\t\t"+doc[1].DLastName);
            Console.WriteLine(doc[2].DoctorID+"\t\t"+doc[2].DFirstName+"\t\t"+doc[2].DLastName);
            Console.WriteLine(doc[3].DoctorID+"\t\t"+doc[3].DFirstName+"\t"  +doc[3].DLastName);
            Console.WriteLine(doc[4].DoctorID+"\t\t"+doc[4].DFirstName+"\t\t"+doc[4].DLastName+"\n");

            //The Patient information dispayed in the console.
            Console.Write("PatientId"+"\t"+"FirstName"+"\t"+"LastName"+"\t"+"Age"+"\t"+"Gender"+"\t"+"Condition"+"\t"+"Location"+"\t"+"DoctorID\n");
            Console.WriteLine(pat[0].PatientID+"\t\t"+pat[0].PFirstName+"\t\t"+pat[0].PLastName+"\t\t"+pat[0].Age+"\t"+pat[0].Gender+"\t"+pat[0].Condition+"\t"  +pat[0].Location+"\t\t"+pat[0].DoctorID);                                                                                                                                                                                    
            Console.WriteLine(pat[1].PatientID+"\t\t"+pat[1].PFirstName+"\t\t"+pat[1].PLastName+"\t\t"+pat[1].Age+"\t"+pat[1].Gender+"\t"+pat[1].Condition+"\t"  +pat[1].Location+"\t\t"+pat[1].DoctorID);
            Console.WriteLine(pat[2].PatientID+"\t\t"+pat[2].PFirstName+"\t\t"+pat[2].PLastName+"\t\t"+pat[2].Age+"\t"+pat[2].Gender+"\t"+pat[2].Condition+"\t\t"+pat[2].Location+"\t\t"+pat[2].DoctorID);
            Console.WriteLine(pat[3].PatientID+"\t\t"+pat[3].PFirstName+"\t"  +pat[3].PLastName+"\t\t"+pat[3].Age+"\t"+pat[3].Gender+"\t"+pat[3].Condition+"\t\t"+pat[3].Location+"\t\t"+pat[3].DoctorID);
            Console.WriteLine(pat[4].PatientID+"\t\t"+pat[4].PFirstName+"\t"  +pat[4].PLastName+"\t\t"+pat[4].Age+"\t"+pat[4].Gender+"\t"+pat[4].Condition+"\t\t"+pat[4].Location+"\t\t"+pat[4].DoctorID);
            Console.WriteLine(pat[5].PatientID+"\t\t"+pat[5].PFirstName+"\t\t"+pat[5].PLastName+"\t"  +pat[5].Age+"\t"+pat[5].Gender+"\t"+pat[5].Condition+"\t\t"+pat[5].Location+"\t\t"+pat[5].DoctorID);
            Console.WriteLine(pat[6].PatientID+"\t\t"+pat[6].PFirstName+"\t"  +pat[6].PLastName+"\t\t"+pat[6].Age+"\t"+pat[6].Gender+"\t"+pat[6].Condition+"\t"  +pat[6].Location+"\t\t"+pat[6].DoctorID);
            Console.WriteLine(pat[7].PatientID+"\t\t"+pat[7].PFirstName+"\t\t"+pat[7].PLastName+"\t"  +pat[7].Age+"\t"+pat[7].Gender+"\t"+pat[7].Condition+"\t"  +pat[7].Location+"\t\t"+pat[7].DoctorID);
            Console.WriteLine(pat[8].PatientID+"\t\t"+pat[8].PFirstName+"\t\t"+pat[8].PLastName+"\t\t"+pat[8].Age+"\t"+pat[8].Gender+"\t"+pat[8].Condition+"\t\t"+pat[8].Location+"\t\t"+pat[8].DoctorID);
            Console.WriteLine(pat[9].PatientID+"\t\t"+pat[9].PFirstName+"\t\t"+pat[9].PLastName+"\t"  +pat[9].Age+"\t"+pat[9].Gender+"\t"+pat[9].Condition+"\t\t"+pat[9].Location+"\t\t"+pat[9].DoctorID+"\n");

            //patients in the ICU are 3, 4, 9, & 10.
            Console.WriteLine($"There are 4 patients in the ICU ward,; with the names of the individuals are {pat[2].PFirstName}, {pat[3].PFirstName}, {pat[8].PFirstName}, & {pat[9].PFirstName}");
            //patients in the ER are 1, 2, 7, & 8.
            Console.WriteLine($"There are 4 patients in the ER ward; with the names of the individuals are {pat[0].PFirstName}, {pat[1].PFirstName}, {pat[6].PFirstName}, & {pat[7].PFirstName}");
            //patients in General are 5 & 6.
            Console.WriteLine($"There are 2 patients in General ward; with the names of the individuals are {pat[4].PFirstName} & {pat[5].PFirstName}.\n");

            //Doctor Buckman's patients are 1, 8.
            Console.WriteLine($"Patients under Doctor {doc[0].DLastName} care are {pat[0].PFirstName} & {pat[7].PFirstName}.");
            //Doctor Chilton's patients are 4, 7, 9.
            Console.WriteLine($"Patients under Doctor {doc[1].DLastName} care are {pat[3].PFirstName}, {pat[6].PFirstName}, & {pat[8].PFirstName}.");
            //Doctor Friedman's patients are 5.
            Console.WriteLine($"Patients under Doctor {doc[2].DLastName} care are {pat[4].PFirstName}.");
            //Doctor Stephan's patients are 3, 6, 10.
            Console.WriteLine($"Patients under Doctor {doc[3].DLastName} care are {pat[2].PFirstName}, {pat[5].PFirstName}, & {pat[9].PFirstName}.");
            //Doctor Cunningham's patients are 2.
            Console.WriteLine($"Patients under Doctor {doc[4].DLastName} care are {pat[1].PFirstName}.\n");

            //patients in critical condition are 3, 4, 9, & 10.
            Console.WriteLine($"The patients in Critical condition are {pat[2].PatientID}, {pat[3].PatientID}, {pat[8].PatientID}, & {pat[9].PatientID}.");
            //patients in serious condition are 1, 2, 7, & 8.
            Console.WriteLine($"The patinets in Serious condition are {pat[0].PatientID}, {pat[1].PatientID}, {pat[6].PatientID}, & {pat[7].PatientID}.");
            //patients in minor condition are 5 & 6.
            Console.WriteLine($"The patients in Minor condition are {pat[4].PatientID} & {pat[5].PatientID}.");

            //Keeps the Program open.
            Console.ReadLine();
        }
        /// <summary>
        /// This updates the doctors Id into the patient object's.
        /// </summary>
        /// <param name="doc">Doctor Class</param>
        /// <param name="pat">Patient Class</param>
        /// <param name="DoctorID">Doctor's specific DoctorID</param>
        public void UpdateDoctor (Doctor []doc, Patient []pat, int DoctorID)
        {
            for (int XXX = 0; XXX < pat.Length; XXX++)
            {
                if (pat[XXX].Did == DoctorID)
                    return;
            }
        }
    }
}
