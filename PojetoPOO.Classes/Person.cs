using System;

/*
*	<copyright file="$file$" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>manol</author>
*   <date>11/04/2023 2:28:27 PM</date>
*	<description></description>
**/


namespace ProjetoPOO.Classes
{
    [Serializable]
    /// <summary>
    /// Purpose:
    /// Created by manol
    /// Created on: 11/04/2023 2:28:27 PM
    /// </summary>
    /// Classe Person
    public abstract class Person
    {

        #region ATTRIBUTES

        public string firstName;
        public string lastName;
        public string email;
        public int phoneNumber;
        public DateTime dob;
        public int nif;
        public string address;

        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// Construtor default
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="dob"></param>
        /// <param name="nif"></param>

        public Person()
        {
            firstName = "";
            lastName = "";
            email = "";
            phoneNumber = 0;
            nif = 0;
            address = "";
        }

        public Person(string firstname, string lastName, string email, int phoneNumber, DateTime dob, int nif, string address)
        {
            this.firstName = firstname;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.dob = dob;
            this.nif = nif;
            this.address = address;
        }

        #endregion

        #region PROPERTIES

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public int Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public virtual string ShowPerson()
        {
            return (String.Format($"Name: {FirstName} {LastName}, Email: {Email}, Phone Number: {PhoneNumber} , Date Of Birth: {Dob.ToShortDateString()}, NIF: {Nif}, Address: {Address}"));
        }


        #endregion

        #region OVERRIDES

        #endregion

        #region OTHERMETHODS

        #endregion

        #region DESTRUCTOR

        #endregion
        #endregion
    }
}
