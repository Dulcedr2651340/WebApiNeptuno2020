using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//importar estas librerias
using WebAPINeptuno2020API.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPINeptuno2020API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeptunoAPIController : ControllerBase
    {
        private readonly neptuno2020apiContext bd;

        public NeptunoAPIController(neptuno2020apiContext x)
        {
            bd = x;
        }

        // método web de tipo ActionResult que devolverá una Lista
        // de los pedidos por codigo de empleado
        // COMO ES EL 1ER Y ÚNICO MÉTODO GET EN ESTE CONTROLADOR, SOLO
        // NECESITAMOS LLAMARLO DESDE LA URL: , no es necesario poner GETPEDIDOSEMPLEADO EN la url
        // http://localhost:puerto/api/NeptunoAPI/valor_id
        [HttpGet("{cod}", Name = "GetPedidosEmpleado")]
        public List<pa_pedidos_empleado> GetPedidosEmpleado(int cod = 1)
        {
            var listado = bd.Pa_Pedidos_Empleado
                .FromSqlRaw("exec pa_pedidos_empleado {0}", cod)
                .ToList();  

            return listado;

        }

    }
}
