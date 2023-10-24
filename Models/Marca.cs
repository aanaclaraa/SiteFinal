using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SiteFinal.Models
{
    [Table("Marca")]
    public class Marca
    {
        [Column("MarcaId")]
        [Display(Name = "Código do Marca")]
        public int Id { get; set; }

        [Column("NomeMarca")]
        [Display(Name = "Nome da Marca")]

        public string NomeMarca { get; set; } = string.Empty;

        [Column("PrecoMarca")]
        [Display(Name = "Preço da Marca")]
        public int PrecoMarca { get; set; }
    }
}
