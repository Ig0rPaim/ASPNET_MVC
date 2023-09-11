using BuilderAux_MVC.Models;

namespace BuilderAux_MVC.Repository
{
    public interface IUsersRepository
    {
        bool DeleteUser(int id);
        UsuarioModel Atualizar(UsuarioModel usuario);
        UsuarioModel ListById(int id);
        List<UsuarioModel> GetAll();
        UsuarioModel Add(UsuarioModel User);
    }
}
