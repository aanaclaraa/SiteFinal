using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteFinal.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Column("Id_Pessoa")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string NomePessoa { get; set; } = string.Empty;

        [Column("Idade")]
        [Display(Name = "Idade")]
        public string IdadePessoa { get; set; }

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; } = string.Empty;
    }
}
