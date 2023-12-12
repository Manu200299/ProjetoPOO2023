using System;
using ProjetoPOO.Classes;

namespace ProjetoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}