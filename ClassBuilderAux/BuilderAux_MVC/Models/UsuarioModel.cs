using System.ComponentModel.DataAnnotations;

namespace BuilderAux_MVC.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome do Usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite a senha do Usuário")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Digite o Email do Usuário")]
        [EmailAddress(ErrorMessage ="O email não está em um formato válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o telefone do Usuário")]
        [Phone(ErrorMessage ="O telefone informado não é válido")]
        public string Phone { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }


    }
}
