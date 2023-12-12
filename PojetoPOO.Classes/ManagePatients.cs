using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;

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
    public class ManagePatients
    {
        #region ATTRIBUTES
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// The default constructor
        /// </summary>
        public ManagePatients()
        {

        }
        #endregion

        #region PROPERTIES
        #endregion

        #region OVERRIDES
        #endregion

        #region OTHERMETHODS
        public static bool SavePatient(string pName, ArrayList patients)
        {
            Stream s = File.Open(pName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(s, patients);
            s.Close();
            return true;
        }

        public static ArrayList LoadPatients(string pName)
        {
            ArrayList aux;

            Stream s = File.Open(pName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            aux = (ArrayList)bf.Deserialize(s);
            s.Close();
            return aux;
        }

        public static void ShowPatients(ArrayList patients)
        {
            foreach (Patient patient in patients)
            {
                Console.WriteLine($"Id: {patient.PacientId}, Nome: {patient.FirstName + patient.LastName}, NIF: {patient.Nif}, Phone number: {patient.PhoneNumber}");
            }
        }

        #endregion

        #region DESTRUCTOR
        /// <summary>
        /// The default destructor
        /// </summary>
        ~ManagePatients()
        {

        }
        #endregion
        #endregion
    }
}