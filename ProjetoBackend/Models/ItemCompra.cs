using System.ComponentModel.DataAnnotations;

namespace ProjetoBackend.Models
{
    public class ItemCompra
    {
        public Guid ItemCompraId { get; set; }
        [Display(Name = "Compra")]
        public Guid CompraId { get; set; }
        [Display(Name = "Compra")]
        public Compra? Compra { get; set; }
        [Required(ErrorMessage = "Produto")]
        [Display(Name = "Produto")]
        public Guid ProdutoId { get; set; }
        [Display(Name = "Produto")]
        public Produto? Produto { get; set; }
        [Display(Name = "Quantidade")]
        public double Quantidade { get; set; }
    }
}
