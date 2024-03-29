﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models.Infra;
using WebApi2.Models.Inve;
using WebApi2.Models.Otros;
using WebApi2.Models.Persona;

namespace WebApi2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        //==========TEST============
        public DbSet<Test> Tests { get; set; }
        //==========TEST============

        //infra
        public DbSet<EntiOrgCont> EntiOrgsCont { get; set; }
        public DbSet<EntiOrgFact> EntiOrgsFact { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<AlmaRuta> AlmaRutas { get; set; }
        
        //Persona
        public DbSet<ClieProv> ClieProvs { get; set; }
        public DbSet<PermisoUsuario> PermisosUsuario { get; set; }
        public DbSet<ConfigUsuario> ConfiguracionUsuario { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        //Otros
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<UniMed> UnidadesMedida { get; set; }
        public DbSet<ClaveProdServ> ClavesProdServ { get; set; }
        public DbSet<ConfigGen> ConfigsGen { get; set; }
        public DbSet<Shortcut> Shortcuts { get; set; }
        public DbSet<Ayuda> Ayudas { get; set; }
        public DbSet<Link> Link { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<TipoDocInv> TipoDocsInv { get; set; }
        //inve

        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Caracteristica> Caracteristicas { get; set; }
        public DbSet<Existencia> Existencias { get; set; }
        public DbSet<InveProv> InveProvs { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventario>()
                .HasOne(x => x.Caracteristicas)
                .WithOne(x => x.Inv)
                .HasForeignKey<Caracteristica>(x => x.CaractFK);

            modelBuilder.Entity<Inventario>()
                .HasOne(x => x.ExistenciaInv)
                .WithOne(x => x.Inv)
                .HasForeignKey<Existencia>(x => x.ExistFK);

            modelBuilder.Entity<Inventario>()
               .HasOne(x => x.InveProvs)
               .WithOne(x => x.Inv)
               .HasForeignKey<InveProv>(x => x.ProvFK);

            modelBuilder.Entity<Inventario>()
               .HasOne(x => x.UbicacionInv)
               .WithOne(x => x.Inv)
               .HasForeignKey<Ubicacion>(x => x.UbiFK);

            modelBuilder.Entity<Usuario>()
                .HasOne(x => x.PermisoUsuario_)
                .WithOne(x => x.Usuario_Permiso)
                .HasForeignKey<PermisoUsuario>(x => x.PermisoUsuarioFK);

            modelBuilder.Entity<Usuario>()
                .HasOne(x => x.ConfigUsuario_)
                .WithOne(x => x.Usuario_Config)
                .HasForeignKey<ConfigUsuario>(x => x.ConfigUsuarioFK);

        }

        public DbSet<WebApi2.Models.Otros.Test> Test { get; set; }
    }


}
