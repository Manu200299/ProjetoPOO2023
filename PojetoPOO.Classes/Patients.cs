using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
/*
*	<copyright file="ProjetoPOO.Classes" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>manol</author>
*   <date>11/15/2023 1:34:52 PM</date>
*	<description></description>
**/

namespace ProjetoPOO.Classes
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Patients
    {
        #region ATTRIBUTES
        const int MAXPATIENTS = 2000;
        public ArrayList patients;
        static int totPatients;
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// The default constructor
        /// </summary>
        public Patients()
        {
            totPatients++;
            patients = new ArrayList();
            //inicializa array patients
        }
        #endregion

        #region PROPERTIES
        #endregion

        #region OVERRIDES
        #endregion

        #region OTHERMETHODS

        public void ShowPatients()
        {
            foreach(Patient patient in patients)
            {
                if(patient.firstName.Length > 0)
                {
                    Console.WriteLine("Name " + patient.firstName + patient.lastName, "| Email: " + patient.email, "| Phone Number: " + patient.phoneNumber, "| Assigned Medic: " + patient.AssignedMedic);
                }
            }
        }


        public bool SavePatients(string fName)
        {
            Stream s = File.Open(fName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(s, patients);
            s.Close();
            return true;
        }

        public bool LoadPatients(string fName)
        {
            Stream s = File.Open(fName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            patients = (ArrayList)bf.Deserialize(s);
            s.Close();
            return true;
        }

        #endregion

        #region DESTRUCTOR
        /// <summary>
        /// The default destructor
        /// </summary>
        ~Patients()
        {

        }
        #endregion
        #endregion
    }
}