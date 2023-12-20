using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
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
        static List<Medic> allMedics; //List!!

        #endregion

        #region METHODS

        #region CONSTRUCTORS
        /// <summary>
        /// Construtor Medics
        /// </summary>
        static Medics()
        {
            allMedics = new List<Medic>();
            //inicializa array allMedics
        }

        #endregion

        #region PROPERTIES
        public static List<Medic> AllMedics
        {
            get { return allMedics.ToList(); } 
        }

        public static int TotalMedics
        {
            get { return allMedics.Count; }
        }

        #endregion

        #region OVERRIDES

        #endregion

        #region OTHERMETHODS

        /// <summary>
        /// Metodo para mostrar todos os medicos existentes na array Medic
        /// </summary>
        /// <param name="medic"></param>
        public static void ShowMedics(List<Medic> medicList)
        {
            foreach(var medic in medicList)
            {
                if (medic == null) continue;
                Console.WriteLine("Medic: {0} | {1} {2}", medic.MedicId, medic.FirstName, medic.LastName);
            }
        }

        /// <summary>
        /// Metodo para verificar se X medico existe atraves do seu medicId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="InputIsNull"></exception>
        /// <exception cref="MedicDoesNotExistException"></exception>
        public static bool MedicExists(int id)
        {
            if (id < 0) // se o id for "NULL" (abaixo de zero)
            {
                throw new InputIsNull("Invalid/NULL Medic ID provided"); // exception de null input
            }
            try
            {
                return allMedics.Any(medic => medic != null && medic.MedicId == id);
            }
            catch
            {
                throw new MedicDoesNotExistException("That medic does not exist!"); //exception do medico nao exister
            }

        }

        /// <summary>
        /// Metodo para contar todos os medicos instanciados na array
        /// </summary>
        /// <returns></returns>
        public static int CountMedics()
        {
            Console.WriteLine($"Total number of medics: {TotalMedics}"); //Pega na variavel totMedicos que e incrementada(++) sempre que um medico e instanciado
            return TotalMedics;
        }


        /// <summary>
        /// Metodo para inserir medico na array
        /// </summary>
        /// <param name="medic"></param>
        /// <returns></returns>
        /// <exception cref="CantInsertMedic"></exception>
        public static bool InsertMedic(Medic medic)
        {
            if(MedicExists(medic.MedicId))
            {
                throw new AlreadyExists($"Medic with medic ID {medic.MedicId} already exists!"); // Exception para evitar medicos duplicados
            }

            try // try > catch com uma exception caso nao seja possivel inserir o medico na array
            {
                if (allMedics.Count < MAXMEDICS) // se o numero de medicos for superior ao maximo definido, o medico nao sera inserido
                {
                    allMedics.Add(medic);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw new CantInsertMedic("It was not possible to insert a medic on the list!");
            }
        }

        /// <summary>
        /// Metodo para remover X medico da array atraves do seu MedicId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool RemoveMedic(int id)
        {
            Medic medicToRemove = allMedics.FirstOrDefault(medic => medic != null && medic.MedicId == id);

            if (medicToRemove != null)
            {
                return allMedics.Remove(medicToRemove);
            }

            return false; 
        }


        /// <summary>
        /// Metodo para obter o nome do medico atraves do parametro ID para a variavel MedicID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="InputIsNull"></exception>
        /// <exception cref="MedicDoesNotExistException"></exception>
        public static string GetMedicName(int id) 
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

        /// <summary>
        /// Metodo para obter o MedicID atraves do nif da classe Pessoa -> Medic
        /// </summary>
        /// <param name="nif"></param>
        /// <returns></returns>
        /// <exception cref="InputIsNull"></exception>
        /// <exception cref="MedicDoesNotExistException"></exception>
        public static string GetMedicID(int nif)
        {
            foreach(Medic medic in allMedics)
            {
                if(nif < 0) // se o nif for abaixo de 0 da erro/exception
                {
                    throw new InputIsNull("Invalid/NULL Medic ID provided");
                }
                if(medic != null && medic.nif == nif)
                {
                    return $"The NIF {nif} corresponds to the medic ID: " + medic.MedicId.ToString();
                }
            }
            throw new MedicDoesNotExistException("That medic does not exist!"); // exception caso seja introduzido um nif que nao corresponde a nenhum medico
        }

        /// <summary>
        /// Metodo para guardar os medicos na array
        /// </summary>
        /// <param name="fName"></param>
        /// <returns></returns>
        public bool SaveMedicsXML(string fName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Medic[]));
                TextWriter textWriter = new StreamWriter(fName);
                serializer.Serialize(textWriter, allMedics);
                textWriter.Close();
                return true;
            }
            catch (IOException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Metodo para carregar os medicso do ficheiro
        /// </summary>
        /// <param name="fName"></param>
        /// <returns></returns>
        public bool LoadMedicsXML(string fName)
        {
            if (File.Exists(fName))
            {
                try
                {
                    Stream stream = File.Open(fName, FileMode.Open);
                    XmlSerializer xs = new XmlSerializer(typeof(Medic[]));
                    allMedics = (List<Medic>)xs.Deserialize(stream);

                    return true;
                }
                catch (IOException e)
                {
                    return false;
                }
            }
            return false;
        }
        #endregion

        #region DESTRUCTOR

        #endregion
        #endregion
    }
}
