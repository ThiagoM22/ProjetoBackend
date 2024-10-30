using System.ComponentModel.DataAnnotations;

namespace ProjetoBackend.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }
        public int? NotaFiscal { get; set; } = 0;
        [Required(ErrorMessage = "Cliente")]
        [Display(Name = "Cliente")]
        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        [Display(Name = "Data da Venda")]
        public DateTime? DataVenda { get; set; } = DateTime.Now;
        [Display(Name = "Valor Total")]
        public double? ValorTotal { get; set; } = 0;
    }
}
