using System;
using System.Collections.Generic;

namespace WebApiNeptuno2020API.Models
{
    public partial class Empleados
    {
        public Empleados()
        {
            EmpleadosTerritorios = new HashSet<EmpleadosTerritorios>();
            Pedidos = new HashSet<Pedidos>();
        }

        public int IdEmpleado { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Cargo { get; set; }
        public string Tratamiento { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaContratacion { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string CodPostal { get; set; }
        public string Pais { get; set; }
        public string TelDomicilio { get; set; }
        public string Extension { get; set; }
        public string Notas { get; set; }
        public int? Jefe { get; set; }

        public virtual ICollection<EmpleadosTerritorios> EmpleadosTerritorios { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
