using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Otros;

namespace WebApi2.Data.Initializers.Otros
{
    public class ClaveProdServDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.ClavesProdServ.Any())
            {
                return;
            }
            var clavesProdServ = new ClaveProdServ[] {
                new ClaveProdServ
                {
                    ClaveProdJson = "",
                    ClaveServJson = "",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId
                },
                new ClaveProdServ
                {
                    ClaveProdJson = "",
                    ClaveServJson = "",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId
                }
            };
            try
            {
                foreach (ClaveProdServ cps in clavesProdServ)
                {
                    context.ClavesProdServ.Add(cps);
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
