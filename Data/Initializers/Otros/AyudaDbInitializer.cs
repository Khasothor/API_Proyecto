using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Otros;

namespace WebApi2.Data.Initializers.Otros
{
    public class AyudaDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Ayudas.Any())
            {
                return;
            }
            var ayudas = new Ayuda[]
            {
                new Ayuda
                {
                    Nombre = "",
                    Descripcion = "",
                    Conceptos = ""
                }
            };
            try
            {
                foreach (Ayuda ayuda in ayudas)
                {
                    context.Ayudas.Add(ayuda);
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
