using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Importar estas dos librerias
using WebAPINeptuno2020API.Models;
using Microsoft.EntityFrameworkCore;


namespace WebAPINeptuno2020API
{
    public class Startup
    {
        

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            

            //consumir el servicio desde otro lugar o tener acceso --> funciona como el crossorigin
            services.AddCors(); //permite que consumamos el servicio fuera del cleitne

            services.AddControllers();

            string conexion = Configuration.GetConnectionString("conex1");  //debe ser string 

            services.AddDbContext<neptuno2020apiContext>(
                opcion => opcion.UseSqlServer(conexion));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //// Para que el servicio web API pueda ser utilizado por React 
            /////configurar cors
            app.UseCors(
                x => x.WithOrigins("http://localhost:3000")
                .AllowAnyMethod()
                .AllowAnyHeader()
                );



            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            




        }
    }
}
