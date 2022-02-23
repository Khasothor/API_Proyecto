using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Otros;

namespace WebApi2.Data.Initializers.Otros
{
    public class ConfigGenDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.ConfigsGen.Any())
            {
                return;
            }
            var configsGen = new ConfigGen[]
            {
                new ConfigGen
                {
                    ZonasHorarias = "{\"ZonaHoraria\": [{\"SucursalId\":1,\"ZonaHor\": 1},{\"SucursalId\":2,\"ZonaHor\": 2}]}",
                    FormFolMovInve = "[SUC]-[FEC]-[AR]-[MOV]-[NUM]",
                    InicioFolMovInve = 4,
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                },
                new ConfigGen
                {
                    ZonasHorarias = "{\"ZonaHoraria\": [{\"SucursalId\":3,\"ZonaHor\": 1},{\"SucursalId\":4,\"ZonaHor\": 2}]}",
                    FormFolMovInve = "[SUC]-[FEC]-[AR]-[MOV]-[NUM]",
                    InicioFolMovInve = 49,
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                },
                
            };
            try
            {
                foreach (ConfigGen cg in configsGen)
                {
                    context.ConfigsGen.Add(cg);
                }
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
