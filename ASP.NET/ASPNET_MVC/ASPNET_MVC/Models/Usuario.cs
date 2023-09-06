using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace ASPNET_MVC.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O tamanho minimo é 5 e o maximo é 50")]
        public string Observacoes { get; set; }
        [Range(18, 100, ErrorMessage = "A idade mínima é 18 anos")]
        public int Idade { get; set; }
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$", ErrorMessage = "Email Invalidado")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Login é obrigatório")]
        [Remote("LogingUnico", "Usuario", ErrorMessage = "Este Login já existe")]
        public string Login { get; set; }
        [StringLength(10, MinimumLength = 5, ErrorMessage = "O tamanho minimo é 5 e o maximo é 10")]
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }
        [StringLength(10, MinimumLength = 5, ErrorMessage = "O tamanho minimo é 5 e o maximo é 10")]
        [Required(ErrorMessage = "A senha é obrigatória")]
        [Compare("Senha", ErrorMessage ="As senhas não coincidem")]
        public string ConfirmarSenha { get; set; }
    }
}
