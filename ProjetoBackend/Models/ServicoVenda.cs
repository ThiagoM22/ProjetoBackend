using System.ComponentModel.DataAnnotations;

namespace ProjetoBackend.Models
{
    public class ServicoVenda
    {
        public Guid ServicoVendaId { get; set; }
        [Required(ErrorMessage = "Serviço")]
        [Display(Name = "Serviço")]
        public Guid? ServicoId { get; set; }
        [Display(Name = "Serviço")]
        public Servico Servico { get; set; }

        [Required(ErrorMessage = "Venda")]
        [Display(Name = "Venda")]
        public Guid? VendaId { get; set; }
        [Display(Name = "Venda")]
        public Venda? Venda { get; set; }
    }
}
