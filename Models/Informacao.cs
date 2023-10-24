using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteFinal.Models
{
    [Table("Informacao")]
    public class Informacao
    {
        [Column("Id_Informacao")]
        [Display(Name = "Informacao")]
        public int Id { get; set; }

        [Column("SaberMais")]
        [Display(Name = "Saber mais")]
        public string SaberMas { get; set; } = string.Empty;

        [Column("OqueSao")]
        [Display(Name = "O que são")]
        public string Oquesao { get; set; } = string.Empty;
    }
}
