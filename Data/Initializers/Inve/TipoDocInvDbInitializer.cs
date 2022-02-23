using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Inve;

namespace WebApi2.Data.Initializers.Inve
{
    public class TipoDocInvDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.TipoDocsInv.Any())
            {
                return;
            }
            var tipoDocsInv = new TipoDocInv[] {
                new TipoDocInv
                {
                    TipoDocInvJson = "{\"TipoDocInv\":[{\"Codigo\":\"AR\",\"Nombre\":\"Traspasoalmacen-ruta\",\"Descrip\":\"Traspasodealmacenaruta\",\"Afecta\":\"Almacen-Ruta\",\"Tipo\":\"S\"},{\"Codigo\":\"EA\",\"Nombre\":\"EntradaAlmacen\",\"Descrip\":\"Articulosqueentranalalmacen\",\"Afecta\":\"Almacen\",\"Tipo\":\"E\"},{\"Codigo\":\"TEA\",\"Nombre\":\"Traspasoentrealmacenes\",\"Descrip\":\"Traspasarartículosdeunalmacenaotro\",\"Afecta\":\"Almacen\",\"Tipo\":\"S\"}]}",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId
                },
                new TipoDocInv
                {
                    TipoDocInvJson = "{\"TipoDocInv\":[{\"Codigo\":\"AR\",\"Nombre\":\"Traspasoalmacen-ruta\",\"Descrip\":\"Traspasodealmacenaruta\",\"Afecta\":\"Almacen-Ruta\",\"Tipo\":\"S\"},{\"Codigo\":\"EA\",\"Nombre\":\"EntradaAlmacen\",\"Descrip\":\"Articulosqueentranalalmacen\",\"Afecta\":\"Almacen\",\"Tipo\":\"E\"},{\"Codigo\":\"TEA\",\"Nombre\":\"Traspasoentrealmacenes\",\"Descrip\":\"Traspasarartículosdeunalmacenaotro\",\"Afecta\":\"Almacen\",\"Tipo\":\"S\"}]}",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId
                }
            };
            try
            {
                foreach (TipoDocInv tdi in tipoDocsInv)
                {
                    context.TipoDocsInv.Add(tdi);
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
