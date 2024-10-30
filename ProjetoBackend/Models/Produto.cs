using System.ComponentModel.DataAnnotations;

namespace ProjetoBackend.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        [Required(ErrorMessage = "O Campo Nome do Produto é Obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo Preço do Produto é Obrigatório!")]
        [Display(Name = "Preço")]
        public double Preco { get; set; }
        [Display(Name = "Estoque")]
        [Required(ErrorMessage = "O Campo Estoque do Produto é Obrigatório!")]
        public double Estoque { get; set; }

        /** Relacionamento entre tabelas **/
        /* Chave Estrangeria */
        [Required(ErrorMessage = "Selecione a Categoria")]
        [Display(Name = "Categoria")]
        public Guid CategoriaId { get; set; }
        [Display(Name = "Categoria")]
        public Categoria? Categoria { get; set; }

    }
}
