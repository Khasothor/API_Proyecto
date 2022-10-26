using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebApi2.Data;
using WebApi2.Data.Initializers.Infra;
using WebApi2.Data.Initializers.Persona;
using WebApi2.Data.Initializers.Otros;

namespace WebApi2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    //Infra
                    EntiOrgContDbInitializer.Initialize(context);
                    EntiOrgFactDbInitializer.Initialize(context);
                    SucursalDbInitializer.Initialize(context);
                    //AlmaRutaDbInitializer.Initialize(context);
                    //Persona
                    ClieProvDbInitializer.Initialize(context);
                    //PermisoUsuarioDbInitializer.Initialize(context);
                    //Otros
                    HorarioDbInitializer.Initialize(context);                  
                    UniMedDbInitializer.Initialize(context);
                    ClaveProdServDbInitializer.Initialize(context);
                    ConfigGenDbInitializer.Initialize(context);
                    ShortcutDbInitializer.Initialize(context);
                    AyudaDbInitializer.Initialize(context);
                    //Inventario
                    //EntradaSalidaDbInitializer.Initialize(context);
                    //TipoDocInvDbInitializer.Initialize(context);
                    //InventarioDbInitializer.Initialize(context);
                    //ExistenciaDbInitializer.Initialize(context);
                    ///CodAltInvDbInitializer.Initialize(context);
                    //HistoriaEntradaSalidaDbInitializer.Initialize(context);
                    
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
