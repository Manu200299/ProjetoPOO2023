using System;
using System.Net;


/*
*	<copyright file="$file$" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>manol</author>
*   <date>11/04/2023 4:35:55 PM</date>
*	<description></description>
**/


namespace ProjetoPOO.Classes
{
    [Serializable]
    /// <summary>
    /// Purpose:
    /// Created by manol
    /// Created on: 11/04/2023 4:35:55 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Patient : Person, IService
    {
        #region ATTRIBUTES


        public int pacientId;
        public string FamilyMedic;
        public string gender;
        public PatientType patientType;

        public enum PatientType
        {
            Outpatient,
            RegularAdmission,
            EmergencyAdmission,
        }
        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// Construtor do Paciente
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="gender"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="dob"></param>
        /// <param name="nif"></param>
        /// <param name="pacientId"></param>
        /// <param name="assignedMedic"></param>
        public Patient(string firstName, string lastName, PatientType patientType, string gender, string email, int phoneNumber, DateTime dob, int nif, string address, int pacientId, string assignedMedic) : base(firstName, lastName, email, phoneNumber, dob, nif, address)
        {
            this.pacientId = pacientId;
            this.FamilyMedic = assignedMedic;
            this.gender = gender;
            this.patientType = patientType;
        }

        #endregion

        #region PROPERTIES

        public int PacientId
        {
            get { return pacientId; }
            set { pacientId = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string AssignedMedic
        {
            get { return FamilyMedic; }
            set { FamilyMedic = value; }
        }

        public PatientType PatientTypes { get; set; }

        #endregion

        #region OVERRIDES
        /// <summary>
        /// Override display do paciente (ToString)
        /// </summary>
        /// <returns></returns>
        public override string ShowPerson()
        {
            return (String.Format($"Patient Name: {FirstName} {LastName},Patient Type: {PatientTypes}; Gender: {gender}, PacientId: {pacientId}, Email: {Email}, Phone Number: {PhoneNumber} , Date Of Birth: {Dob.ToShortDateString()}, NIF: {Nif}, Address: {Address}, Family Medic: {FamilyMedic} \n"));
        }

        #endregion

        #region OTHERMETHODS

        #endregion

        #region DESTRUCTOR

        #endregion
        #endregion
    }
}
