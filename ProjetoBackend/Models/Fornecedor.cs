using System.ComponentModel.DataAnnotations;

namespace ProjetoBackend.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        [Required(ErrorMessage = "O Campo Nome da Categoria é Obrigatório!")]
        [Display(Name = "Fornecedor")]
        public string Nome { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O Campo Email do Cliente é Obrigatório!")]
        [EmailAddress(ErrorMessage = "O Formato do Email é Inválido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Campo Nome da Celular é Obrigatório!")]
        public string Celular { get; set; }
        [Display(Name = "CNPJ/CPF")]
        public string CnpjCpf { get; set; }
    }
}
