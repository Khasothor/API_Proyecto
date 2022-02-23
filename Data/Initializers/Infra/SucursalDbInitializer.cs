using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Infra;

namespace WebApi2.Data.Initializers.Infra
{
    public class SucursalDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Sucursales.Any())
            {
                return;
            }
            var sucursales = new Sucursal[] { 
                new Sucursal
                {
                    Codigo = "SUCNORTE100",
                    Nombre = "Sucursal Norte 100",
                    Observ = "Sucursal se encuentra al norte de la ciudad y se encarga de recibir materia prima",
                    Status = true,
                    Direccion = "Direccion de la sucursal 1 de la entidad organizacional 1",
                    Telefono = "555-331-3521",
                    Mail = "empresa1_sucnorte@mail.com",
                    RazonSoc = "entidad organizacional Primera S.A. de C.V.",
                    IVA = false,
                    RFC = "RFCdeSucursal",
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
                },
                new Sucursal
                {
                    Codigo = "SUCSUR101",
                    Nombre = "Sucursal Sur 100",
                    Observ = "Sucursal se encuentra al norte de la ciudad y se encarga de recibir materia prima",
                    Status = true,
                    Direccion = "Direccion de la sucursal 2 de la entidad organizacional 1",
                    Telefono = "555-331-3521",
                    Mail = "empresa1_sucsur@mail.com",
                    RazonSoc = "entidad organizacional primera S.A. de C.V.",
                    IVA = false,
                    RFC = "RFCdeSucursal",
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
                },
                new Sucursal
                {
                    Codigo = "SUCESTE102",
                    Nombre = "Sucursal Este 100",
                    Observ = "Sucursal se encuentra al este de la ciudad y se encarga de recibir materia prima",
                    Status = true,
                    Direccion = "Direccion de la sucursal de la entidad organizacional 1",
                    Telefono = "555-331-3521",
                    Mail = "empresa1_sucest@mail.com",
                    RazonSoc = "entidad organizacional primera S.A. de C.V.",
                    IVA = false,
                    RFC = "RFCdeSucursal",
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
                },

                new Sucursal
                {
                    Codigo = "SUCESTE103",
                    Nombre = "Sucursal Este 100",
                    Observ = "Sucursal se encuentra al este de la ciudad y se encarga de recibir materia prima",
                    Status = true,
                    Direccion = "Direccion de la sucursal de la entidad organizacional 2",
                    Telefono = "555-331-3521",
                    Mail = "empresa1_sucest@mail.com",
                    RazonSoc = "entidad organizacional segunda S.A. de C.V.",
                    IVA = false,
                    RFC = "RFCdeSucursal",
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
                },
                new Sucursal
                {
                    Codigo = "SUCOESTE104",
                    Nombre = "Sucursal Oeste 100",
                    Observ = "Sucursal se encuentra al oeste de la ciudad y se encarga de recibir materia prima",
                    Status = true,
                    Direccion = "Direccion de la sucursal de la entidad organizacional 2",
                    Telefono = "555-331-3521",
                    Mail = "empresa1_suceost@mail.com",
                    RazonSoc = "entidad organizacional segunda S.A. de C.V.",
                    IVA = false,
                    RFC = "RFCdeSucursal",
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
                },
                new Sucursal
                {
                    Codigo = "SUCNORTE105",
                    Nombre = "Sucursal Norte 100",
                    Observ = "Sucursal se encuentra al norte de la ciudad y se encarga de recibir materia prima",
                    Status = true,
                    Direccion = "Direccion de la sucursal de la entidad organizacional 2",
                    Telefono = "555-331-3521",
                    Mail = "empresa1_sucnorte@mail.com",
                    RazonSoc = "entidad organizacional segunda S.A. de C.V.",
                    IVA = false,
                    RFC = "RFCdeSucursal",
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
                }
            };
            try
            {
                foreach (Sucursal sucursal in sucursales)
                {
                    context.Sucursales.Add(sucursal);
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
