using System;

/*
*	<copyright file="$file$" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>manol</author>
*   <date>11/04/2023 2:52:10 PM</date>
*	<description></description>
**/


namespace ProjetoPOO.Classes
{
    /// <summary>
    /// Purpose:
    /// Created by manol
    /// Created on: 11/04/2023 2:52:10 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example>test</example>
    public class Staff : Person, IRegister
    {
        #region ATTRIBUTES

        private int staffId;
        public StaffCategory staffCategory;

        public enum StaffCategory
        {
            Medic,
            Cleaning,
            Receptionist,
            Janitor,
            Assitant
        }

        #endregion

        #region METHODS

        #region CONSTRUCTORS

        public Staff(string firstName, string lastName, string email, int phoneNumber, DateTime dob, int nif, string address, StaffCategory staffCategory, int staffId) : base(firstName, lastName, email, phoneNumber, dob, nif, address)
        {
            this.staffId = staffId;
            this.staffCategory = staffCategory;
        }

        #endregion

        #region PROPERTIES

        public int StaffId
        {
            get { return this.staffId; }
            set { staffId = value; }
        }

        public StaffCategory StaffCategories { get; set; }
        #endregion

        #region OVERRIDES

        public override string ShowPerson()
        {
            return (String.Format($"Staff Name: {FirstName} {LastName}, Staff Category: {StaffCategories}, StaffID: {staffId}, Email: {Email}, Phone Number: {PhoneNumber} , Date Of Birth: {Dob.ToShortDateString()}, NIF: {Nif}, Address: {Address}\n"));
        }

        #endregion

        #region OTHERMETHODS

        void IRegister.RegisterInformation()
        {

        }

        void IRegister.UnregisterInformation()
        {

        }

        void IRegister.ScheduleAppointment()
        {

        }

        void IRegister.CancelAppointment()
        {

        }

        void IRegister.ShowAppointmentResults()
        {

        }

        #endregion

        #region DESTRUCTOR

        #endregion
        #endregion
    }
}
