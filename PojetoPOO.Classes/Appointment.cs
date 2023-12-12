using System;

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
    /// Purpose: Classe das consultas com o apoio da interface IRegister
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Appointment : IRegister
    {
        #region ATTRIBUTES

        private int appointmentId;
        private string appointmentDescription;
        private int cost;
        private DateTime date;
        private string medicName;
        private string pacientName;
        private string status;

        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// The default constructor
        /// </summary>
        public Appointment(int appointmentId, string appointmentDescription, int cost, DateTime dob, string medicName, string pacientName, string status)
        {
            this.appointmentId = appointmentId;
            this.appointmentDescription = appointmentDescription;
            this.cost = cost;
            this.date = dob;
            this.medicName = medicName;
            this.pacientName = pacientName;
            this.status = status;
        }
        #endregion

        #region PROPERTIES

        public int AppointmentId
        {
            get { return appointmentId; }
            set { appointmentId = value; }
        }

        public string AppointmentDescription
        {
            get { return appointmentDescription; }
            set { appointmentDescription = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string MedicName
        {
            get { return medicName; }
            set { medicName = value; }
        }

        public string PacientName
        {
            get { return pacientName; }
            set { pacientName = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion

        #region OVERRIDES
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