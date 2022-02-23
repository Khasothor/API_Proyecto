using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Infra;

namespace WebApi2.Data.Initializers.Infra
{
    public class AlmaRutaDbInitializer
    {
        //public static void Initialize(ApplicationDbContext context)
        //{
        //    if (context.AlmaRutas.Any())
        //    {
        //        return;
        //    }
        //    var almaRutas = new AlmaRuta[] { 
        //        new AlmaRuta{
        //            Nombre = "Almacen1 Sucursal1 EntiOrg1",
        //            Tipo = "A",
        //            Catego = "Materia Prima",                    
        //            Codigo = "COD01",
        //            Observ = "Almacen para guardar materia prima",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCNORTE100").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen2 Sucursal1 EntiOrg1",
        //            Tipo = "A",
        //            Catego = "Material variado",
        //            Codigo = "COD02",
        //            Observ = "Almacen para guardar material electrico, mecanico, informatico",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCNORTE100").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen3 Sucursal1 EntiOrg1",
        //            Tipo = "A",
        //            Catego = "Material seguridad",
        //            Codigo = "COD03",
        //            Observ = "Almacen para guardar elementos de seguridad",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCNORTE100").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta1 Sucursal1 EntiOrg1",
        //            Tipo = "R",
        //            Catego = "Ruta Norte",
        //            Codigo = "COD04",
        //            Observ = "Ruta que recorre la zona norte",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCNORTE100").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta2 Sucursal1 EntiOrg1",
        //            Tipo = "R",
        //            Catego = "Ruta Sur",
        //            Codigo = "COD04",
        //            Observ = "Ruta que recorre la zona sur",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCNORTE100").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },

        //        new AlmaRuta{
        //            Nombre = "Almacen1 Sucursal2 EntiOrg1",
        //            Tipo = "A",
        //            Catego = "Materia Prima",
        //            Codigo = "COD01",
        //            Observ = "Almacen para guardar materia prima",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCSUR101").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen2 Sucursal2 EntiOrg1",
        //            Tipo = "A",
        //            Catego = "Material variado",
        //            Codigo = "COD02",
        //            Observ = "Almacen para guardar material electrico, mecanico, informatico",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCSUR101").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen3 Sucursal2 EntiOrg1",
        //            Tipo = "A",
        //            Catego = "Material seguridad",
        //            Codigo = "COD03",
        //            Observ = "Almacen para guardar elementos de seguridad",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCSUR101").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta1 Sucursal2 EntiOrg1",
        //            Tipo = "R",
        //            Catego = "Ruta Norte",
        //            Codigo = "COD04",
        //            Observ = "Ruta que recorre la zona norte",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCSUR101").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta2 Sucursal2 EntiOrg1",
        //            Tipo = "R",
        //            Catego = "Ruta Sur",
        //            Codigo = "COD04",
        //            Observ = "Ruta que recorre la zona sur",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCSUR101").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },

        //        new AlmaRuta{
        //            Nombre = "Almacen1 Sucursal3 EntiOrg1",
        //            Tipo = "A",
        //            Catego = "Materia Prima",
        //            Codigo = "COD05",
        //            Observ = "Almacen para guardar materia prima",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCESTE102").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen2 Sucursal3 EntiOrg1",
        //            Tipo = "A",
        //            Catego = "Material variado",
        //            Codigo = "COD06",
        //            Observ = "Almacen para guardar material electrico, mecanico, informatico",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCESTE102").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen3 Sucursal3 EntiOrg1",
        //            Tipo = "A",
        //            Catego = "Material seguridad",
        //            Codigo = "COD07",
        //            Observ = "Almacen para guardar elementos de seguridad",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCESTE102").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta1 Sucursal3 EntiOrg1",
        //            Tipo = "R",
        //            Catego = "Ruta Norte",
        //            Codigo = "COD08",
        //            Observ = "Ruta que recorre la zona norte",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCESTE102").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta2 Sucursal3 EntiOrg1",
        //            Tipo = "R",
        //            Catego = "Ruta Sur",
        //            Codigo = "COD09",
        //            Observ = "Ruta que recorre la zona sur",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCESTE102").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Uno").EntiOrgContId,
        //        },
        //        //*-------------------------------------------------------------------------------------------

