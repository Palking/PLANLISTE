using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planliste_main
{
    class Layout : Plan
    {
        /// <summary>
        /// ID des zugehörigen CAD Planes.
        /// </summary>
        uint parentId { get; }

        /// <summary>
        /// Maßstab der Zeichnung im Format "1:WERT". 0 für kein Maßstab.
        /// </summary>
        uint Maßstab { get; set; }

        /// <summary>
        /// Erstellt ein neues Layout. Benötigt zur Zuordnung die ID des CAD Planes.
        /// </summary>
        /// <param name="_parentId">ID des CAD Planes.</param>
        public Layout(uint _parentId, uint _IdLayout)
        {
            parentId = _parentId;
        }
    }
}
