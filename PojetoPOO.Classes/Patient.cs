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


        private int pacientId;
        private string familyMedic;
        private string gender;
        private PatientType patientType;

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
        /// Construtor por omissao
        /// </summary>
        public Patient()
        {
            firstName =string.Empty;
            lastName = string.Empty;
            patientType = default(PatientType);
            gender = string.Empty;
            email = string.Empty;
            phoneNumber = 0;
            dob = default(DateTime);
            nif = 0;
            address = string.Empty;
            pacientId= 0;
            familyMedic = string.Empty;
        }

        /// <summary>
        /// Construtor com parametross
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="patientType"></param>
        /// <param name="gender"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="dob"></param>
        /// <param name="nif"></param>
        /// <param name="address"></param>
        /// <param name="pacientId"></param>
        /// <param name="assignedMedic"></param>
        public Patient(string firstName, string lastName, PatientType patientType, string gender, string email, int phoneNumber, DateTime dob, int nif, string address, int pacientId, string assignedMedic) : base(firstName, lastName, email, phoneNumber, dob, nif, address)
        {
            this.pacientId = pacientId;
            this.familyMedic = assignedMedic;
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
            get { return familyMedic; }
            set { familyMedic = value; }
        }

        public PatientType PatientTypes { get; set; }

        #endregion

        #region OPERATORS
        /// <summary>
        /// Operator para verificar se um paciente e igual a outro paciente
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Patient p1, Patient p2)
        {
            if ((p1.nif == p2.nif) && (p1.pacientId == p2.pacientId))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Patient p1, Patient p2)
        {
            if (!((p1.nif == p2.nif) && (p1.pacientId == p2.pacientId)))
            {
                return false;
            }
            return true;
        }

        #endregion

        #region OVERRIDES
        /// <summary>
        /// Override display do paciente (ToString)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (String.Format($"Patient Name: {FirstName} {LastName},Patient Type: {PatientTypes}; Gender: {gender}, PacientId: {pacientId}, Email: {Email}, Phone Number: {PhoneNumber} , Date Of Birth: {Dob.ToShortDateString()}, NIF: {Nif}, Address: {Address}, Family Medic: {familyMedic} \n"));
        }

        /// <summary>
        /// Override do metodo Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Patient)
            {
                Patient p = (Patient)obj;
                if (this == p)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region OTHERMETHODS
        void IService.RequestRescheduleAppointment()
        {

        }

        void IService.RequestAppointment()
        {

        }

        #endregion

        #region DESTRUCTOR

        #endregion
        #endregion
    }
}
