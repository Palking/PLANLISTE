using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planliste_main
{
    /// <summary>
    /// Enthält alle Informationen zu einem Plan. Versand- und Indexstände sind als Child-Objekte hinterlegt.
    /// </summary>
    public class Plan
    {
        #region PROPERTIES

        /// <summary>
        /// Plan ID, wird zum Speichern in SQL verwendet. Sollte nicht manipuliert werden.
        /// </summary>
        protected uint Id_Plan { get; set; }

        /// <summary>
        /// Gibt die zusammengesetzte Plannummer aus.
        /// </summary>
        /// TODO: Einzel Strings kombinieren.
        public string Plannummer { get; protected set; }

        /// <summary>
        /// Planbeschreibung als Klartext. Maximal [TBA] Zeichen.
        /// </summary>
        /// Might break this down to two different lines to represent current structure.
        public string Beschreibung { get; protected set; }

        #endregion
    }
}
