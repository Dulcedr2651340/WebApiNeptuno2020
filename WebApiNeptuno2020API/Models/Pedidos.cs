using System;
using System.Collections.Generic;

namespace WebApiNeptuno2020API.Models
{
    public partial class Pedidos
    {
        public Pedidos()
        {
            DetallesPedidos = new HashSet<DetallesPedidos>();
        }

        public int IdPedido { get; set; }
        public string IdCliente { get; set; }
        public int? IdEmpleado { get; set; }
        public DateTime? FechaPedido { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public int? FormaEnvio { get; set; }
        public decimal? Cargo { get; set; }
        public string Destinatario { get; set; }
        public string DireccionDestinatario { get; set; }
        public string CiudadDestinatario { get; set; }
        public string RegionDestinatario { get; set; }
        public string CodPostalDestinatario { get; set; }
        public string PaisDestinatario { get; set; }
        public int? Eliminado { get; set; }

        public virtual Clientes IdClienteNavigation { get; set; }
        public virtual Empleados IdEmpleadoNavigation { get; set; }
        public virtual ICollection<DetallesPedidos> DetallesPedidos { get; set; }
    }
}
