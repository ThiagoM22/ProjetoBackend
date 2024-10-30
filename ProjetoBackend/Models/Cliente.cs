using System.ComponentModel.DataAnnotations;

namespace ProjetoBackend.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        [Required(ErrorMessage = "O Campo Nome do Cliente é Obrigatório!")]
        public string Nome { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O Campo Email do Cliente é Obrigatório!")]
        [EmailAddress(ErrorMessage = "O Formato do Email é Inválido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Campo Cpf do Cliente é Obrigatório!")]
        [Display(Name = "CPF")]
        public string CnpjCpf { get; set; }
        [Required(ErrorMessage = "O Campo Celular é Obrigatório!")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "O Campo Data de Nascimento é Obrigatório!")]
        [Display(Name = "Data Nasc.")]
        public DateOnly DataNascimento { get; set; }
        public DateTime? DataCadastro { get; set; } = DateTime.Now;
        public bool? CadastroAtivo { get; set; } = true;
    }
}
