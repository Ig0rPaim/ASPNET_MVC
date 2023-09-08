using BuilderAux_MVC.Data;
using BuilderAux_MVC.Models;

namespace BuilderAux_MVC.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AplicationDbContextUsuario _DbUser;
        public UsersRepository(AplicationDbContextUsuario DbUser) 
        {
            _DbUser = DbUser;
        }
        public UsuarioModel Add(UsuarioModel User)
        {
            _DbUser.Add(User);
            _DbUser.SaveChanges();
            return User;
        }
    }
}
