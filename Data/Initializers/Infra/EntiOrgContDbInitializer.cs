using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi2.Models.Infra;
using WebApi2.Models.Persona;

namespace WebApi2.Data.Initializers.Infra
{
    public class EntiOrgContDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.EntiOrgsCont.Any())
            {
                return;
            }
            var entiOrgsCont = new EntiOrgCont[]
            {
                new EntiOrgCont
                {
                    Nombre = "Organizacion Uno",
                    DatosCont = DatosOrgJson.Convertir(1),
                    //Sucursales = new List<Sucursal>(),
                    //ClieProvs = new List<ClieProv>(),
                    //DatosFacturacion = new EntiOrgFact(),
                },
                new EntiOrgCont
                {
                    Nombre = "Organizacion Dos",
                    DatosCont = DatosOrgJson.Convertir(2),
                    //Sucursales = new List<Sucursal>(),
                    //ClieProvs = new List<ClieProv>(),
                    //DatosFacturacion = new EntiOrgFact(),
                    
                },
            };
            try
            {
                foreach (EntiOrgCont entiOrgCont in entiOrgsCont)
                {
                    context.EntiOrgsCont.Add(entiOrgCont);
                }
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }

    public class DatosOrgJson
    {
        class DatosOrg
        {
            public List<Ubicacion> Ubicaciones { get; set; } = new List<Ubicacion>();
            public List<Telefono> Telefonos { get; set; } = new List<Telefono>();
            public string Email { get; set; }
        }
        class Ubicacion
        {
            public string Domicilio { get; set; }
            public string Ciudad { get; set; }
            public string Estado { get; set; }
        }
        class Telefono
        {
            public string Tipo { get; set; }
            public string Numero { get; set; }
        }

        public static string Convertir(int x)
        {
            //DatosContacto dc1 = new DatosContacto();
            DatosOrg dc1 = new DatosOrg
            {
                Email = "org2@mail.com",
                Telefonos =
                {
                    new Telefono
                    {
                        Numero = "234-123-1111",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "876-143-1111",
                        Tipo = "Fijo"
                    },
                },
                Ubicaciones =
                {
                    new Ubicacion
                    {
                        Domicilio = "Proveedores 111 sur",
                        Ciudad = "Ciudad Prov1",
                        Estado = "Estado Prov1"
                    }
                }
            };

            DatosOrg dc2 = new DatosOrg
            {
                Email = "proveedor2@mail.com",
                Telefonos =
                {
                    new Telefono
                    {
                        Numero = "234-123-2222",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "876-143-2222",
                        Tipo = "Fijo"
                    },
                },
                Ubicaciones =
                {
                    new Ubicacion
                    {
                        Domicilio = "Proveedores 222 sur",
                        Ciudad = "Ciudad Prov2",
                        Estado = "Estado Prov2"
                    }
                }
            };

            string jsonString = "";
            switch (x)
            {
                case 1:
                    jsonString = JsonSerializer.Serialize(dc1);
                    break;
                case 2:
                    jsonString = JsonSerializer.Serialize(dc2);
                    break;
                default:
                    break;
            }

            return jsonString;
        }

    }
}
