using System;
using System.ComponentModel;
using ProjetoPOO.Classes;
using ProjetoPOO.Exceptions;

namespace ProjetoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAXPATIENTS = 2000;
            /*
            Patient p1 = new Patient("John", "Doe", Patient.PatientType.Outpatient, "M", "john@example.com", 123890, new DateTime(1990, 5, 15), 12389, "street", 987654, "Dr.Smith");
            Console.WriteLine(p1.ShowPerson());

            Patients patientSheet = new Patients();
            patientSheet.patients.Add(p1);

            patientSheet.SavePatients("Patients.dat");
            patientSheet.patients.Clear();
            ManagePatients.ShowPatients(patientSheet.patients);

            patientSheet.LoadPatients("Patients.dat");
            Console.WriteLine("Load Patients");
            ManagePatients.ShowPatients(patientSheet.patients);
            

            //Inicializar array
            Patient[] patients = new Patient[MAXPATIENTS];

            for (int i = 0; i < MAXPATIENTS; i++)
            {
                patients[i] = new Patient();
            }

            //Dados simulacao
            patients[0].FirstName = "Joao";
            patients[1].FirstName = "Tiago";
            patients[2].FirstName = "Ruben";
            patients[3].FirstName = "Macaco";

            //Verificar se "Joao" existe na array
            bool exists = false;
            for(int i = 0; i < MAXPATIENTS;i++)
            {
                if(String.Compare("Joao", patients[i].FirstName) == 0)
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Doesn't exist");
            }

            //mostrar array com foreach
            foreach(Patient i in patients)
            {
                if(i.FirstName.Length > 0)
                {
                    Console.WriteLine("Name: " + i.FirstName);
                }
            }

            //mostrar array com for
            for(int i = 0;i < MAXPATIENTS;i++)
            {
                if (patients[i].FirstName.Length > 0)
                {
                    Console.WriteLine("Name: " + patients[i].FirstName);
                }
            }
            */


            //// Generating simulation data for multiple Medic instances using constructor calls (Simulado com IA)
            Medic m1 = new Medic("John", "Doe", "johndoe@example.com", 1234567890, new DateTime(1980, 5, 15), 123456789, "123 Main Street", 1001, Medic.MedicSpecialty.Cardiology, Staff.StaffCategory.Medic, 2001);
            bool aux = Medics.InsertMedic(m1);
            if (aux)
            {
                Console.WriteLine("Inserido! Total de Pessoas: {0}", Medics.TotalMedics);
            }


            Medic m2 = new Medic("Alice", "Smith", "alicesmith@example.com", 987654321, new DateTime(1975, 8, 20), 987654321, "456 Elm Street", 1002, Medic.MedicSpecialty.Pediatrics, Staff.StaffCategory.Medic, 2002);
            bool aux1 = Medics.InsertMedic(m2);

            if (aux1)
            {
                Console.WriteLine("Inserido! Total de Pessoas: {0}", Medics.TotalMedics);
            }

            Medic m3 = new Medic("Bob", "Johnson", "bobjohnson@example.com", 555555555, new DateTime(1990, 3, 10), 333333333, "789 Oak Street", 1003, Medic.MedicSpecialty.Neurology, Staff.StaffCategory.Medic, 2003);
            bool aux2 = Medics.InsertMedic(m3);

            if (aux2)
            {
                Console.WriteLine("Inserido! Total de Pessoas: {0}", Medics.TotalMedics);
            }

            //AI Simulated data
            Medic m4 = new Medic("Charlie", "Brown", "charliebrown@example.com", 555555556, new DateTime(1991, 3, 11), 333333334, "790 Oak Street", 1004, Medic.MedicSpecialty.Neurology, Staff.StaffCategory.Medic, 2004);
            Medic m5 = new Medic("David", "Doe", "daviddoe@example.com", 555555557, new DateTime(1992, 3, 12), 333333335, "791 Oak Street", 1005, Medic.MedicSpecialty.Neurology, Staff.StaffCategory.Medic, 2005);
            Medic m6 = new Medic("Eva", "Smith", "evasmith@example.com", 555555558, new DateTime(1993, 3, 13), 333333336, "792 Oak Street", 1006, Medic.MedicSpecialty.Neurology, Staff.StaffCategory.Medic, 2006);
            Medic m7 = new Medic("Frank", "Johnson", "frankjohnson@example.com", 555555559, new DateTime(1994, 3, 14), 333333337, "793 Oak Street", 1007, Medic.MedicSpecialty.Neurology, Staff.StaffCategory.Medic, 2007);

            bool aux3 = Medics.InsertMedic(m3);
            bool aux4 = Medics.InsertMedic(m4);
            bool aux5 = Medics.InsertMedic(m5);
            bool aux6 = Medics.InsertMedic(m6);
            bool aux7 = Medics.InsertMedic(m7);


            Medics.ShowMedics(Medics.AllMedics);
            Medics.CountMedics();
            string medicName = Medics.GetMedicName(1004);
            Console.WriteLine(medicName);
            string medicID = Medics.GetMedicID(333333337);
            Console.WriteLine(medicID);
            bool medicExists = Medics.MedicExists(1004);
            Console.WriteLine(medicExists);


            Medics.ShowMedics(Medics.AllMedics);
            Medics.RemoveMedic(1004);
            Console.WriteLine("Medic Removed!"); // working
            Medics.ShowMedics(Medics.AllMedics);


        }
    }
}