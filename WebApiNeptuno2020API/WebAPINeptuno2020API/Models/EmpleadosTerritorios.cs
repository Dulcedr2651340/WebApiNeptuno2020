using System;
using System.Collections.Generic;

namespace WebAPINeptuno2020API.Models
{
    public partial class EmpleadosTerritorios
    {
        public int IdEmpleado { get; set; }
        public string IdTerritorio { get; set; }

        public virtual Empleados IdEmpleadoNavigation { get; set; }
        public virtual Territorios IdTerritorioNavigation { get; set; }
    }
}