        //        new AlmaRuta{
        //            Nombre = "Almacen1 Sucursal1 EntiOrg2",
        //            Tipo = "A",
        //            Catego = "Materia Prima",
        //            Codigo = "COD10",
        //            Observ = "Almacen para guardar materia prima",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCESTE103").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen2 Sucursal1 EntiOrg2",
        //            Tipo = "A",
        //            Catego = "Material variado",
        //            Codigo = "COD11",
        //            Observ = "Almacen para guardar material electrico, mecanico, informatico",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCESTE103").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen3 Sucursal1 EntiOrg2",
        //            Tipo = "A",
        //            Catego = "Material seguridad",
        //            Codigo = "COD12",
        //            Observ = "Almacen para guardar elementos de seguridad",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCESTE103").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta1 Sucursal1 EntiOrg2",
        //            Tipo = "R",
        //            Catego = "Ruta Norte",
        //            Codigo = "COD13",
        //            Observ = "Ruta que recorre la zona norte",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCESTE103").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta2 Sucursal1 EntiOrg2",
        //            Tipo = "R",
        //            Catego = "Ruta Sur",
        //            Codigo = "COD14",
        //            Observ = "Ruta que recorre la zona sur",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCESTE103").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },

        //        new AlmaRuta{
        //            Nombre = "Almacen1 Sucursal2 EntiOrg2",
        //            Tipo = "A",
        //            Catego = "Materia Prima",
        //            Codigo = "COD15",
        //            Observ = "Almacen para guardar materia prima",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCOESTE104").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen2 Sucursal2 EntiOrg2",
        //            Tipo = "A",
        //            Catego = "Material variado",
        //            Codigo = "COD16",
        //            Observ = "Almacen para guardar material electrico, mecanico, informatico",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCOESTE104").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen3 Sucursal2 EntiOrg2",
        //            Tipo = "A",
        //            Catego = "Material seguridad",
        //            Codigo = "COD17",
        //            Observ = "Almacen para guardar elementos de seguridad",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCOESTE104").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta1 Sucursal2 EntiOrg2",
        //            Tipo = "R",
        //            Catego = "Ruta Norte",
        //            Codigo = "COD18",
        //            Observ = "Ruta que recorre la zona norte",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCOESTE104").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta2 Sucursal2 EntiOrg2",
        //            Tipo = "R",
        //            Catego = "Ruta Sur",
        //            Codigo = "COD19",
        //            Observ = "Ruta que recorre la zona sur",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCOESTE104").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },

        //        new AlmaRuta{
        //            Nombre = "Almacen1 Sucursal3 EntiOrg2",
        //            Tipo = "A",
        //            Catego = "Materia Prima",
        //            Codigo = "COD20",
        //            Observ = "Almacen para guardar materia prima",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCNORTE105").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen2 Sucursal3 EntiOrg2",
        //            Tipo = "A",
        //            Catego = "Material variado",
        //            Codigo = "COD21",
        //            Observ = "Almacen para guardar material electrico, mecanico, informatico",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCNORTE105").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Almacen3 Sucursal3 EntiOrg2",
        //            Tipo = "A",
        //            Catego = "Material seguridad",
        //            Codigo = "COD22",
        //            Observ = "Almacen para guardar elementos de seguridad",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCNORTE105").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta1 Sucursal3 EntiOrg2",
        //            Tipo = "R",
        //            Catego = "Ruta Norte",
        //            Codigo = "COD23",
        //            Observ = "Ruta que recorre la zona norte",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCNORTE105").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //        new AlmaRuta{
        //            Nombre = "Ruta2 Sucursal3 EntiOrg2",
        //            Tipo = "R",
        //            Catego = "Ruta Sur",
        //            Codigo = "COD24",
        //            Observ = "Ruta que recorre la zona sur",
        //            Status = true,
        //            SucursalId = context.Sucursales.FirstOrDefault(x => x.Codigo == "SUCNORTE105").SucursalId,
        //            EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre == "Organizacion Dos").EntiOrgContId,
        //        },
        //    };
        //    try
        //    {
        //        foreach (AlmaRuta almaRuta in almaRutas)
        //        {
        //            context.AlmaRutas.Add(almaRuta);
        //        }
        //        context.SaveChanges();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
