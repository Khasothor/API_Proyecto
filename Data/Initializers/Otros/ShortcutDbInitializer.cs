using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Otros;

namespace WebApi2.Data.Initializers.Otros
{
    public class ShortcutDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Shortcuts.Any())
            {
                return;
            }
            var shortcuts = new Shortcut[]
            {
                new Shortcut
                {                    
                    Codigo = "INV",
                    Descrip = "Navega hasta inventario",
                    Link = "inventario",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                },
                new Shortcut
                {
                    Codigo = "SUC",
                    Descrip = "Navega hasta sucursales",
                    Link = "sucursales",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                },
                //****************************************************************************
                new Shortcut
                {
                    Codigo = "INV",
                    Descrip = "Navega hasta inventario",
                    Link = "inventario",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                },
                new Shortcut
                {
                    Codigo = "SUC",
                    Descrip = "Navega hasta sucursales",
                    Link = "sucursales",
                    EntiOrgContId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                },
            };
            try
            {
                foreach (Shortcut shortcut in shortcuts)
                {
                    context.Shortcuts.Add(shortcut);
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
