using BuilderAux_MVC.Models;

namespace BuilderAux_MVC.Repository
{
    public interface IUsersRepository
    {
        UsuarioModel Add(UsuarioModel User);
    }
}
