using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO.Classes
{

    public interface IRegister
    {
        /// <summary>
        /// Interface para registar informacoes no sistema hospitalar e tudo relacionado com consultas
        /// </summary>
        #region ATTRIBUTES
        #endregion

        #region METHODS

        void RegisterInformation();
        void UnregisterInformation();
        void ScheduleAppointment();
        void CancelAppointment();
        void ShowAppointmentResults();
        #endregion
    }
}
