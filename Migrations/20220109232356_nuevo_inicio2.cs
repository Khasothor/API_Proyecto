using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi2.Migrations
{
    public partial class nuevo_inicio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            

            
            migrationBuilder.CreateTable(
                name: "PermisosUsuario",
                columns: table => new
                {
                    PermisoUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatoUsuarioId = table.Column<int>(type: "int", nullable: false),
                    TiempoAcceso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiempoExtra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    PermisoSucursal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisosUsuario", x => x.PermisoUsuarioId);
                });

            //migrationBuilder.CreateTable(
            //    name: "ClavesProdServ",
            //    columns: table => new
            //    {
            //        ClaveProdServId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ClaveProdJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClaveServJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ClavesProdServ", x => x.ClaveProdServId);
            //        table.ForeignKey(
            //            name: "FK_ClavesProdServ_EntiOrgsCont_EntiOrgContId",
            //            column: x => x.EntiOrgContId,
            //            principalTable: "EntiOrgsCont",
            //            principalColumn: "EntiOrgContId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ConfigsGen",
            //    columns: table => new
            //    {
            //        GonfigGenId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        InicioFolMovInve = table.Column<int>(type: "int", nullable: false),
            //        FormFolMovInve = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ZonasHorarias = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ConfigsGen", x => x.GonfigGenId);
            //        table.ForeignKey(
            //            name: "FK_ConfigsGen_EntiOrgsCont_EntiOrgContId",
            //            column: x => x.EntiOrgContId,
            //            principalTable: "EntiOrgsCont",
            //            principalColumn: "EntiOrgContId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EntiOrgsFact",
            //    columns: table => new
            //    {
            //        EntiOrgId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        RazonSocial = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
            //        RFC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
            //        CodigoSAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Regimen = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EntiOrgsFact", x => x.EntiOrgId);
            //        table.ForeignKey(
            //            name: "FK_EntiOrgsFact_EntiOrgsCont_EntiOrgContId",
            //            column: x => x.EntiOrgContId,
            //            principalTable: "EntiOrgsCont",
            //            principalColumn: "EntiOrgContId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EntradasSalidas",
            //    columns: table => new
            //    {
            //        EntradaSalidaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Folio = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        TipoDocInv = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EntradaSalidaJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UsuarioId = table.Column<int>(type: "int", nullable: false),
            //        ClieProvId = table.Column<int>(type: "int", nullable: false),
            //        AlmaRutaId = table.Column<int>(type: "int", nullable: false),
            //        SucursalId = table.Column<int>(type: "int", nullable: false),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EntradasSalidas", x => x.EntradaSalidaId);
            //        table.ForeignKey(
            //            name: "FK_EntradasSalidas_EntiOrgsCont_EntiOrgContId",
            //            column: x => x.EntiOrgContId,
            //            principalTable: "EntiOrgsCont",
            //            principalColumn: "EntiOrgContId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HistoriaEntradaSalidas",
            //    columns: table => new
            //    {
            //        HistoriaEntradaSalidaId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        HistoriaEntradaSalidaJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        EntiOrgCont = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_HistoriaEntradaSalidas", x => x.HistoriaEntradaSalidaId);
            //        table.ForeignKey(
            //            name: "FK_HistoriaEntradaSalidas_EntiOrgsCont_EntiOrgContId",
            //            column: x => x.EntiOrgContId,
            //            principalTable: "EntiOrgsCont",
            //            principalColumn: "EntiOrgContId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Horarios",
            //    columns: table => new
            //    {
            //        HorarioId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Codigo = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
            //        Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Descrip = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        HorarioJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Horarios", x => x.HorarioId);
            //        table.ForeignKey(
            //            name: "FK_Horarios_EntiOrgsCont_EntiOrgContId",
            //            column: x => x.EntiOrgContId,
            //            principalTable: "EntiOrgsCont",
            //            principalColumn: "EntiOrgContId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Inventarios",
            //    columns: table => new
            //    {
            //        InventarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Codigo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        NombreCor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        Descrip = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        Status = table.Column<bool>(type: "bit", nullable: false),
            //        NumSerie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Modelo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UME = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UMS = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Factor = table.Column<float>(type: "real", nullable: false),
            //        ClaveProdServ = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Lote = table.Column<bool>(type: "bit", nullable: false),
            //        FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        DatosXtra = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Inventarios", x => x.InventarioId);
            //        table.ForeignKey(
            //            name: "FK_Inventarios_EntiOrgsCont_EntiOrgContId",
            //            column: x => x.EntiOrgContId,
            //            principalTable: "EntiOrgsCont",
            //            principalColumn: "EntiOrgContId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Shortcuts",
            //    columns: table => new
            //    {
            //        ShortcutId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Codigo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        Descrip = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Link = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Shortcuts", x => x.ShortcutId);
            //        table.ForeignKey(
            //            name: "FK_Shortcuts_EntiOrgsCont_EntiOrgContId",
            //            column: x => x.EntiOrgContId,
            //            principalTable: "EntiOrgsCont",
            //            principalColumn: "EntiOrgContId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Sucursales",
            //    columns: table => new
            //    {
            //        SucursalId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Codigo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Observ = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        Status = table.Column<bool>(type: "bit", nullable: false),
            //        FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        Mail = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
            //        RFC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
            //        RazonSoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        IVA = table.Column<bool>(type: "bit", nullable: false),
            //        EntiOrgId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Sucursales", x => x.SucursalId);
            //        table.ForeignKey(
            //            name: "FK_Sucursales_EntiOrgsCont_EntiOrgContId",
            //            column: x => x.EntiOrgContId,
            //            principalTable: "EntiOrgsCont",
            //            principalColumn: "EntiOrgContId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TipoDocsInv",
            //    columns: table => new
            //    {
            //        TipoDocInvId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TipoDocInvJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        EntiOrgCont = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TipoDocsInv", x => x.TipoDocInvId);
            //        table.ForeignKey(
            //            name: "FK_TipoDocsInv_EntiOrgsCont_EntiOrgContId",
            //            column: x => x.EntiOrgContId,
            //            principalTable: "EntiOrgsCont",
            //            principalColumn: "EntiOrgContId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UnidadesMedida",
            //    columns: table => new
            //    {
            //        UniMedId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UnidadMedida = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UnidadMedidaOf = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UnidadesMedida", x => x.UniMedId);
            //        table.ForeignKey(
            //            name: "FK_UnidadesMedida_EntiOrgsCont_EntiOrgContId",
            //            column: x => x.EntiOrgContId,
            //            principalTable: "EntiOrgsCont",
            //            principalColumn: "EntiOrgContId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Caracteristicas",
            //    columns: table => new
            //    {
            //        CaracteristicaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CaracteristicaJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CaractFK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Caracteristicas", x => x.CaracteristicaId);
            //        table.ForeignKey(
            //            name: "FK_Caracteristicas_Inventarios_CaractFK",
            //            column: x => x.CaractFK,
            //            principalTable: "Inventarios",
            //            principalColumn: "InventarioId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CodsAltInv",
            //    columns: table => new
            //    {
            //        CodAltInvId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CodAltInvJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CodAltFK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CodsAltInv", x => x.CodAltInvId);
            //        table.ForeignKey(
            //            name: "FK_CodsAltInv_Inventarios_CodAltFK",
            //            column: x => x.CodAltFK,
            //            principalTable: "Inventarios",
            //            principalColumn: "InventarioId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Existencias",
            //    columns: table => new
            //    {
            //        ExistenciaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ExistenciaJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ExistFK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Existencias", x => x.ExistenciaId);
            //        table.ForeignKey(
            //            name: "FK_Existencias_Inventarios_ExistFK",
            //            column: x => x.ExistFK,
            //            principalTable: "Inventarios",
            //            principalColumn: "InventarioId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "InveProvs",
            //    columns: table => new
            //    {
            //        InveProvId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        InveProvJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ProvFK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_InveProvs", x => x.InveProvId);
            //        table.ForeignKey(
            //            name: "FK_InveProvs_Inventarios_ProvFK",
            //            column: x => x.ProvFK,
            //            principalTable: "Inventarios",
            //            principalColumn: "InventarioId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Ubicaciones",
            //    columns: table => new
            //    {
            //        UbicacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        UbicacionJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UbiFK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Ubicaciones", x => x.UbicacionId);
            //        table.ForeignKey(
            //            name: "FK_Ubicaciones_Inventarios_UbiFK",
            //            column: x => x.UbiFK,
            //            principalTable: "Inventarios",
            //            principalColumn: "InventarioId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.CreateTable(
                name: "AlmaRutas",
                columns: table => new
                {
                    AlmaRutaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Observ = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Catego = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntiOrgId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sucursales = table.Column<int>(type: "int", nullable: false),
                    EntiOrgContId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SucursalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlmaRutas", x => x.AlmaRutaId);
                    table.ForeignKey(
                        name: "FK_AlmaRutas_EntiOrgsCont_EntiOrgContId",
                        column: x => x.EntiOrgContId,
                        principalTable: "EntiOrgsCont",
                        principalColumn: "EntiOrgContId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlmaRutas_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlmaRutas_EntiOrgContId",
                table: "AlmaRutas",
                column: "EntiOrgContId");

            migrationBuilder.CreateIndex(
                name: "IX_AlmaRutas_SucursalId",
                table: "AlmaRutas",
                column: "SucursalId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Caracteristicas_CaractFK",
            //    table: "Caracteristicas",
            //    column: "CaractFK",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_ClavesProdServ_EntiOrgContId",
            //    table: "ClavesProdServ",
            //    column: "EntiOrgContId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CodsAltInv_CodAltFK",
            //    table: "CodsAltInv",
            //    column: "CodAltFK",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_ConfigsGen_EntiOrgContId",
            //    table: "ConfigsGen",
            //    column: "EntiOrgContId",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_EntiOrgsFact_EntiOrgContId",
            //    table: "EntiOrgsFact",
            //    column: "EntiOrgContId",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_EntradasSalidas_EntiOrgContId",
            //    table: "EntradasSalidas",
            //    column: "EntiOrgContId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Existencias_ExistFK",
            //    table: "Existencias",
            //    column: "ExistFK",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_HistoriaEntradaSalidas_EntiOrgContId",
            //    table: "HistoriaEntradaSalidas",
            //    column: "EntiOrgContId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Horarios_EntiOrgContId",
            //    table: "Horarios",
            //    column: "EntiOrgContId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Inventarios_EntiOrgContId",
            //    table: "Inventarios",
            //    column: "EntiOrgContId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_InveProvs_ProvFK",
            //    table: "InveProvs",
            //    column: "ProvFK",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Shortcuts_EntiOrgContId",
            //    table: "Shortcuts",
            //    column: "EntiOrgContId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Sucursales_EntiOrgContId",
            //    table: "Sucursales",
            //    column: "EntiOrgContId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TipoDocsInv_EntiOrgContId",
            //    table: "TipoDocsInv",
            //    column: "EntiOrgContId",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Ubicaciones_UbiFK",
            //    table: "Ubicaciones",
            //    column: "UbiFK",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_UnidadesMedida_EntiOrgContId",
            //    table: "UnidadesMedida",
            //    column: "EntiOrgContId",
            //    unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlmaRutas");

            //migrationBuilder.DropTable(
            //    name: "Ayudas");

            //migrationBuilder.DropTable(
            //    name: "Caracteristicas");

            //migrationBuilder.DropTable(
            //    name: "ClavesProdServ");

            //migrationBuilder.DropTable(
            //    name: "ClieProvs");

            //migrationBuilder.DropTable(
            //    name: "CodsAltInv");

            //migrationBuilder.DropTable(
            //    name: "ConfigsGen");

            //migrationBuilder.DropTable(
            //    name: "ConfiguracionUsuario");

            //migrationBuilder.DropTable(
            //    name: "EntiOrgsFact");

            //migrationBuilder.DropTable(
            //    name: "EntradasSalidas");

            //migrationBuilder.DropTable(
            //    name: "Existencias");

            //migrationBuilder.DropTable(
            //    name: "HistoriaEntradaSalidas");

            //migrationBuilder.DropTable(
            //    name: "Horarios");

            //migrationBuilder.DropTable(
            //    name: "InveProvs");

            //migrationBuilder.DropTable(
            //    name: "Link");

            migrationBuilder.DropTable(
                name: "PermisosUsuario");

            //migrationBuilder.DropTable(
            //    name: "Shortcuts");

            //migrationBuilder.DropTable(
            //    name: "TipoDocsInv");

            //migrationBuilder.DropTable(
            //    name: "Ubicaciones");

            //migrationBuilder.DropTable(
            //    name: "UnidadesMedida");

            //migrationBuilder.DropTable(
            //    name: "Sucursales");

            //migrationBuilder.DropTable(
            //    name: "Inventarios");

            //migrationBuilder.DropTable(
            //    name: "EntiOrgsCont");
        }
    }
}
