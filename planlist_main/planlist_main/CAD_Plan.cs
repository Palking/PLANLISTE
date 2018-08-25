using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planliste_main
{
    class CAD_Plan : Plan
    {
        List<Layout> layouts = new List<Layout>();

        public CAD_Plan(uint _Id)
        {
            Id_Plan = _Id;
        }

        /// <summary>
        /// Erstellt ein neues Layout für den aktuellen Plan.
        /// </summary>
        void NewLayout()
        {
            uint _IdLayout = (uint)layouts.Count();
            Layout _newLayout = new Layout(Id_Plan, _IdLayout);
            layouts.Add(_newLayout);
        }
    }
}
