using System;
using System.Net;
using static ProjetoPOO.Classes.Staff;

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
    public class Medic : Staff, IRegister, IService
    {
        #region ATTRIBUTES

        private int medicId;
        private MedicSpecialty medicSpecialty;

        public enum MedicSpecialty
        {
            Cardiology,
            Pediatrics,
            Neurology,
            Orthopedics,
            Oncology,
            Other
        }

        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// The default constructor
        /// </summary>
        public Medic(string firstName, string lastName, string email, int phoneNumber, DateTime dob, int nif, string address, int medicId, MedicSpecialty specialty, StaffCategory staffCategory, int staffId)
            : base(firstName, lastName, email, phoneNumber, dob, nif, address, staffCategory, staffId)
        {
            this.medicId = medicId;
            this.medicSpecialty = specialty;
        }

        #endregion

        #region PROPERTIES

        public int MedicId
        {
            get { return medicId; }
            set { medicId = value; }
        }

        public MedicSpecialty MedicalSpecialty { get; set; }
        #endregion

        #region OVERRIDES
        public override string ShowPerson()
        {
            return (String.Format($"Medic Name: {FirstName} {LastName}, StaffID: {StaffId}, MedicId: {medicId}, MedicSpecialty: {medicSpecialty}, Email: {Email}, Phone Number: {PhoneNumber}, Date Of Birth: {Dob.ToShortDateString()}, NIF: {Nif}, Address: {Address}\n"));
        }

        #endregion

        #region OTHERMETHODS
        #endregion

        #region DESTRUCTOR
        /// <summary>
        /// The default destructor
        /// </summary>
        #endregion
        #endregion
    }
}