using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBackend.Models
{
    public class Compra
    {
        public Guid CompraId { get; set; }
        [Required(ErrorMessage = "Fornecedor")]
        [Display(Name = "Fornecedor")]
        public Guid FornecedorId { get; set; }
        [Display(Name = "Fornecedor")]
        public Fornecedor? Fornecedor { get; set; }
        [Display(Name = "Data da Compra")]
        public DateTime? DataCompra { get; set; } = DateTime.Now;
        public double? ValorTotal { get; set; } = 0;

    }
}
