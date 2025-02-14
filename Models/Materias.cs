using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    [Table("Materias")]
    public class Materias
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("titulo")]
        [Display(Name = "Título do Livro")]
        public string Titulo { get; set; } = string.Empty;

        [Column("ano")]
        [Display(Name = "Ano Publicação")]
        public int Ano { get; set; }
    }
}
