using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi2.Models.Persona;

namespace WebApi2.Data.Initializers.Persona
{
    public class ClieProvDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.ClieProvs.Any())
            {
                return;
            }
            var clieProvs = new ClieProv[]
            {
                new ClieProv
                {
                    Codigo = "PROV1",
                    Nombre = "Proveedor 1",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 1",
                    RazonSoc = "Razon Soc proveedor 1",
                    Rating = 4,
                    Giro = "Productos Varios",
                    Status = true,
                    DatosCont = DatosContactoJson.Convertir(1),
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                },
                new ClieProv
                {
                    Codigo = "PROV2",
                    Nombre = "Proveedor 2",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 2",
                    RazonSoc = "Razon Soc proveedor 2",
                    Rating = 3,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    DatosCont = DatosContactoJson.Convertir(2)
                },
                new ClieProv
                {
                    Codigo = "PROV3",
                    Nombre = "Proveedor 3",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 3",
                    RazonSoc = "Razon Soc proveedor 3",
                    Rating = 5,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    DatosCont = DatosContactoJson.Convertir(3)
                },
                new ClieProv
                {
                    Codigo = "PROV4",
                    Nombre = "Proveedor 4",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 4",
                    RazonSoc = "Razon Soc proveedor 4",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    DatosCont = DatosContactoJson.Convertir(4)
                },
                new ClieProv
                {
                    Codigo = "PROV5",
                    Nombre = "Proveedor 5",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 5",
                    RazonSoc = "Razon Soc proveedor 5",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    DatosCont = DatosContactoJson.Convertir(5)
                },
                new ClieProv
                {
                    Codigo = "PROV6",
                    Nombre = "Proveedor 6",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 6",
                    RazonSoc = "Razon Soc proveedor 6",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    DatosCont = DatosContactoJson.Convertir(6)
                },
                //clientes empresa1
                new ClieProv
                {
                    Codigo = "CLIE1",
                    Nombre = "Proveedor 1",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del proveedor 1",
                    RazonSoc = "Razon Soc proveedor 1",
                    Rating = 4,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(1)
                },
                new ClieProv
                {
                    Codigo = "CLIE2",
                    Nombre = "cliente 2",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del cliente 2",
                    RazonSoc = "Razon Soc cliente 2",
                    Rating = 3,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(2)
                },
                new ClieProv
                {
                    Codigo = "CLIE3",
                    Nombre = "cliente 3",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del cliente 3",
                    RazonSoc = "Razon Soc cliente 3",
                    Rating = 5,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(3)
                },
                new ClieProv
                {
                    Codigo = "CLIE4",
                    Nombre = "cliente 4",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del cliente 4",
                    RazonSoc = "Razon Soc cliente 4",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(4)
                },
                new ClieProv
                {
                    Codigo = "CLIE5",
                    Nombre = "cliente 5",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del cliente 5",
                    RazonSoc = "Razon Soc cliente 5",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(5)
                },
                new ClieProv
                {
                    Codigo = "CLIE6",
                    Nombre = "cliente 6",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del cliente 6",
                    RazonSoc = "Razon Soc cliente 6",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Uno")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(6)
                },

                //empresa 2

                new ClieProv
                {
                    Codigo = "PROV1",
                    Nombre = "Proveedor 1",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 1",
                    RazonSoc = "Razon Soc proveedor 1",
                    Rating = 4,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.Convertir(1)
                },
                new ClieProv
                {
                    Codigo = "PROV2",
                    Nombre = "Proveedor 2",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 2",
                    RazonSoc = "Razon Soc proveedor 2",
                    Rating = 3,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.Convertir(2)
                },
                new ClieProv
                {
                    Codigo = "PROV3",
                    Nombre = "Proveedor 3",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 3",
                    RazonSoc = "Razon Soc proveedor 3",
                    Rating = 5,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.Convertir(3)
                },
                new ClieProv
                {
                    Codigo = "PROV4",
                    Nombre = "Proveedor 4",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 4",
                    RazonSoc = "Razon Soc proveedor 4",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.Convertir(4)
                },
                new ClieProv
                {
                    Codigo = "PROV5",
                    Nombre = "Proveedor 5",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 5",
                    RazonSoc = "Razon Soc proveedor 5",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.Convertir(5)
                },
                new ClieProv
                {
                    Codigo = "PROV6",
                    Nombre = "Proveedor 6",
                    Tipo = "P",
                    RFC = "PROV010101P10",
                    Observ = "Observacion del proveedor 6",
                    RazonSoc = "Razon Soc proveedor 6",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.Convertir(6)
                },
                //clientes empresa1
                new ClieProv
                {
                    Codigo = "CLIE1",
                    Nombre = "Cliente1",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del proveedor 1",
                    RazonSoc = "Razon Soc proveedor 1",
                    Rating = 4,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(1)
                },
                new ClieProv
                {
                    Codigo = "CLIE2",
                    Nombre = "cliente 2",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del cliente 2",
                    RazonSoc = "Razon Soc cliente 2",
                    Rating = 3,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(2)
                },
                new ClieProv
                {
                    Codigo = "CLIE3",
                    Nombre = "cliente 3",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del cliente 3",
                    RazonSoc = "Razon Soc cliente 3",
                    Rating = 5,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(3)
                },
                new ClieProv
                {
                    Codigo = "CLIE4",
                    Nombre = "cliente 4",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del cliente 4",
                    RazonSoc = "Razon Soc cliente 4",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(4)
                },
                new ClieProv
                {
                    Codigo = "CLIE5",
                    Nombre = "cliente 5",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del cliente 5",
                    RazonSoc = "Razon Soc cliente 5",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(5)
                },
                new ClieProv
                {
                    Codigo = "CLIE6",
                    Nombre = "cliente 6",
                    Tipo = "C",
                    RFC = "CLIE010101P10",
                    Observ = "Observacion del cliente 6",
                    RazonSoc = "Razon Soc cliente 6",
                    Rating = 2,
                    Giro = "Productos Varios",
                    Status = true,
                    EntiOrgId = context.EntiOrgsCont.FirstOrDefault(x => x.Nombre.Equals("Organizacion Dos")).EntiOrgContId,
                    DatosCont = DatosContactoJson.ConvertirClientes(6)
                },
            };
            try
            {
                foreach (ClieProv clieProv in clieProvs)
                {
                    context.ClieProvs.Add(clieProv);
                }
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class DatosContactoJson
    {
        class DatosContacto
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
            DatosContacto dc1 = new DatosContacto
            {
                Email = "proveedor1@mail.com",
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

            DatosContacto dc2 = new DatosContacto
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

            DatosContacto dc3 = new DatosContacto
            {
                Email = "proveedor3@mail.com",
                Telefonos =
                {
                    new Telefono
                    {
                        Numero = "234-123-3333",
                        Tipo = "Celular"
                    },
                },
                Ubicaciones =
                {
                    new Ubicacion
                    {
                        Domicilio = "Proveedores 333 sur",
                        Ciudad = "Ciudad Prov3",
                        Estado = "Estado Prov3"
                    }
                }
            };

            DatosContacto dc4 = new DatosContacto
            {
                Email = "proveedor4@mail.com",
                Telefonos =
                {
                    new Telefono
                    {
                        Numero = "234-123-4444",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "234-222-4444",
                        Tipo = "Celular"
                    },
                },
                Ubicaciones =
                {
                    new Ubicacion
                    {
                        Domicilio = "Proveedores 104 sur",
                        Ciudad = "Ciudad Prov4",
                        Estado = "Estado Prov4"
                    }
                }
            };

            DatosContacto dc5 = new DatosContacto
            {
                Email = "proveedor5@mail.com",
                Telefonos =
                {
                    new Telefono
                    {
                        Numero = "234-123-5555",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "234-222-5555",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "234-333-5555",
                        Tipo = "Fijo"
                    },
                },
                Ubicaciones =
                {
                    new Ubicacion
                    {
                        Domicilio = "Proveedores 105 sur",
                        Ciudad = "Ciudad Prov5",
                        Estado = "Estado Prov5"
                    }
                }
            };

            DatosContacto dc6 = new DatosContacto
            {
                Email = "proveedor6@mail.com",
                Telefonos =
                {
                    new Telefono
                    {
                        Numero = "234-123-1661",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "234-222-1166",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "234-333-6611",
                        Tipo = "Fijo"
                    },
                },
                Ubicaciones =
                {
                    new Ubicacion
                    {
                        Domicilio = "Proveedores 106 sur",
                        Ciudad = "Ciudad Prov6",
                        Estado = "Estado Prov6"
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
                case 3:
                    jsonString = JsonSerializer.Serialize(dc3);
                    break;
                case 4:
                    jsonString = JsonSerializer.Serialize(dc4);
                    break;
                case 5:
                    jsonString = JsonSerializer.Serialize(dc5);
                    break;
                case 6:
                    jsonString = JsonSerializer.Serialize(dc6);
                    break;
                default:
                    break;
            }

            return jsonString;
        }


        public static string ConvertirClientes(int x)
        {
            //DatosContacto dc1 = new DatosContacto();
            DatosContacto dc1 = new DatosContacto
            {
                Email = "cliente1@mail.com",
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
                        Domicilio = "cliente 111 sur",
                        Ciudad = "Ciudad clie1",
                        Estado = "Estado clie1"
                    }
                }
            };

            DatosContacto dc2 = new DatosContacto
            {
                Email = "cliente2@mail.com",
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
                        Domicilio = "cliente 222 sur",
                        Ciudad = "Ciudad cliente2",
                        Estado = "Estado cliente2"
                    }
                }
            };

            DatosContacto dc3 = new DatosContacto
            {
                Email = "cliente3@mail.com",
                Telefonos =
                {
                    new Telefono
                    {
                        Numero = "234-123-3333",
                        Tipo = "Celular"
                    },
                },
                Ubicaciones =
                {
                    new Ubicacion
                    {
                        Domicilio = "clientes 333 sur",
                        Ciudad = "Ciudad cliente3",
                        Estado = "Estado cliente3"
                    }
                }
            };

            DatosContacto dc4 = new DatosContacto
            {
                Email = "cliente4@mail.com",
                Telefonos =
                {
                    new Telefono
                    {
                        Numero = "234-123-4444",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "234-222-4444",
                        Tipo = "Celular"
                    },
                },
                Ubicaciones =
                {
                    new Ubicacion
                    {
                        Domicilio = "clientes 104 sur",
                        Ciudad = "Ciudad cliente4",
                        Estado = "Estado cliente4"
                    }
                }
            };

            DatosContacto dc5 = new DatosContacto
            {
                Email = "cliente5@mail.com",
                Telefonos =
                {
                    new Telefono
                    {
                        Numero = "234-123-5555",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "234-222-5555",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "234-333-5555",
                        Tipo = "Fijo"
                    },
                },
                Ubicaciones =
                {
                    new Ubicacion
                    {
                        Domicilio = "clientes 105 sur",
                        Ciudad = "Ciudad cliente5",
                        Estado = "Estado cliente5"
                    }
                }
            };

            DatosContacto dc6 = new DatosContacto
            {
                Email = "cliente6@mail.com",
                Telefonos =
                {
                    new Telefono
                    {
                        Numero = "234-123-1661",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "234-222-1166",
                        Tipo = "Celular"
                    },
                    new Telefono
                    {
                        Numero = "234-333-6611",
                        Tipo = "Fijo"
                    },
                },
                Ubicaciones =
                {
                    new Ubicacion
                    {
                        Domicilio = "clientes6 106 sur",
                        Ciudad = "Ciudad cliente6",
                        Estado = "Estado cliente6"
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
                case 3:
                    jsonString = JsonSerializer.Serialize(dc3);
                    break;
                case 4:
                    jsonString = JsonSerializer.Serialize(dc4);
                    break;
                case 5:
                    jsonString = JsonSerializer.Serialize(dc5);
                    break;
                case 6:
                    jsonString = JsonSerializer.Serialize(dc6);
                    break;
                default:
                    break;
            }

            return jsonString;
        }
    }
}
