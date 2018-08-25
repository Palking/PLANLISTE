using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace planliste_main
{
    /// <summary>
    /// Enthält alle Pläne der jeweiligen Kostengruppe.
    /// </summary>
    class Kategorie
    {
        /// <summary>
        /// Kurzbeschreibung der Kategorie. Standardwert "KG400" - "KG480".
        /// </summary>
        string Id_Kategorie { get; set; }
        /// <summary>
        /// Klartext-Beschreibung der Kategorie. Standardwert entspricht Kostengruppenbezeichnung.
        /// </summary>
        string Beschreibung { get; set; }

        /// <summary>
        /// Speichert alle CAD Pläne aus einer Kategorie.
        /// </summary>
        List<CAD_Plan> CAD_Pläne = new List<CAD_Plan>();

        public Kategorie(string _IdKategorie, string _Beschreibung)
        {
            this.Id_Kategorie = _IdKategorie;
            this.Beschreibung = _Beschreibung;
        }

        public void NewCAD()
        {
            uint _Id = (uint)CAD_Pläne.Count();
            CAD_Plan _newCAD = new CAD_Plan(_Id);
        }

    }


    /// <summary>
    /// Sammlung der Kostengruppen. Evtl. refactor & speichern in Projekt-SQL.
    /// </summary>
    public enum Kostengruppen{
        [Description("Haustechnik")]
        HT      = 400,

        [Description("Abwasser-, Wasser-, Gasanlagen")]
        SAN     = 410,

        [Description("Wärmeversorgungsanlagen")]
        HK      = 420,

        [Description("Lufttechnische Anlagen")]
        RLT     = 430,

        [Description("Starkstromanlagen")]
        SSELT   = 440,

        [Description("Fernmelde- und Informationstechnische Anlagen")]
        FMELT   = 450,

        [Description("Förderanlagen")]
        F       = 460,

        [Description("Nutzungsspezifische Anlage")]
        NSP     = 470,

        [Description("Gebäudeautomation")]
        GA      = 480,

        [Description("Sonstige Maßnahmen für technische Anlagen")]
        SON     = 490
    }
}
