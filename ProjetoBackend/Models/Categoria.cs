using System.ComponentModel.DataAnnotations;

namespace ProjetoBackend.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }
        [Required(ErrorMessage = "O Campo Nome da Categoria é Obrigatório!")]
        public string Nome { get; set; }
    }
}
