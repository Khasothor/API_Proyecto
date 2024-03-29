﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi2.Data;

namespace WebApi2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220215014325_quit_col_extra_inve_clieprov")]
    partial class quit_col_extra_inve_clieprov
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi2.Models.Infra.AlmaRuta", b =>
                {
                    b.Property<int>("AlmaRutaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("WebApi2.Models.Inve.CodAltInv", b =>
                {
                    b.Property<Guid>("CodAltInvId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CodAltFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodAltInvJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CodAltInvId");

                    b.HasIndex("CodAltFK")
                        .IsUnique();

                    b.ToTable("CodsAltInv");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.EntradaSalida", b =>
                {
                    b.Property<Guid>("EntradaSalidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AlmaRutaId")
                        .HasColumnType("int");

                    b.Property<int>("ClieProvId")
                        .HasColumnType("int");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntradaSalidaJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Folio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.Property<string>("TipoDocInv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("EntradaSalidaId");

                    b.HasIndex("EntiOrgContId");

                    b.ToTable("EntradasSalidas");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.Existencia", b =>
                {
                    b.Property<Guid>("ExistenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExistFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExistenciaJson")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExistenciaId");

                    b.HasIndex("ExistFK")
                        .IsUnique();

                    b.ToTable("Existencias");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.HistoriaEntradaSalida", b =>
                {
                    b.Property<int>("HistoriaEntradaSalidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("EntiOrgCont")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HistoriaEntradaSalidaJson")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HistoriaEntradaSalidaId");

                    b.HasIndex("EntiOrgContId");

                    b.ToTable("HistoriaEntradaSalidas");
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

            modelBuilder.Entity("WebApi2.Models.Inve.TipoDocInv", b =>
                {
                    b.Property<int>("TipoDocInvId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("EntiOrgCont")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TipoDocInvJson")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoDocInvId");

                    b.HasIndex("EntiOrgContId")
                        .IsUnique();

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<int>("GonfigGenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FormFolMovInve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InicioFolMovInve")
                        .HasColumnType("int");

                    b.Property<string>("ZonasHorarias")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GonfigGenId");

                    b.HasIndex("EntiOrgContId")
                        .IsUnique();

                    b.ToTable("ConfigsGen");
                });

            modelBuilder.Entity("WebApi2.Models.Otros.Horario", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("WebApi2.Models.Otros.Shortcut", b =>
                {
                    b.Property<int>("ShortcutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DatoUsuarioId")
                        .HasColumnType("int");

                    b.Property<Guid>("EntiOrgContId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("PermisoSucursal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TiempoAcceso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TiempoExtra")
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

            modelBuilder.Entity("WebApi2.Models.Inve.CodAltInv", b =>
                {
                    b.HasOne("WebApi2.Models.Inve.Inventario", "Inv")
                        .WithOne("CodAlt")
                        .HasForeignKey("WebApi2.Models.Inve.CodAltInv", "CodAltFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inv");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.EntradaSalida", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", "EntiOrgCont")
                        .WithMany("EntradasSalidas")
                        .HasForeignKey("EntiOrgContId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntiOrgCont");
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

            modelBuilder.Entity("WebApi2.Models.Inve.HistoriaEntradaSalida", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", null)
                        .WithMany("HistoriaEntradaSalidas")
                        .HasForeignKey("EntiOrgContId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("WebApi2.Models.Inve.Inventario", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", "EntiOrgCont")
                        .WithMany("Inventarios")
                        .HasForeignKey("EntiOrgContId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntiOrgCont");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.TipoDocInv", b =>
                {
                    b.HasOne("WebApi2.Models.Infra.EntiOrgCont", null)
                        .WithOne("TipoDocsInv")
                        .HasForeignKey("WebApi2.Models.Inve.TipoDocInv", "EntiOrgContId")
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
                        .WithMany()
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

                    b.Navigation("ConfigsGen");

                    b.Navigation("DatosFactura");

                    b.Navigation("EntradasSalidas");

                    b.Navigation("HistoriaEntradaSalidas");

                    b.Navigation("Horarios");

                    b.Navigation("Inventarios");

                    b.Navigation("Shortcuts");

                    b.Navigation("Sucursales");

                    b.Navigation("TipoDocsInv");

                    b.Navigation("UniMeds");
                });

            modelBuilder.Entity("WebApi2.Models.Infra.Sucursal", b =>
                {
                    b.Navigation("AlmaRutas");
                });

            modelBuilder.Entity("WebApi2.Models.Inve.Inventario", b =>
                {
                    b.Navigation("Caracteristicas");

                    b.Navigation("CodAlt");

                    b.Navigation("ExistenciaInv");

                    b.Navigation("InveProvs");

                    b.Navigation("UbicacionInv");
                });
#pragma warning restore 612, 618
        }
    }
}
