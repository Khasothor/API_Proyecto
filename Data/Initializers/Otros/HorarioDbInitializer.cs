using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Otros;

namespace WebApi2.Data.Initializers.Otros
{
    public class HorarioDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Horarios.Any())
            {
                return;
            }
            var horarios = new Horario[]
            {
                new Horario
                {
                    Nombre = "Horario Normal EntiOrg1",
                    Codigo = "H1E1",
                    Descrip = "Horario 1",
                    HorarioJson = "{\"domingo\":{\"inicio\":0,\"final\":0},\"lunes\":{\"inicio\":30600,\"final\":63000},\"martes\":{\"inicio\":30600,\"final\":63000},\"miercoles\":{\"inicio\":30600,\"final\":63000},\"jueves\":{\"inicio\":30600,\"final\":63000},\"viernes\":{\"inicio\":30600,\"final\":63000},\"sabado\":{\"inicio\":30600,\"final\":63000}}",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                },
                new Horario
                {
                    Nombre = "Horario Extendido EntiOrg1",
                    Codigo = "H2E1",
                    Descrip = "Horario 2",
                    HorarioJson = "{\"domingo\":{\"inicio\":0,\"final\":0},\"lunes\":{\"inicio\":30600,\"final\":63000},\"martes\":{\"inicio\":30600,\"final\":63000},\"miercoles\":{\"inicio\":30600,\"final\":63000},\"jueves\":{\"inicio\":30600,\"final\":63000},\"viernes\":{\"inicio\":30600,\"final\":63000},\"sabado\":{\"inicio\":34200,\"final\":52200}}",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                },
                new Horario
                {
                    Nombre = "Horario Normal EntiOrg2",
                    Codigo = "H1E2",
                    Descrip = "Horario 1",
                    HorarioJson = "{\"domingo\":{\"inicio\":0,\"final\":0},\"lunes\":{\"inicio\":30600,\"final\":63000},\"martes\":{\"inicio\":30600,\"final\":63000},\"miercoles\":{\"inicio\":30600,\"final\":63000},\"jueves\":{\"inicio\":30600,\"final\":63000},\"viernes\":{\"inicio\":30600,\"final\":63000},\"sabado\":{\"inicio\":30600,\"final\":63000}}",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                },
                new Horario
                {
                    Nombre = "Horario Extendido EntiOrg2",
                    Codigo = "H2E2",
                    Descrip = "Horario 2",
                    HorarioJson = "{\"domingo\":{\"inicio\":0,\"final\":0},\"lunes\":{\"inicio\":30600,\"final\":63000},\"martes\":{\"inicio\":30600,\"final\":63000},\"miercoles\":{\"inicio\":30600,\"final\":63000},\"jueves\":{\"inicio\":30600,\"final\":63000},\"viernes\":{\"inicio\":30600,\"final\":63000},\"sabado\":{\"inicio\":34200,\"final\":52200}}",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                },
            };
            try
            {
                foreach (Horario horario in horarios)
                {
                    context.Horarios.Add(horario);
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
