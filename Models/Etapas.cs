using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    [Table("Etapas")]
    public class Etapas
    {
        [Column("Id")]
        [Display(Name = "Código de Livro")]
        public int Id { get; set; }

        [Column("titulo")]
        [Display(Name = "Título do Livro")]
        public string Titulo { get; set; } = string.Empty;

        [Column("ano")]
        [Display(Name = "Ano")]
        public int Ano { get; set; }
    }
}
