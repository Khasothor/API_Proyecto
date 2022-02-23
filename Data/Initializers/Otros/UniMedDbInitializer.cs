using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Otros;

namespace WebApi2.Data.Initializers.Otros
{
    public class UniMedDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.UnidadesMedida.Any())
            {
                return;
            }
            var unidadesMedida = new UniMed[]
            {
                new UniMed
                {
                    UnidadMedida = "{\"UnidadMedida\":[{\"Clave\":\"Mts\",\"Tipo\":\"Distancia\",\"Nombre\":\"Metros\"},{\"Clave\":\"Cms\",\"Tipo\":\"Distancia\",\"Nombre\":\"Centímetros\"},{\"Clave\":\"Mms\",\"Tipo\":\"Distancia\",\"Nombre\":\"Milimetros\"},{\"Clave\":\"KG\",\"Tipo\":\"Peso\",\"Nombre\":\"Kilogramos\"},{\"Clave\":\"G\",\"Tipo\":\"Peso\",\"Nombre\":\"Gramos\"}]}",
                    UnidadMedidaOf = "{\"UnidadMedidaOf\":[{\"Clave\":\"H87\",\"Tipo\":\"Múltiplos / Fracciones / Decimales\",\"Nombre\":\"Pieza\"},{\"Clave\":\"EA\",\"Tipo\":\"Unidades de Venta\",\"Nombre\":\"Elemento\"},{\"Clave\":\"E48\",\"Tipo\":\"Unidades específicas de la industria (varias)\",\"Nombre\":\"Unidad de Servicio\"},{\"Clave\":\"ACT\",\"Tipo\":\"Actividad\",\"Nombre\":\"Unidades de Venta\"}]}",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                },
                
                new UniMed
                {
                    UnidadMedida = "{\"UnidadMedida\":[{\"Clave\":\"Mts\",\"Tipo\":\"Distancia\",\"Nombre\":\"Metros\"},{\"Clave\":\"Cms\",\"Tipo\":\"Distancia\",\"Nombre\":\"Centímetros\"},{\"Clave\":\"Mms\",\"Tipo\":\"Distancia\",\"Nombre\":\"Milimetros\"},{\"Clave\":\"KG\",\"Tipo\":\"Peso\",\"Nombre\":\"Kilogramos\"},{\"Clave\":\"G\",\"Tipo\":\"Peso\",\"Nombre\":\"Gramos\"}]}",
                    UnidadMedidaOf = "{\"UnidadMedidaOf\":[{\"Clave\":\"H87\",\"Tipo\":\"Múltiplos / Fracciones / Decimales\",\"Nombre\":\"Pieza\"},{\"Clave\":\"EA\",\"Tipo\":\"Unidades de Venta\",\"Nombre\":\"Elemento\"},{\"Clave\":\"E48\",\"Tipo\":\"Unidades específicas de la industria (varias)\",\"Nombre\":\"Unidad de Servicio\"},{\"Clave\":\"ACT\",\"Tipo\":\"Actividad\",\"Nombre\":\"Unidades de Venta\"}]}",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                },
            };
            try
            {
                foreach (UniMed uniMed in unidadesMedida)
                {
                    context.UnidadesMedida.Add(uniMed);
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
