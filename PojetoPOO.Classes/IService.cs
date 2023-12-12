using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO.Classes
{
    public interface IService
    {
        /// <summary>
        /// Interface para os medicos e pacientes(Solicitar consulta, Prescrever medicamentos, etc..)
        /// </summary>

        #region METHODS

        void RequestAppointment()
        {

        }
        void PrescribeDrugs()
        {

        }

        #endregion
    }
}
