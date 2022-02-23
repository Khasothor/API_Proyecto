using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Infra;

namespace WebApi2.Data.Initializers.Infra
{
    public class EntiOrgFactDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.EntiOrgsFact.Any())
            {
                return;
            }
            var entiOrgFacts = new EntiOrgFact[]
            {
                new EntiOrgFact{
                    RazonSocial = "Organizacion Primera S.A. de C.V.",
                    RFC = "XMAS040756XFC",
                    CodigoSAT = "N/A",
                    Regimen = "N/A",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    //DatosContacto = new EntiOrgCont()
                },
                new EntiOrgFact{
                    RazonSocial = "Organizacion Segunda S.A. de C.V.",
                    RFC = "XMAS040756XFC",
                    CodigoSAT = "N/A",
                    Regimen = "N/A",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    //DatosContacto = new EntiOrgCont()
                },
            };
            try
            {
                foreach (EntiOrgFact entiOrgFact in entiOrgFacts)
                {
                    context.EntiOrgsFact.Add(entiOrgFact);
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
