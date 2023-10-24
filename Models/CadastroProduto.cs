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

        [Column("Peso")]
        [Display(Name = "Peso")]
        public string Peso { get; set; } = string.Empty;

        [Column("Preco")]
        [Display(Name = "Praço")]

        public double Preco { get; set; }

        [Column("DataValidade")]
        [Display(Name = "Data de Validade")]

        public DateTime DataValidade { get; set; }

        [Column("Observacao")]
        [Display(Name = "Observação")]

        public string Observacao { get; set; } = string.Empty;
    }

}
