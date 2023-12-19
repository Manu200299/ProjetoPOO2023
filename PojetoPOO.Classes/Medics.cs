using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using ProjetoPOO.Exceptions;
/*
*	<copyright file="$file$" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>manol</author>
*   <date>12/18/2023 3:47:03 PM</date>
*	<description></description>
**/


namespace ProjetoPOO.Classes
{
    /// <summary>
    /// Purpose:
    /// Created by manol
    /// Created on: 12/18/2023 3:47:03 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Medics
    {
        #region ATTRIBUTES
        const int MAXMEDICS = 100;
        static int totMedics;
        static Medic[] allMedics;

        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// Construtor Medics
        /// </summary>
        static Medics()
        {
            totMedics++;
            allMedics = new Medic[MAXMEDICS];
            //inicializa array allMedics
        }

        #endregion

        #region PROPERTIES

        public static Medic[] AllMedics
        {
            get { return (Medic[])allMedics.Clone(); }
        }

        public static int TotalMedics
        {
            get { return totMedics; }
        }

        #endregion

        #region OVERRIDES

        #endregion

        #region OTHERMETHODS

        public static void ShowMedics(Medic[] medic) // Metodo para mostrar todos os medicos EXISTENTES / nao nulos na array
        {
            for(int i = 0; i < medic.Length; i++)
            {
                if (medic[i] == null) continue;
                Console.WriteLine("Medic: {0} | {1} {2}", medic[i].medicId, medic[i].firstName, medic[i].lastName);
            }
        }


        public static bool MedicExists(int id)
        {
            if (id <= 0) // "NULL" id
            {
                throw new InputIsNull("Invalid/NULL Medic ID provided");
            }

            foreach (Medic medic in allMedics)
            {
                if (medic != null && medic.MedicId == id)
                {
                    return true;
                }
            }

            throw new MedicDoesNotExistException("That medic does not exist!");
        }


        public static int CountMedics() // Metodo para contar todos os medicos instanciados na array
        {
            int medicCount = allMedics.Count();
            Console.WriteLine($"Total number of medics: {medicCount}");
            return allMedics.Count();
        }


        public static bool InsertMedic(Medic medic) // Metodo para inserir medico na arraylis
        {
            allMedics[totMedics] = medic;
            totMedics++;
            return true;
        }

        public static string GetMedicName(int id)  //Metodo para obter o nome do medico atraves do parametro ID para a variavel MedicID
        {
            foreach (Medic medic in allMedics)
            {
                if(id <= 0)
                {
                    throw new InputIsNull("Invalid/NULL Medic ID provided");
                }
                if (medic != null && medic.medicId == id)
                {
                    return $"The MedicID {id} corresponds to the medic: " + medic.FirstName + " " + medic.lastName;
                }
            }
            throw new MedicDoesNotExistException("That medic does not exist!");
        }

        public static string GetMedicID(int nif) // Metodo para obter o MedicID atraves do nif da classe Pessoa -> Medic
        {
            foreach(Medic medic in allMedics)
            {
                if(nif <= 0)
                {
                    throw new InputIsNull("Invalid/NULL Medic ID provided");
                }
                if(medic != null && medic.nif == nif)
                {
                    return $"The NIF {nif} corresponds to the medic ID: " + medic.MedicId.ToString();
                }
            }
            throw new MedicDoesNotExistException("That medic does not exist!");
        }
        #endregion

        #region DESTRUCTOR

        #endregion
        #endregion
    }
}
