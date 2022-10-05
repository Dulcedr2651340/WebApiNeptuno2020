using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace WebApiNeptuno2020API.Models
{
    public class pa_pedidos_empleado
    {
        [Key]
        public int IdPedido { get; set; }
        public string FechaPedido { get; set; }
        public int Cant_Productos { get; set; }
        public decimal Importe { get; set; }
    }
}
