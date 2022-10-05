using System;
using System.Collections.Generic;

namespace WebAPINeptuno2020API.Models
{
    public partial class DetallesPedidos
    {
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }
        public int? Eliminado { get; set; }

        public virtual Pedidos IdPedidoNavigation { get; set; }
        public virtual Productos IdProductoNavigation { get; set; }
    }
}
