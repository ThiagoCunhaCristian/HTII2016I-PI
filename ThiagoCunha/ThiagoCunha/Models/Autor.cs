using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThiagoCunha.Models
{
    [Table("autores")]
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 20, ParserErrorMessage ="O nome deve ter entre 20 a 100 caracteres")]
        [Required]
        public string Nome { get; set; }

        public List<Livro> Livors { get; set}
    }
}