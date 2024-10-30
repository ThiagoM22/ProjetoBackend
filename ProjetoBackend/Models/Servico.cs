using System.ComponentModel.DataAnnotations;

namespace ProjetoBackend.Models
{
    public class Servico
    {
        public Guid ServicoId { get; set; }
        [Required(ErrorMessage = "O Campo Nome do Serviço é Obrigatório!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo Valor do Serviço é Obrigatório!")]
        [Display(Name = "Valor")]
        public double ValorServico { get; set; }
    }
}
