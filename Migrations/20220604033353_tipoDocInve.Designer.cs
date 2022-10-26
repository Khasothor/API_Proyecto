﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi2.Data;

#nullable disable

namespace WebApi2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220604033353_tipoDocInve")]
    partial class tipoDocInve
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApi2.Models.Infra.AlmaRuta", b =>
                {
                    b.Property<int>("AlmaRutaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlmaRutaId"), 1L, 1);

                    b.Property<string>("Catego")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid?>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EntiOrgId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Observ")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("SucursalId")
                        .HasColumnType("int");

                    b.Property<int>("Sucursales")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("AlmaRutaId");

                    b.HasIndex("EntiOrgContId");

                    b.HasIndex("SucursalId");

                    b.ToTable("AlmaRutas");
                });

            modelBuilder.Entity("WebApi2.Models.Infra.EntiOrgCont", b =>
                {
                    b.Property<Guid>("EntiOrgContId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DatosCont")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("EntiOrgContId");

                    b.ToTable("EntiOrgsCont");
                });

            modelBuilder.Entity("WebApi2.Models.Infra.EntiOrgFact", b =>
                {
                    b.Property<Guid>("EntiOrgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoSAT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RFC")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Regimen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntiOrgId");

                    b.HasIndex("EntiOrgContId")
                        .IsUnique();

                    b.ToTable("EntiOrgsFact");
                });

            modelBuilder.Entity("WebApi2.Models.Infra.Sucursal", b =>
                {
                    b.Property<int>("SucursalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SucursalId"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EntiOrgId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IVA")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Observ")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RFC")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("RazonSoc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("SucursalId");

                    b.HasIndex("EntiOrgContId");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.Caracteristica", b =>
                {
                    b.Property<Guid>("CaracteristicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CaractFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CaracteristicaJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CaracteristicaId");

                    b.HasIndex("CaractFK")
                        .IsUnique();

                    b.ToTable("Caracteristicas");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.Existencia", b =>
                {
                    b.Property<Guid>("ExistenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExisAlmaJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExisLineJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExistFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoteJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Restriccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UbicacionJson")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExistenciaId");

                    b.HasIndex("ExistFK")
                        .IsUnique();

                    b.ToTable("Existencias");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.Inventario", b =>
                {
                    b.Property<Guid>("InventarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClaveProdServ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Descrip")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Factor")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Lote")
                        .HasColumnType("bit");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreCor")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NumSerie")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UMS")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InventarioId");

                    b.HasIndex("EntiOrgContId");

                    b.ToTable("Inventarios");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.InveProv", b =>
                {
                    b.Property<Guid>("InveProvId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InveProvJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProvFK")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("InveProvId");

                    b.HasIndex("ProvFK")
                        .IsUnique();

                    b.ToTable("InveProvs");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.TipoDocInv", b =>
                {
                    b.Property<int>("TipoDocInvId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoDocInvId"), 1L, 1);

                    b.Property<bool>("AfectaA")
                        .HasColumnType("bit");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EntiOrgCont")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("TipoDocInvId");

                    b.HasIndex("EntiOrgContId");

                    b.ToTable("TipoDocsInv");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.Ubicacion", b =>
                {
                    b.Property<Guid>("UbicacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UbiFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UbicacionJson")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UbicacionId");

                    b.HasIndex("UbiFK")
                        .IsUnique();

                    b.ToTable("Ubicaciones");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.Ayuda", b =>
                {
                    b.Property<int>("AyudaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AyudaId"), 1L, 1);

                    b.Property<string>("Conceptos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AyudaId");

                    b.ToTable("Ayudas");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.ClaveProdServ", b =>
                {
                    b.Property<int>("ClaveProdServId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClaveProdServId"), 1L, 1);

                    b.Property<string>("ClaveProdJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaveServJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClaveProdServId");

                    b.HasIndex("EntiOrgContId");

                    b.ToTable("ClavesProdServ");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.ConfigGen", b =>
                {
                    b.Property<int>("configGenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("configGenId"), 1L, 1);

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FormFolMovInve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InicioFolMovInve")
                        .HasColumnType("int");

                    b.Property<string>("ZonasHorarias")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("configGenId");

                    b.HasIndex("EntiOrgContId")
                        .IsUnique();

                    b.ToTable("ConfigsGen");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.Horario", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HorarioId"), 1L, 1);

                    b.Property<string>("Codigo")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Descrip")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HorarioJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("HorarioId");

                    b.HasIndex("EntiOrgContId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.Link", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LinkId"), 1L, 1);

                    b.Property<string>("Enlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstaEnJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomPer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LinkId");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.Notificacion", b =>
                {
                    b.Property<Guid>("NotificacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Accion")
                        .HasColumnType("int");

                    b.Property<float>("Cantidad")
                        .HasColumnType("real");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<string>("ObjetoJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrigenId")
                        .HasColumnType("int");

                    b.Property<int>("Tabla")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int>("TipoMovId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("NotificacionId");

                    b.ToTable("Notificaciones");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.Shortcut", b =>
                {
                    b.Property<int>("ShortcutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShortcutId"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Descrip")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ShortcutId");

                    b.HasIndex("EntiOrgContId");

                    b.ToTable("Shortcuts");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.UniMed", b =>
                {
                    b.Property<int>("UniMedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UniMedId"), 1L, 1);

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UnidadMedida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnidadMedidaOf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UniMedId");

                    b.HasIndex("EntiOrgContId")
                        .IsUnique();

                    b.ToTable("UnidadesMedida");
                });

            modelBuilder.Entity("WebApi2.Models.Persona.ClieProv", b =>
                {
                    b.Property<int>("ClieprovId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClieprovId"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("DatosCont")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EntiOrgId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Giro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Observ")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RFC")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("RazonSoc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("ClieprovId");

                    b.ToTable("ClieProvs");
                });

            modelBuilder.Entity("WebApi2.Models.Persona.ConfigUsuario", b =>
                {
                    b.Property<int>("ConfigUsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConfigUsuarioId"), 1L, 1);

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FormatoFecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PuntoComa")
                        .HasColumnType("bit");

                    b.Property<string>("Temas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConfigUsuarioId");

                    b.ToTable("ConfiguracionUsuario");
                });

            modelBuilder.Entity("WebApi2.Models.Persona.PermisoUsuario", b =>
                {
                    b.Property<int>("PermisoUsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermisoUsuarioId"), 1L, 1);

                    b.Property<string>("Almacen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaveProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaveServ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clientes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfigGen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DatoUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("EntiOrgCont")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntiOrgFact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Existencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Historial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InveProv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inventario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proveedores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ruta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shortcut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sucursal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TiempoAcceso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TiempoExtra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocInv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniMedDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniMedFact")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermisoUsuarioId");

                    b.ToTable("PermisosUsuario");
                });

            modelBuilder.Entity("WebApi2.Models.Infra.AlmaRuta", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", null)
                        .WithMany("AlmaRutas")
                        .HasForeignKey("EntiOrgContId");

                    b.HasOne("WebApi2.Models.Infra.Sucursal", null)
                        .WithMany("AlmaRutas")
                        .HasForeignKey("SucursalId");
                });

            modelBuilder.Entity("WebApi2.Models.Infra.EntiOrgFact", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", "EntiOrgCont")
                        .WithOne("DatosFactura")
                        .HasForeignKey("WebApi2.Models.Infra.EntiOrgFact", "EntiOrgContId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntiOrgCont");
                });

            modelBuilder.Entity("WebApi2.Models.Infra.Sucursal", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", null)
                        .WithMany("Sucursales")
                        .HasForeignKey("EntiOrgContId");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.Caracteristica", b =>
                {
                    b.HasOne("WebApi2.Models.Inve.Inventario", "Inv")
                        .WithOne("Caracteristicas")
                        .HasForeignKey("WebApi2.Models.Inve.Caracteristica", "CaractFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inv");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.Existencia", b =>
                {
                    b.HasOne("WebApi2.Models.Inve.Inventario", "Inv")
                        .WithOne("ExistenciaInv")
                        .HasForeignKey("WebApi2.Models.Inve.Existencia", "ExistFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inv");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.Inventario", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", "EntiOrgCont")
                        .WithMany("Inventarios")
                        .HasForeignKey("EntiOrgContId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntiOrgCont");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.InveProv", b =>
                {
                    b.HasOne("WebApi2.Models.Inve.Inventario", "Inv")
                        .WithOne("InveProvs")
                        .HasForeignKey("WebApi2.Models.Inve.InveProv", "ProvFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inv");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.TipoDocInv", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", null)
                        .WithMany("TipoDocsInve")
                        .HasForeignKey("EntiOrgContId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi2.Models.Inve.Ubicacion", b =>
                {
                    b.HasOne("WebApi2.Models.Inve.Inventario", "Inv")
                        .WithOne("UbicacionInv")
                        .HasForeignKey("WebApi2.Models.Inve.Ubicacion", "UbiFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inv");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.ClaveProdServ", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", "EntiOrgCont")
                        .WithMany("ClaveProdServs")
                        .HasForeignKey("EntiOrgContId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntiOrgCont");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.ConfigGen", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", "EntiOrgCont")
                        .WithOne("ConfigsGen")
                        .HasForeignKey("WebApi2.Models.Otros.ConfigGen", "EntiOrgContId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntiOrgCont");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.Horario", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", "EntiOrgCont")
                        .WithMany("Horarios")
                        .HasForeignKey("EntiOrgContId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntiOrgCont");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.Shortcut", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", "EntiOrgCont")
                        .WithMany("Shortcuts")
                        .HasForeignKey("EntiOrgContId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntiOrgCont");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.UniMed", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", "EntiOrgCont")
                        .WithOne("UniMeds")
                        .HasForeignKey("WebApi2.Models.Otros.UniMed", "EntiOrgContId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntiOrgCont");
                });

            modelBuilder.Entity("WebApi2.Models.Infra.EntiOrgCont", b =>
                {
                    b.Navigation("AlmaRutas");

                    b.Navigation("ClaveProdServs");

                    b.Navigation("ConfigsGen");

                    b.Navigation("DatosFactura");

                    b.Navigation("Horarios");

                    b.Navigation("Inventarios");

                    b.Navigation("Shortcuts");

                    b.Navigation("Sucursales");

                    b.Navigation("TipoDocsInve");

                    b.Navigation("UniMeds");
                });

            modelBuilder.Entity("WebApi2.Models.Infra.Sucursal", b =>
                {
                    b.Navigation("AlmaRutas");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.Inventario", b =>
                {
                    b.Navigation("Caracteristicas");

                    b.Navigation("ExistenciaInv");

                    b.Navigation("InveProvs");

                    b.Navigation("UbicacionInv");
                });
#pragma warning restore 612, 618
        }
    }
}
