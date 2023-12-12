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
    /// Purpose: Classe Bed - informacoes sobre as camas do hospital
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Bed
    {
        public Bed[] Beds { get; set; }
        private const int MAXBEDS = 250;

        #region ATTRIBUTES
        private int numberOfBeds;
        private int bedId;
        private string bedType;
        private string bedInfo;
        private string bedStatus;

        public enum BedStatus
        {
            Available,
            Occupied,
            Cleaning,
            Maintenance
        }

        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// The default constructor (Vai adicionar 1 cama na contagem do array a cada cama instanciada)
        /// </summary>
        public Bed(int totalCamas, int id, string type, string info, string status)
        {
            this.bedId = id;
            this.bedType = type;
            this.bedInfo = info;
            this.bedStatus = status;
        }

        #endregion

        #region PROPERTIES

        public int BedId
        {
            get { return this.bedId; }
            set { this.bedId = value; }
        }

        public string BedType
        {
            get { return this.bedType; }
            set { this.bedType = value; }
        }

        public string BedInfo
        {
            get { return this.bedInfo; }
            set { this.bedInfo = value; }
        }

        public BedStatus BedsStatus { get; set; }

        #endregion

        #region OVERRIDES
        #endregion

        #region OTHERMETHODS

        public string ShowBed()
        {
            return (String.Format($"Bed ID: {BedId}, Type: {BedType}, Info: {BedInfo}, Status: {BedsStatus}"));
        }

        #endregion

        #region DESTRUCTOR
        /// <summary>
        /// The default destructor
        /// </summary>
        #endregion
        #endregion
    }
}