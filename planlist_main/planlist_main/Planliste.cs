using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace planliste_main
{
    public class Planliste
    {
        /// <summary>
        /// Speicherort der Planliste.
        /// </summary>
        string path;
        List<Kategorie> kategorien = new List<Kategorie>();

        //void for now, success test later
        private void NeueKategorie(string Id_Kategorie, string Beschreibung)
        {
            Kategorie _new = new Kategorie(Id_Kategorie, Beschreibung);
            kategorien.Add(_new);
        }

        public void Save()
        {
        }
    }
}
