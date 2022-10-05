using System;
using System.Collections.Generic;

namespace WebApiNeptuno2020API.Models
{
    public partial class Territorios
    {
        public Territorios()
        {
            EmpleadosTerritorios = new HashSet<EmpleadosTerritorios>();
        }

        public string IdTerritorio { get; set; }
        public string Descripcion { get; set; }
        public int IdRegion { get; set; }

        public virtual Region IdRegionNavigation { get; set; }
        public virtual ICollection<EmpleadosTerritorios> EmpleadosTerritorios { get; set; }
    }
}
