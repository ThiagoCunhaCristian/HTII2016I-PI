using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThiagoCunha.Models
{
    [Table("generos")]
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 5, ErroMessage = "A descrição deve ter entre 5 e 50 caracteres" )]
        [Required]
        [Display(Nome = "Descrição")]
        public string Descricao { get; set; }

        public List<Livro> Livros { get; set; }
    }
}