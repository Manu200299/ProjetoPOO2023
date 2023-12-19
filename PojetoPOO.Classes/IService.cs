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
        /// Interface para os pacientes(Solicitar consulta, Solicitar reagendamento etc..)
        /// </summary>

        #region METHODS

        void RequestAppointment();
        void RequestRescheduleAppointment();

        #endregion
    }
}
