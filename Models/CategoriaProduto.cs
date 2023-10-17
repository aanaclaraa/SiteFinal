using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SiteFinal.Models
{
    public class CategoriaProduto
    {
        [Column("CategoriaId")]
        [Display(Name = "Código da Categoria")]
        public int Id { get; set; }

        [Column("NomeCategoria")]
        [Display(Name = "Nome da Categoria")]
        public string NomeCategoria { get; set; } = string.Empty;
    }
}
