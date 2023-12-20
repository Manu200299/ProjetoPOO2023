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
        public ArrayList patients; //arrayList pacientes
        static int totPatients;
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// The default constructor
        /// </summary>
        public Patients()
        {
            totPatients=0;
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

        /// <summary>
        /// Metodo para guardar os pacientes na arraylist com BinaryFormatter
        /// </summary>
        /// <param name="fName"></param>
        /// <returns></returns>
        public bool SavePatients(string fName)
        {
            try
            {
                Stream s = File.Open(fName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, patients);
                s.Close();
                return true;
            }
            catch (IOException e) //exception dos IO's
            {
                throw e;
            }
            return false;
        }
        /// <summary>
        /// Metodo para limpar a arraylist patients
        /// </summary>
        public void ClearPatients()
        {
            patients.Clear();
        }

        /// <summary>
        /// Metodo para carregar o ficheiro dos pacientes na arraylist com BinaryFormatter
        /// </summary>
        /// <param name="fName"></param>
        /// <returns></returns>
        public bool LoadPatients(string fName)
        {
            if( File.Exists(fName))
            {
                try
                {
                    Stream s = File.Open(fName, FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    patients = (ArrayList)bf.Deserialize(s);
                    s.Close();
                    return true;
                }
                catch(IOException e) //exception dos IO's
                {
                    throw e;
                }
            }
            return false;
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