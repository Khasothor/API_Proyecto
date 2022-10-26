using System.ComponentModel.DataAnnotations;

namespace WebApi2.Models.Otros
{
    public class Test
    {
        [Key]
        public uint TestId { get; set; }

        public string Nombre { get; set; }

        public string Edad { get; set; }

        public string EntiOrgContId { get; set; }
    }
}
