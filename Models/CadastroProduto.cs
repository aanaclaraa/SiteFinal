using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SiteFinal.Models
{
    public class CadastroProduto
    {
        [Column("Id_Produto")]
        [Display(Name = "Nome do Produto")]
        public int Id { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descrição do Produto")]
        public string Descricao { get; set; } = string.Empty;
    }

}
